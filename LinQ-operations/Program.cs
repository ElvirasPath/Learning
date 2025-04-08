using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //Language Integrated Query
    //Operate on IEnumerable<T>
    //LINQ helps with mapping, filtering and reducing
    //map: transform each element in a collection 
    // LINQ	A way to query/filter/sort data in C#
    //Lambda	A short function written like x => x > 0
    //Predicate	A function that returns true or false (often used in filtering)
    static void Main(string[] args)
    {
        Student student = new Student();
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 17, Grade = 85, Class = "A" },
            new Student { Name = "Bob", Age = 18, Grade = 92, Class = "B" },
            new Student { Name = "Charlie", Age = 17, Grade = 70, Class = "A" },
            new Student { Name = "Diana", Age = 16, Grade = 95, Class = "B" },
            new Student { Name = "Evan", Age = 18, Grade = 60, Class = "C" },
            new Student { Name = "Fiona", Age = 17, Grade = 77, Class = "C" }
        };

        // LINQ with lambda predicate to get grades > 80
        // var topStudents = from s in students
        //                   where s.Grade >= 80
        //                   select s; 
        //.Where(...) → LINQ method; n => n > 20 → lambda expression; n > 20 → predicate condition

        var topStudents = students.Where(s => s.Grade >= 80);
        Console.WriteLine("Top students: ");
        foreach (var student1 in topStudents)//
        {
            Console.WriteLine($"{student1.Name} - Grade: {student1.Grade}");
        }
        Console.WriteLine();
        // bool HasGoodGrade(Student s)
        // {
        //     return s.Grade >= 80;
        // }
        // var greatGradeStudents = students.Where(HasGoodGrade);
        //foreach (var student in topStudents) Console.WriteLine($"{student1.Name} - Grade: {student1.Grade}");

        var sortedStudents = students.OrderBy(s => s.Name);
        Console.Write("Ordered students: ");
        foreach (var student1 in sortedStudents)
        {
            Console.Write($"{student1.Name}; ");
        }
        Console.WriteLine();

        var gropedByClass = students.GroupBy(s => s.Class); // groups students based on the Class value
        foreach (var group in gropedByClass)
        {
            Console.WriteLine();
            Console.WriteLine($"Class {group.Key}"); // gives you the class name (A,B,C)
            foreach (var student1 in group)
            {
                Console.WriteLine($" - {student1.Name}");
            }
        }
        Console.WriteLine();
        double averageGrade = students.Average(s => s.Grade);
        Console.WriteLine($"Average Grade: {averageGrade}");
        Console.WriteLine();

        // Predicate<Student> hasPassed = s => s.Grade >= 50;
        // double averagePassingGrade = students
        //         .Where(s => hasPassed(s))
        //         .Average(s => s.Grade);
        // Console.WriteLine($"Average passing grade {averagePassingGrade}");

        //Filter -> Sort Desc -> Select Names)
        Console.WriteLine("High Scorers:");
        var highScorers = students
                .Where(s => s.Grade > 90)
                .OrderByDescending(s => s.Grade)
                .Select(s => s.Name);

        foreach (var name in highScorers)
        {
            Console.Write($"{name}; ");
        }

        // Predicate<Student> isHighScorer = s => s.Grade > 75;
        // var highScorerNames = students
        //         .Where(s => isHighScorer(s)) using predicate
        //         .OrderByDescending(s => s.Grade)
        //         .Select(s => s.Name);
        // foreach (var name on highScorerNames)
        // {
        //     Console.Write($"{name}; ");
        // }
    }           
}

public class Student
{
    public string? Name { get; set; } //property

    public int Age { get; set; }

    public int Grade { get; set; }

    public string? Class { get; set; }

    // public Student(string? name, int age, int grade, string? @class)
    // {
    //     Name = name;
    //     Age = age;
    //     Grade = grade;
    //     Class = @class;
    // }
}
