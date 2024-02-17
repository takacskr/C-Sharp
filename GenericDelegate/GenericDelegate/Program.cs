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

        static void Main(string[] args)
        {
            Method<Student> m1 = () => new Student();
            Method<Person> m2 = m1;
        }
    }
}
