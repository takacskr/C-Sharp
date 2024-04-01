namespace ConsoleApp2
{
    class Person
    {
        public Person() { }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
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
