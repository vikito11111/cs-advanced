int n = int.Parse(Console.ReadLine());

var studentsGradesDictionary = new Dictionary<string, List<double>>();

while (n > 0)
{
    var input = Console.ReadLine()
        .Split(" ")
        .ToList();

    var studentName = input[0];
    var studentGrade = double.Parse(input[1]);

    if (!(studentsGradesDictionary.ContainsKey(studentName)))
    {
        studentsGradesDictionary.Add(studentName, new List<double>());
        studentsGradesDictionary[studentName].Add(studentGrade);
    }
    else
    {
        studentsGradesDictionary[studentName].Add(studentGrade);
    }

    n--;
}

foreach (var student in studentsGradesDictionary)
{
    Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => x.ToString("f2")))} (avg: {(student.Value.Average()):f2})");
}