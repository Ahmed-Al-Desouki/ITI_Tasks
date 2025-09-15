using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day_4_CSharp.Program1;

namespace Day_4_CSharp
{
    //------------- Person -------------
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Id = IdGenerator.GenerateId();
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
        {
            Name = name;
        }

        public abstract void Introduce();
    }
    //------------ Instractor -----------
    public class Instractor : Employee
    {
        public List<course> courses { get; set; } = new List<course>(); // <-- Add this initialization
        public Instractor(string name, int age) : base(name, age) { }

        public override void Introduce()
        {
            Console.WriteLine($"Hi I'm Instractor: {Name}");
        }

        public void TeachCourse(course c)
        {
            courses.Add(c);
            Console.WriteLine($"{Name} The Instractor of the course: {c.Name}");
        }

    }
    //------------- Course ----------------
    public class course
    {
        public string Name { get; set; }
        public Instractor Ins { get; set; }
        public List<Student> Stu { get; set; } = new List<Student>();
        public CourseLevel Level { get; set; }
        public course(string name, CourseLevel level)
        {
            Name = name;
            Level = level;
        }
    }

    //------------------ Student -------------
    public class Student : Person
    {
        public List<course> courses { get; set; } = new List<course>();
        public List<Grade> Grades { get; set; } = new List<Grade>();
        public Student(string name, int age) : base(name, age) { }
        override
        public void Introduce()
        {
            Console.WriteLine($"Hi I'm Student {Name}");
        }
        public void RegisterCourse(course c)
        {
            c.Stu.Add(this);
            courses.Add(c);
            Console.WriteLine($"I'm Student {Name} Inroled in corse {c.Name}");

            switch (c.Level)
            {
                case CourseLevel.Beginner:
                    Console.WriteLine("Good luck starting out!");
                    break;
                case CourseLevel.Intermediate:
                    Console.WriteLine("Keep pushing forward!");
                    break;
                case CourseLevel.Advanced:
                    Console.WriteLine("This will be challenging!");
                    break;
            }
        }


    }
    internal class Program2
    {

        //--------------- Main ----------------
        //public static void Main(string[] args) 
        //{
        //    Instractor I = new Instractor("Ahmed", 30);

        //    Student s1 = new Student("Ali", 15);
        //    Student s2 = new Student("Moaz", 18);

        //    course c1 = new course("C#");
        //    course c2 = new course("SQL");

        //    I.TeachCourse(c1);

        //    s1.RegisterCourse(c2);
        //    s1.RegisterCourse(c1);
        //    s2.RegisterCourse(c2);

        //    Console.WriteLine("Students:");
        //    foreach (var st in c1.Stu)
        //    {
        //        Console.WriteLine($" - {st.Name}");
        //    }
        //}

    }
}
