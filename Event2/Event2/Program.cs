namespace Event2
{
    class Test
    {
        public delegate void EventHandlerDelegate(string message);
        public event EventHandlerDelegate TestStatusChange;
        private int data = 10;
        public int Data
        {
            get { return data; }
            set
            {
                data = value;
                this.OnStatusChange();
            }
        }
        private void OnStatusChange()
        {
            if (TestStatusChange != null)
            {
                TestStatusChange("Az osztály állapota megváltozott!");
            }
        }
    }
    class Program
    {
        static public void Handler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Test t = new Test();
            t.TestStatusChange += Program.Handler;
            t.Data = 11;
            Console.ReadKey();
        }
    }
}
