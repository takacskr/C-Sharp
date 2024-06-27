using static System.Net.Mime.MediaTypeNames;

/*
 * Ebben a példában bejárunk egy láncolt listát, a kimeneten a „narancs” elemet
 * látjuk majd első helyen, mivel őt az AddFirst metódussal helyeztük be
*/

namespace List6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A "LinkedList" egy kétirányú láncolt lista
            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("alma");
            list.AddLast("dió");
            list.AddLast("körte");
            list.AddFirst("narancs");

            // A lista minden tagja különálló objektum, egy-egy "LinkedListNode<T>" példány
            // A "LinkedListLNode<T>" Next és Previous tulajdonságai a megelőző illetve a következő elemre mutatnak
            LinkedListNode<string>? node = list.First;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
