namespace List6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kétirányú láncolt lista
            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("alma");
            list.AddLast("dió");
            list.AddLast("körte");
            list.AddFirst("narancs");

            // A lista minden tagja különálló objektum, egy-egy LinkedListNode<T> példány
            LinkedListNode<string> node = list.First;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
