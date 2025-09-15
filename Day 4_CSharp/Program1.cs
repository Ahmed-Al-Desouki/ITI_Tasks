using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_CSharp
{
    public class Program1
    {
        public class Course
        {
            public string Name { get; set; }

            public Course(string name, CourseLevel beginner)
            {
                Name = name;
            }
        }

        // ------------------ Employee ------------------
        public class Employee : Person
        {
            public string Name { get; set; }
            public List<Course> Courses { get; set; } = new List<Course>();

            public Employee(string name , int age) : base(name, age)
            {
            }

            public void RegisterCourse(Course course)
            {
                Courses.Add(course);
            }

            public override void Introduce()
            {
                throw new NotImplementedException();
            }
        }

        // ------------------ Department ------------------
        public class Department
        {
            public string Name { get; set; }
            public List<Employee> Employees { get; set; } = new List<Employee>();

            public Department(string name)
            {
                Name = name;
            }

            public void AddEmployee(Employee employee)
            {
                Employees.Add(employee);
            }
        }

        // ------------------ Company ------------------
        public class Company
        {
            public string Name { get; set; }
            public List<Department> Departments { get; set; } = new List<Department>();

            public Company(string name)
            {
                Name = name;
            }

            public void AddDepartment(Department department)
            {
                Departments.Add(department);
            }
        }

        // ------------------ Engine ------------------
        public class Engine
        {
            public string Model { get; set; }

            public Engine(string model)
            {
                Model = model;
            }
        }

        // ------------------ Car ------------------
        public class Car
        {
            public string Brand { get; set; }
            private Engine Engine { get; set; } 

            public Car(string brand, string engineModel)
            {
                Brand = brand;
                Engine = new Engine(engineModel);
            }

            public void ShowDetails()
            {
                Console.WriteLine($"Car: {Brand}, Engine: {Engine.Model}");
            }
        }
        //static void Main(string[] args)
        //{
        //    Company company = new Company("Tech Corp");
        //    Department dept = new Department("IT");
        //    Employee emp1 = new Employee("Ahmed");
        //    Employee emp2 = new Employee("Sara");

        //    dept.AddEmployee(emp1);
        //    dept.AddEmployee(emp2);
        //    company.AddDepartment(dept);

        //    Course c1 = new Course("C#");
        //    Course c2 = new Course("SQL");

        //    emp1.RegisterCourse(c1);
        //    emp1.RegisterCourse(c2);
        //    emp2.RegisterCourse(c1);

        //    Console.WriteLine("\nEmployees Info:");
        //    foreach (var d in company.Departments)
        //    {
        //        foreach (var e in d.Employees)
        //        {
        //            Console.Write($"Employee: {e.Name} | Department: {d.Name} ");

        //            Console.Write("| Courses: ");
        //            foreach (var course in e.Courses)
        //            {
        //                Console.Write(course.Name + ", ");
        //            }
        //            Console.WriteLine();

        //        }
        //    }

        //}
    }
}
