using Grade = decimal;

var dustin = new Student(894562, "Dustin Campbell");

dustin.AddGrades([4.0m, 3.8m, 3.9m]);

Console.WriteLine(dustin.GPA);

public class Student(int id, string name)
{
    List<Grade> _grades = [];

    public void AddGrades(params Grade[] grades) => _grades.AddRange(grades);
    public void AddGrades(IEnumerable<Grade> grades) => _grades.AddRange(grades);
    public void AddGrades(ReadOnlySpan<Grade> grades) => _grades.AddRange(grades);

    public int Id => id;

    public string Name { get; set; } = name;

    public Grade GPA => _grades switch
    {
        [] => 4.0m,
        [var grade] => grade,
        [.. var all] => all.Average()
    };
}