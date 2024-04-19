using System;

namespace CalculateLibrary
{
    public class Calculate
    {
        private int _number1, _number2 = 0;

        int Number1
        {
            get { return _number1; }
            set { _number1 = value; }
        }
        int Number2 { get; set; }

        public Calculate()
        {
            this.Number1 = _number1;
            this.Number2 = _number2;
        }

        // There is no the "return" keyword because we use the "out" 
        public static void Multiple(int number1, int number2, out int result)
        {
            result = number1 * number2;
        }
    }
}
