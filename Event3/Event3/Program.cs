namespace Event2
{
    class TestEventArgs : EventArgs
    {
        public TestEventArgs(string message)
        : base()
        {
            this.Message = message;
        }
        public string Message { get; set; }
    }
    class Test
    {
        public delegate void EventHandlerDelegate(object sender, TestEventArgs e);
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
                // A 'this' az az objektum, amely kiváltotta az eseményt
                TestStatusChange(this, new TestEventArgs("Az osztály állapota megváltozott"));
            }
        }
    }
    class Program
    {
        static public void Handler(object sender, TestEventArgs e)
        {
            Console.WriteLine(e.Message);
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
