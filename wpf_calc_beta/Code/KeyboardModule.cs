using System.Windows.Input;
using BmMathLib;

namespace wpf_calc_beta.Code
{
    public static class KeyboardModule
    {
        public static string KeyClickHandle(Key input)
        {
            switch (input)
            {
                //Числа
                case (Key.D1):
                case (Key.NumPad1):
                    return Keyboard.IsKeyDown(Key.LeftShift) ? "!" : "1";

                case (Key.D2):
                case (Key.NumPad2):
                    return "2";

                case (Key.D3):
                case (Key.NumPad3):
                    return "3";

                case (Key.D4):
                case (Key.NumPad4):
                    return "4";

                case (Key.D5):
                case (Key.NumPad5):
                    return "5";

                case (Key.D6):
                case (Key.NumPad6):
                    return Keyboard.IsKeyDown(Key.LeftShift) ? "^" : "6";

                case (Key.D7):
                case (Key.NumPad7):
                    return "7";

                case (Key.D8):
                case (Key.NumPad8):
                    return Keyboard.IsKeyDown(Key.LeftShift) ? MathStuff.Mult : "8";

                case (Key.D9):
                case (Key.NumPad9):
                    return Keyboard.IsKeyDown(Key.LeftShift) ? "(" : "9";

                case (Key.D0):
                case (Key.NumPad0):
                    return Keyboard.IsKeyDown(Key.LeftShift) ? ")" : "0";

                //Действия
                case (Key.OemPlus):
                case (Key.Enter):
                    if (Keyboard.IsKeyDown(Key.LeftShift) && input == Key.OemPlus)
                    {
                        return MathStuff.Plus;
                    }

                    return MathStuff.Equal;

                case (Key.OemMinus):
                case (Key.Subtract):
                    return MathStuff.Minus;

                case (Key.Back):
                    return "r";

                case (Key.Divide):
                    return MathStuff.Div;

                case (Key.Multiply):
                    return MathStuff.Mult;

                case (Key.Add):
                    return MathStuff.Plus;

                case (Key.Decimal):
                    return MathStuff.Dot;
            }

            return string.Empty;
        }
    }
}