using System.Collections;

namespace IEnumerator_IEnumerable
{
    // Ez az interface a foreach-nek fogja szolgáltatni a megfelelő felületet
    // A ciklus meghívja majd a GetEnumerator metódust és ez visszaadja
    // az osztályt IEnumerator-ként (implicit konverzió)
    public interface IEnumerable
    {
        IEnumerator GetEnumerator ();
    }

    // IEnumerator interfész megvalósítása
    public interface IEnumerator
    {
        // A következő elemre mozgatja a mutatót
        // Ha a lista végére ért, false értékkel tér vissza
        bool MoveNext ();
        
        // Alapértelmezett értékre állítja a mutatót
        void Reset ();

        // Ez a (read only) property az aktuális pozícióban lévő elemet adja vissza
        // Object típussal tér vissza
        object Current { get; }
    }

    public class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            this.Name = name;
        }
    }

    // Megvalósítjuk mindkét interface-t ebben az osztályban
    public class AnimalContainer : IEnumerable, IEnumerator
    {
        // Animal objektumokból álló listát fog tartalmazni
        private ArrayList container = new ArrayList();
        
        // Reset az aktuális pozíció értékére
        private int currPosition = -1;
        
        // Eltároljuk az objektumokat
        public AnimalContainer()
        {
            container.Add(new Animal("Füli"));
            container.Add(new Animal("Bundás"));
            container.Add(new Animal("Parizer"));
            container.Add(new Animal("Zsömi"));
            container.Add(new Animal("Aga"));
            container.Add(new Animal("Fickó"));
        }

        // Implementáljuk az IEnumerator által igényelt metódusokat
        public bool MoveNext()
        {
            return (++currPosition < container.Count);
        }

        public object Current
        {
            get { return container[currPosition]; }
        }

        public void Reset()
        {
            currPosition = -1;
        }

        // IEnumerable interface megvalósítása
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // A foreach csak olyan osztályokon képes végigiterálni, melyek megvalósítják
            // az IEnumerator és IEnumerable interfészeket
            AnimalContainer ac = new AnimalContainer();

            // A foreach ciklussal végigmegyünk az AnimalContainer objektumon
            foreach (Animal animal in ac)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
