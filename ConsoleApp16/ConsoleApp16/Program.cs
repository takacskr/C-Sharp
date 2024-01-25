using System.Security.Cryptography;

namespace ConsoleApp16
{
    class Person
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void WritePersonDataToConsole()
        {
            Console.WriteLine($"Person Id: {Id}, Person name: {Name}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person(33, "John");
            john.WritePersonDataToConsole();
        }
    }
}
