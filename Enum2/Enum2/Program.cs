// Define an enum with the Flags attribute to represent days of the week
[Flags]
enum DaysOfWeek
{
    None = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 4,
    Thursday = 8,
    Friday = 16,
    Saturday = 32,
    Sunday = 64
}

public class Program
{
    public static void Main()
    {
        // Create a variable with selected days
        DaysOfWeek selectedDays = DaysOfWeek.Monday | DaysOfWeek.Wednesday | DaysOfWeek.Friday;

        // Check if specific days are selected
        if (selectedDays.HasFlag(DaysOfWeek.Monday))
        {
            Console.WriteLine("Monday is selected.");
        }

        if (selectedDays.HasFlag(DaysOfWeek.Tuesday))
        {
            Console.WriteLine("Tuesday is selected.");
        }

        // Combine additional days
        selectedDays |= DaysOfWeek.Tuesday;

        // Check the combined days
        Console.WriteLine("Selected days: {0}", selectedDays);
    }
}

/*
 * Output:
 * Monday is selected.
 * Selected days: Monday, Tuesday, Wednesday, Friday
 * */