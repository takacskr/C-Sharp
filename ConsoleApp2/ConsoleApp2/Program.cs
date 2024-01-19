namespace ConsoleApp2
{
    class Person
    {
        public Person() { }

        private string name;
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Name = "István",
            };

            Console.WriteLine(p.Name);
        }
    }
}
