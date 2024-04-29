namespace NULL_Coalescing_Operator
{
    /*
     * The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null;
     * otherwise, it evaluates the right-hand operand and returns its result.
     * The ?? operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
     * The null-coalescing assignment operator ??= assigns the value of its right-hand operand to its left-hand operand
     * only if the left-hand operand evaluates to null.
     * 
     * The ??= operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>? numbers = null;
            int? a = null;

            Console.WriteLine(numbers is null); // True

            // If numbers is null, initialize it. Then, add 5 to numbers
            (numbers ??= new List<int>()).Add(5);
            numbers.Add(8);
            Console.WriteLine(string.Join(" ", numbers)); // 5 8
            Console.WriteLine(numbers is null); // False

            Console.WriteLine(a is null); // True

            // If a is not null, it will be used as the value
            // If a is null, then 3 will be used as the value instead
            Console.WriteLine(a ?? 3); // 3

            // if a is null then assign 0 to a, and add a to the list
            numbers.Add(a ??= 0);
            Console.WriteLine(a is null); // False
            Console.WriteLine(string.Join(" ", numbers)); // 5 8 0
            Console.WriteLine(a); // 0

            /* ÖSSZEHASONLÍTÁS */

            // ??   kifejezés részeként működik - a '??' operátor egy kifejezést kiértékel
            // ??=  értékadásra szolgál         - a '??=' operátor egy változónak ad értéket

            // Ha b értéke null, akkor c értéke 3 lesz
            int? b = null;
            int c = b ?? 3;
            Console.WriteLine($"Ha b értéke null, akkor c értéke {c} lesz"); // 3

            // Ha b értéke nem null, akkor a meglévő értékével operál - tehát c értéke 2 lesz
            // Tehát c nem kapja meg a 8-at, mivel nem null már az értéke (hanem 2)
            b = 2;
            c = b ?? 8;
            Console.WriteLine(c); // 2

            // Ha d értéke null, akkor d értéke 3 lesz
            int? d = null;
            d ??= 3;
            Console.WriteLine($"Ha d értéke null, akkor d értéke {d} lesz"); // 3


            // Ha d értéke nem null, akkor d értéke nem változik és az eredeti értéke marad meg
            d ??= 8;
            Console.WriteLine(d); // 3
        }
    }
}
