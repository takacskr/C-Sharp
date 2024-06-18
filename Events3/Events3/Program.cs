namespace Test
{
    public class Button
    {
        // Action delegate for any method to handle click
        public event Action? OnClick;

        public void Click()
        {
            // Safely invoke the event if subscribed methods exist
            OnClick?.Invoke();
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Button button = new Button();

            // Subscribe to the OnClick event (can have multiple subscribers)
            button.OnClick += () => Console.WriteLine("Button clicked!");

            Console.WriteLine("Press Enter to simulate a button click...");
            Console.ReadLine();

            // Simulate clicking the button
            button.Click();

            Console.WriteLine("Done!");
        }
    }
}