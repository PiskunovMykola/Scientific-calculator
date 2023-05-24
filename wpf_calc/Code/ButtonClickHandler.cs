using System.Windows.Controls;
using BmMathLib;

namespace wpf_calc_beta.Code
{
    public static class ButtonClickHandler
    {
        private static string ConvertSender(string btnKeyword)
        {
            #region Ahh

            switch (btnKeyword)
            {
                case ("BtnOne"):
                    return "1";

                case ("BtnTwo"):
                    return "2";

                case ("BtnThree"):
                    return "3";

                case ("BtnFour"):
                    return "4";

                case ("BtnFive"):
                    return "5";

                case ("BtnSix"):
                    return "6";

                case ("BtnSeven"):
                    return "7";

                case ("BtnEight"):
                    return "8";

                case ("BtnNine"):
                    return "9";

                case ("BtnZero"):
                    return "0";

                case ("BtnEqual"):
                    return MathStuff.Equal;

                case ("BtnPlus"):
                    return MathStuff.Plus;

                case ("BtnMinus"):
                    return MathStuff.Minus;

                case ("BtnMult"):
                    return MathStuff.Mult;

                case ("BtnDivide"):
                    return MathStuff.Div;

                case ("BtnDot"):
                    return MathStuff.Dot;

                case ("BtnSqrt"):
                    return MathStuff.Root;

                case ("BtnFact"):
                    return MathStuff.Fact;

                case ("BtnSin"):
                    return MathStuff.Sine;

                case ("BtnCos"):
                    return MathStuff.Cosine;

                case ("BtnTan"):
                    return MathStuff.Tangent;

                case ("BtnCtg"):
                    return MathStuff.Cotangent;

                case ("BtnDeg"):
                    return MathStuff.Deg;

                case ("BtnLogComma"):
                    return MathStuff.Comma;

                case ("BtnLog"):
                    return MathStuff.Log;

                case ("BtnLg"):
                    return MathStuff.Lg;

                case ("BtnLn"):
                    return MathStuff.Ln;

                case ("BtnPi"):
                    return MathStuff.Pi;

                case ("BtnExp"):
                    return MathStuff.Exp;

                case ("Pow"):
                    return MathStuff.Pow;

                case ("OpenBr"):
                    return "(";

                case ("CloseBr"):
                    return ")";

                case ("FuncShow"):
                    return "funcsmenu";

                case ("Remove"):
                    return "r";

                case ("Clear"):
                    return "c";
            }

            #endregion

            return string.Empty;
        }

        public static string HandleSender(object sender)
        {
            var senderName = ((Button) sender).Name; //Getting name from button to sort them as we need
            return ConvertSender(senderName);
        }
    }
}