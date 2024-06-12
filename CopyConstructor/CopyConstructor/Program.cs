namespace CopyConstructor
{
    internal class Program
    {
        public class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public Person(Person copyFrom)
            {
                name = copyFrom.name;
                age = copyFrom.age;
            }

            public Person() {
                // Do nothing.
            }
        }

        static void Main(string[] args)
        {
            Person person1 = new Person () { name = "John", age = 30 };
            Person person2 = new Person(person1); // másoló konstruktor használata
            Person person3 = new Person("Kevin", 29); // use inputs param constructor
            Person person4 = new Person(); // ilyenkor fut le a paraméter nélküli konstruktor

            person2.name = "Jane"; // az eredeti objektum nem módosul

            Console.WriteLine(person1.name); // John
        }
    }
}
