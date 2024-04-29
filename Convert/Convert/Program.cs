using System;

namespace ConvertNumbers
{
    internal class Program
    {
        public enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {
            Console.WriteLine((int)Days.Thursday); // 4
            Console.WriteLine(Days.Thursday.ToString()); // Thursday
            Console.WriteLine((Days)3); // Wednesday

            Console.WriteLine(typeof(Days));

            foreach (var data in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(data+" - "+ (int)Enum.Parse(typeof(Days), data));
            }

            // Converting a double to an integer
            double d = 45.456;
            int i = Convert.ToInt32(d);
            Console.WriteLine($"Value of i: {i}");

            // Converting a double to an integer
            double d2 = 45.456;
            int i2 = (int)d2;
            Console.WriteLine($"Value of i2: {i2}");

            // Converting a string to an integer
            string str = "123";
            int number;

            if (int.TryParse(str, out number))
            {
                Console.WriteLine($"The number is: {number}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // Checking the type of a variable
            if (number is int)
            {
                Console.WriteLine($"Type of the number is int.");
            }

            Type type = str.GetType();
            if (type == typeof(string))
            {
                Console.WriteLine($"str is a {type}");
            }

            if (typeof(string) == str.GetType())
            {
                Console.WriteLine("str is a string.");
            }

            int number2 = 123;
            string str2 = number2.ToString();

            // Using the "as" operator
            object a = "123";
            object b = "Hello";
            object c = 10;

            // Amennyiben ez a konverzió nem hajtható végre, a célváltozóhoz null érték rendelődik
            // (ezért is van a referencia típusokra korlátozva ez az operátor)
            string aa = a as string;
            Console.WriteLine(aa == null ? "NULL" : aa); // aa
        }
    }
}