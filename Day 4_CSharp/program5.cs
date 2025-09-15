using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day_4_CSharp.Program1;

namespace Day_4_CSharp
{
    internal class program5
    {
        static void Main(string[] args)
        {
            Company company = new Company("TechCorp");

            Department d1 = new Department("IT");
            Department d2 = new Department("HR");

            company.Departments.Add(d1);
            company.Departments.Add(d2);

            Instractor ins1 = new Instractor("Dr.Ahmed",22);
            Instractor ins2 = new Instractor("Sara", 40);

            d1.Employees.Add(ins1);
            d2.Employees.Add(ins2);

            Student s1 = new Student("Ahmed", 20);
            Student s2 = new Student("Mona", 22);

            course c1 = new course("C# Basics", CourseLevel.Beginner);
            course c2 = new course("Advanced SQL", CourseLevel.Advanced);

            ins1.TeachCourse(c1);
            ins2.TeachCourse(c2);

            s1.RegisterCourse(c1);
            s1.RegisterCourse(c2);
            s2.RegisterCourse(c1);

            Grade g1 = new Grade(80);
            Grade g2 = new Grade(90);
            Grade g3 = new Grade(70);

            s1.Grades.Add(g1);
            s1.Grades.Add(g2);
            s2.Grades.Add(g3);

            Console.WriteLine("===== Report =====\n");

            Console.WriteLine("Students:");
            foreach (var student in new List<Student> { s1, s2 })
            {
                Grade total = new Grade(0);
                foreach (var g in student.Grades)
                    total += g;

                Console.WriteLine($"- {student.Name} (ID: {student.Id})");
                Console.WriteLine("  Courses:");
                foreach (var course in student.courses)
                    Console.WriteLine($"    {course.Name} ({course.Level})");
                Console.WriteLine($"  Total Grades = {total.Value}\n");
            }

            Console.WriteLine("Instractors:");
            foreach (var ins in new List<Instractor> { ins1, ins2 })
            {
                Console.WriteLine($"- {ins.Name} (ID: {ins.Id})");
                Console.WriteLine("  Teaches:");
                foreach (var course in ins.courses)
                    Console.WriteLine($"    {course.Name}");
                Console.WriteLine();
            }

            Console.WriteLine("Departments:");
            foreach (var dep in company.Departments)
            {
                Console.WriteLine($"- {dep.Name}: {dep.Employees.Count} employees");
            }
        }
    }
}
