using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using org.mariuszgromada.math.mxparser;

namespace BmMathLib
{
    public class MathCalculatorCore
    {
        public string MathString { get; set; }

        public MathCalculatorCore()
        {
            MathString = "0";
        }

        public string MakeExpression(string mathString)
        {
            while (!mathString.IsNumber() && !mathString.EndsWith(")") && !mathString.EndsWith(MathStuff.Fact) &&
                   !mathString.EndsWith(MathStuff.Deg) && !mathString.EndsWith(MathStuff.Pi) && !mathString.EndsWith(MathStuff.Exp))
            {
                if (mathString == string.Empty) return "0";
                mathString = mathString.Remove(mathString.Length - 1);
            }

            return PlaceBrackets(mathString);
        }
        
        private static string ReplaceActionsToEvaluate(string mathString) => mathString.Replace(MathStuff.Mult, "*").Replace(MathStuff.Div, "/")
            .Replace(MathStuff.Root, "sqrt(")
            .Replace(MathStuff.Pi, "pi").Replace(MathStuff.Deg, "*[deg]").Replace(MathStuff.Lg, "log10(");


        public string EvaluateExpression()
        {
            double resultDouble;
            var mathString = ReplaceActionsToEvaluate(MakeExpression(MathString));
            try
            {
                resultDouble = new Expression(mathString).calculate();
            }
            catch (DivideByZeroException)
            {
                resultDouble = double.NaN;
            }
            catch (OverflowException)
            {
                resultDouble = double.PositiveInfinity;
            }

            string resultString;
            if (!double.IsNaN(resultDouble))
            {
                resultString = resultDouble.ToString(CultureInfo.CurrentCulture)
                    .Replace(MathStuff.Comma, MathStuff.Dot);
            }
            else resultString = "Error";

            return resultString;
        }

        private static int GetBracketsQuantity(string mathString)
        {
            var mathLength = mathString.Length;
            var openBracketsQuantity = mathLength - mathString.Replace("(", string.Empty).Length; //Кол-во открывающихся скобок
            var closeBracketsQuantity = mathLength - mathString.Replace(")", string.Empty).Length; //Кол-во закрывающихся скобок

            return openBracketsQuantity - closeBracketsQuantity;
        }

        private string PlaceBrackets(string mathString)
        {
            var brAmt = GetBracketsQuantity(mathString);
            return mathString + string.Concat(Enumerable.Repeat(")", brAmt));
        }

        private void AddString(string s) => MathString += s;

        private void RemoveString(int amt) => MathString = MathString.Remove(MathString.Length - amt);

        public void NumberClick(string num)
        {
            if (MathString == "0") RemoveString(1);
            if (MathString.IsMultNeed())
                AddString(MathStuff.Mult);
            AddString(num);
        }

        public void ActionClick(string act)
        {
            #region MinusAfterSymbols

            if (MathString.IsMatchToRe(new Regex(@"[\(÷×\^]$")) && act == MathStuff.Minus)
            {
                AddString(act);
                return;
            }

            if (MathString.IsMatchToRe(new Regex(@"(\(\-|\^\-|×\-|÷\-)$")) && act == MathStuff.Plus)
            {
                RemoveString(1);
                return;
            }

            if (MathString.IsMatchToRe(new Regex(@"(\(\-|\^\-|×\-|÷\-)$"))) return;

            #endregion

            switch (MathString)
            {
                case "0" when act == MathStuff.Minus:
                    MathString = MathStuff.Minus;
                    break;
                case MathStuff.Minus when act == MathStuff.Plus || act == MathStuff.Mult || act == MathStuff.Div:
                    return;
            }

            if (MathString.EndsWith(MathStuff.Comma) || MathString.EndsWith("(")) return;
            if (MathString.CheckForAction() || MathString.EndsWith(MathStuff.Dot)) RemoveString(1);
            AddString(act);
        }

        public void DotClick()
        {
            if (MathString.EndsWith(MathStuff.Dot)) return;
            if (MathString.IsMatchToRe(new Regex(@"([^0-9])$")))
            {
                NumberClick("0");
            }
            else if (MathString.IsMatchToRe(new Regex(@"\.[0-9]*$"))) return;
            AddString(MathStuff.Dot);
        }

        public void EqualClick()
        {
            MathString = EvaluateExpression();
        }

        public void BracketClick(string bracket)
        {
            if (GetBracketsQuantity(MathString) <= 0 && bracket == ")") return;
            if ((MathString.CheckForAction() ||
                 MathString.EndsWith("(")) && bracket == ")") return;

            if (MathString.EndsWith(MathStuff.Dot) ||
                MathString == "0") RemoveString(1);

            if (MathString != string.Empty && bracket == "(" && (MathString.IsNumber() ||
                                                           MathString.EndsWith(")") ||
                                                           MathString.EndsWith(MathStuff.Pi) ||
                                                           MathString.EndsWith(MathStuff.Exp) ||
                                                           MathString.EndsWith(MathStuff.Deg))) AddString(MathStuff.Mult);
            AddString(bracket);
        }

        public void PowClick()
        {
            if (MathString.CheckForAction() ||
                MathString.EndsWith("(") ||
                MathString.EndsWith(MathStuff.Pow)) return;
            if (MathString.CheckForAction() ||
                MathString.EndsWith(MathStuff.Dot)) RemoveString(1);
            AddString(MathStuff.Pow);
        }

        public void FactorialClick()
        {
            if (!MathString.IsNumber() && !MathString.EndsWith(MathStuff.Pi) && !MathString.EndsWith(MathStuff.Exp) &&
                !MathString.EndsWith(")")) return;
            AddString(MathStuff.Fact);
        }

        public void SqrtClick()
        {
            if (MathString == "0" || MathString.EndsWith(MathStuff.Dot)) RemoveString(1);
            if (MathString.IsNumber() && MathString.Length != 0 || MathString.IsMultNeed()) AddString(MathStuff.Mult);
            AddString(MathStuff.Root);
        }

        public void ConstantClick(string cnst)
        {
            if (MathString == "0" || MathString.EndsWith(MathStuff.Dot)) RemoveString(1);
            if ((MathString.IsNumber() || MathString.IsMultNeed()) && MathString.Length != 0) AddString(MathStuff.Mult);
            AddString(cnst);
        }

        public void FunctionClick(string func)
        {
            if (MathString == "0" || MathString.EndsWith(MathStuff.Dot)) RemoveString(1);
            if (MathString.IsNumber() && MathString.Length != 0 || MathString.IsMultNeed()) AddString(MathStuff.Mult);
            AddString(func);
        }

        public void SpecClick(string spec)
        {
            if ((MathString.IsNumber() || MathString.EndsWith(MathStuff.Pi) || MathString.EndsWith("e") || MathString.EndsWith(")") ||
                 MathString.EndsWith(MathStuff.Deg) || MathString.EndsWith(",")) &&
                !MathString.EndsWith(spec)) AddString(spec);
        }

        public void RemoveClick()
        {
            RemoveString(MathString.RemoveQuantityCheck());
            MathString = MathString == string.Empty ? "0" : MathString;
        }

        public void Clear() => MathString = "0";
    }
}