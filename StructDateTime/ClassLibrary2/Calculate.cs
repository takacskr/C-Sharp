using System;

namespace CalculateLibrary
{
    public class Calculate
    {
        int number1, number2 = 0;

        int Number1 { get; set; }
        int Number2 { get; set; }

        public Calculate()
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }

        public static int Multiple(int number1, int number2)
        {
            return (number1 * number2);
        }
    }
}
