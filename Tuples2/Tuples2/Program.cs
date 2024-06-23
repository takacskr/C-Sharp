using System;

class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Major { get; set; }
}

class TupleExample
{
    static void Main(string[] args)
    {
        // Create a list of students
        List<Student> students = new List<Student>()
        {
            new Student { Name = "John", Age = 20, Major = "Computer Science" },
            new Student { Name = "Emily", Age = 42, Major = "Biology" },
            new Student { Name = "Michael", Age = 21, Major = "Mathematics" }
        };

        // Use a tuple to return multiple values from a method
        foreach (Student student in students)
        {
            (double averageGpa, bool honors) = CalculateGpaAndHonors(student);

            Console.WriteLine($"Name: {student.Name}, Average GPA: {averageGpa:F2}, Honors: {honors}");
        }
    }

    static (double, bool) CalculateGpaAndHonors(Student student)
    {
        // Simulate calculating the average GPA and honors
        double averageGpa = (student.Age + 3.5) / 10;
        bool honors = averageGpa >= 3.7;

        return (averageGpa, honors);
    }
}