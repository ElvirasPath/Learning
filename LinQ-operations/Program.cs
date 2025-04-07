using System;

class Program
{
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
    }
}

public class Student
{
    public string? Name { get; set; } //property

    public int Age { get; set; }

    public int Grade { get; set; }

    public string? Class { get; set; }

    // public Student(string? name, int age, int grade, string? class)
    // {
    //     Name = name;
    //     Age = age;
    //     Grade = grade;

    // }
}