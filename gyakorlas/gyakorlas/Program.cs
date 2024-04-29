namespace gyakorlas
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Give me a number: ");

            // The _ symbol is used to indicate that the result of the int.Parse() method is not actually being used
            _ = int.Parse(Console.ReadLine());

            dynamic d = "apple";
            Console.WriteLine(d);

            d = 10;
            Console.WriteLine(d);

            int number = 10;

            Console.WriteLine(typeof(int) == number.GetType());

            unsafe
            {
                Console.WriteLine(sizeof(int));

                int x = 100;
                int* ptr = &x;

                Console.WriteLine("Displays the memory address: " + (int)ptr);
                Console.WriteLine("Displays the value at the memory address: " + * ptr); // 100

                x = 200;

                Console.WriteLine("Displays the value at the memory address: " + * ptr); // 200
            }
        }
    }
}
