using System;

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

    class Program
    {
        // Definiáljuk a generikus delegát típust, amelynek típusparamétere kontravariáns.
        delegate void Method<in T>(T t);

        static void Main(string[] args)
        {
            // Létrehozunk egy m1 delegát példányt, amely egy Person típusú objektumot vár.
            // Ez a delegát kiírja az Age tulajdonságot a konzolra.
            Method<Person> m1 = (person) => Console.WriteLine(person.Age);

            // Létrehozunk egy m2 delegát példányt, és az m1 delegátra mutatunk rá.
            // Mivel a Method<T> delegát típus kontravariáns a T típusparaméterre nézve,
            // ezért lehetséges az m2-t m1-re konvertálni, mivel a Student típus egy Person típus leszármazottja.
            Method<Student> m2 = m1;

            // Létrehozunk egy Student objektumot, beállítjuk az Age és Name tulajdonságait.
            Student s = new Student()
            {
                Age = 22,
                Name = "Szandra"
            };

            // Meghívjuk mindkét delegátot a s objektummal.
            // Mindkét esetben a Student objektum Age tulajdonságát írjuk ki, és az eredmény 22 lesz mindkét esetben.
            m1(s); // 22
            m2(s); // 22

            Console.ReadKey();
        }
    }
}
