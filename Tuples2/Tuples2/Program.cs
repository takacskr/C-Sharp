using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }
}

class TupleExample
{
    static void Main(string[] args)
    {
        // Create a list of students
        var students = new[]
        {
            new Student { Name = "John", Age = 20, Major = "Computer Science" },
            new Student { Name = "Emily", Age = 22, Major = "Biology" },
            new Student { Name = "Michael", Age = 21, Major = "Mathematics" }
        };

        // Use a tuple to return multiple values from a method
        foreach (var student in students)
        {
            var (averageGpa, honors) = CalculateGpaAndHonors(student);

            Console.WriteLine($"Name: {student.Name}, Average GPA: {averageGpa:F2}, Honors: {honors}");
        }
    }

    static (double, bool) CalculateGpaAndHonors(Student student)
    {
        // Simulate calculating the average GPA and honors
        double averageGpa = 3.5;
        bool honors = averageGpa >= 3.7;

        return (averageGpa, honors);
    }
}