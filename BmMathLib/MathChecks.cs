using System.Text.RegularExpressions;
using org.mariuszgromada.math;

namespace BmMathLib
{
    public static class MathChecks
    {
        public static bool CheckForAction(this string s) =>
            s.EndsWith(MathStuff.Plus) ||
            s.EndsWith(MathStuff.Minus) ||
            s.EndsWith(MathStuff.Mult) ||
            s.EndsWith(MathStuff.Div) ||
            s.EndsWith(MathStuff.Pow);

        public static int RemoveQuantityCheck(this string s)
        {
            if (s.EndsWith(MathStuff.Sine) ||
                s.EndsWith(MathStuff.Cosine) ||
                s.EndsWith(MathStuff.Tangent) ||
                s.EndsWith(MathStuff.Cotangent) ||
                s.EndsWith(MathStuff.Log))
                return 4;

            if (s.EndsWith(MathStuff.Lg) ||
                s.EndsWith(MathStuff.Ln))
                return 3;

            if (s.EndsWith(MathStuff.Root) ||
                s.Length == 2 && s[0] == '-')
                return 2;

            return 1;
        }

        public static bool IsMultNeed(this string s) => s.EndsWith(")") ||
                                                        s.EndsWith(MathStuff.Pi) ||
                                                        s.EndsWith(MathStuff.Exp) ||
                                                        s.EndsWith(MathStuff.Deg) ||
                                                        s.EndsWith(MathStuff.Fact);

        public static bool IsNumber(this string s)
        {
            return s != string.Empty && int.TryParse(s[s.Length - 1].ToString(), out _);
        }
        public static bool IsMatchToRe(this string expression, Regex re)
        {
            return re.IsMatch(expression);
        }

    }
}