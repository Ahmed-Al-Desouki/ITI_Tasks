using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_LINQ
{
    public class Subject
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public Subject(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public Subject()
        {
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] Subjects { get; set; }

        public Student(int id, string firstName, string lastName, Subject[] subjects)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Subjects = subjects;
        }

        public Student()
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var sorted = numbers.Distinct().OrderBy(s => s).ToList();

            foreach (var num in sorted)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("*******************************");

            foreach (var num in sorted)
            {
                Console.WriteLine($"(Number = {num}, it's multiplication = {num * num})");
            }
            Console.WriteLine("*******************************");

            //********************* q2 *******************

            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            var name = names.Where(s => s.Length == 3);

            foreach(var N in name)
            {
                Console.WriteLine(N);
            }
            Console.WriteLine("*******************************");

            var q2 = names
                 .Where(n => n.ToLower().Contains("a"))
                 .OrderBy(n => n.Length);

            foreach (var n in q2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("*******************************");

            var q3 = names.Take(2);

            foreach (var s in q3)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("*******************************");

            // ********************** q3 *********************
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Mohammed",
                    Subjects = new Subject[]
                    {
                        new Subject(){ Code = "22", Name = "EF" },
                        new Subject(){ Code = "33", Name = "UML" }
                    }
                },
                new Student()
                {
                    ID = 2,
                    FirstName = "Mona",
                    LastName = "Gala",
                    Subjects = new Subject[]
                    {
                        new Subject(){ Code = "22", Name = "EF" },
                        new Subject(){ Code = "34", Name = "XML" },
                        new Subject(){ Code = "25", Name = "JS" }
                    }
                },
                new Student()
                {
                    ID = 3,
                    FirstName = "Yara",
                    LastName = "Yousf",
                    Subjects = new Subject[]
                    {
                        new Subject(){ Code = "22", Name = "EF" },
                        new Subject(){ Code = "25", Name = "JS" }
                    }
                },
                new Student()
                {
                    ID = 4,  
                    FirstName = "Ali",
                    LastName = "Ali",
                    Subjects = new Subject[]
                    {
                        new Subject(){ Code = "33", Name = "UML" }
                    }
                }
            };
            var query1 = students.Select(s => new
                                 {
                                    FullName = s.FirstName + " " + s.LastName,
                                    SubjectCount = s.Subjects.Length
                                });
            foreach (var student in query1)
            {
                Console.WriteLine($"(FullName: {student.FullName}, Number of Subjects: {student.SubjectCount})");
            }

            Console.WriteLine("*******************************");
            var query2 = students
                .OrderByDescending(s => s.FirstName)  
                .ThenBy(s => s.LastName)              
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName
                });

            foreach (var student in query2)
            {
                Console.WriteLine( $"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("*******************************");

            var query3 = students
                .SelectMany(
                    s => s.Subjects,          
                    (student, subject) => new  
                    {
                        StudentName = student.FirstName + " " + student.LastName,
                        SubjectName = subject.Name,
                        SubjectCode = subject.Code
                    }
                );


            foreach (var item in query3)
            {
                Console.WriteLine($"(Student: {item.StudentName}, Subject: {item.SubjectCode} - {item.SubjectName})");
            }

            Console.WriteLine("*******************************");

            var query4 = students
                .GroupBy(s => s.FirstName + " " + s.LastName)  
                .Select(g => new
                {
                    StudentName = g.Key,
                    Subjects = g.SelectMany(s => s.Subjects)   
                });


            foreach (var studentGroup in query4)
            {
                Console.WriteLine($"Student: {studentGroup.StudentName}");
                foreach (var subject in studentGroup.Subjects)
                {
                    Console.WriteLine($" Subject: {subject.Code} - {subject.Name}");
                }
                Console.WriteLine();
            }



        }
    }
}
