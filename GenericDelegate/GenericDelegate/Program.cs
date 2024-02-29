namespace GenericDelegate
{
    class Person
    {
        public int Age;
    }

    class Student : Person
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        delegate void Method<out T>();

        static void Main()
        {
            Method<Student> m1 = () => new Student();
            Method<Person> m2 = m1;

            IEnumerable<Student> sie = new List<Student>()
            {
                new Student() { Name = "Szandra", Age = 22 },
                new Student() { Name = "István", Age = 26 },
            };

            IEnumerable<Person> pie = sie;
            foreach (Person person in pie)
            {
                Console.WriteLine(person.Age);
            }
        }
    }
}
