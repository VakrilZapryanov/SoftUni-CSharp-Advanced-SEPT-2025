int gradesCount = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> studentRecords = new();

for (int i = 0; i < gradesCount; i++)
{
    string[] currentStudentInformation = Console.ReadLine().Split();

    string name = currentStudentInformation[0];
    decimal grade = decimal.Parse(currentStudentInformation[1]);

    if (!studentRecords.ContainsKey(name))
        studentRecords[name] = new List<decimal>();

    studentRecords[name].Add(grade);
}

foreach (var (name, grades) in studentRecords)
{
    var fixedGrades = grades.Select(gr => gr.ToString("F2"));

    var joinedGrades = string.Join(" ", fixedGrades);

    Console.WriteLine($"{name} -> {joinedGrades} (avg: {grades.Average():f2})");
}
