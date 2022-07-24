using System.Linq;

// Extension method syntax
var l = new[] { 1, 2, 3, 4, 5 };
// Lambda expression
var l2 = l.Select(x => x * 2);
Console.WriteLine(string.Join(", ", l2));

// Old query syntax
var l3 = from x in l
         select x * 2;
Console.WriteLine(string.Join(", ", l3));

// Pattern matching
var s = new Student("John", "john@gmail.com", 21, 13);
if (s is { Age: < 18, Grade: > 17})
{
    Console.WriteLine("School student whith high grade");
}
if (s is { Name: "John", Age: > 18})
{
    Console.WriteLine("John which is university student");
}

var students = new List<Student>
{
    new Student("John", "john@gmail.com", 19),
    new Student("Jane", "jane@gmail.com", 20),
    new Student("Joe", "joe@gmail.com", 16),
    new Student("Jack", "jack@gmail.com", 17),
    new Student("Jill", "jill@gmail.com", 11),
};

// More LINQ
var studentsWithHighGrade = students.Where(s => s.Grade > 17);