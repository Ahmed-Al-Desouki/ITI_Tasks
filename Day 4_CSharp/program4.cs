using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day_4_CSharp.Program1;
//using static Day_4_CSharp.Program1;
//using static Day_4_CSharp.Program2;
//using static Day_4_CSharp.program3;

namespace Day_4_CSharp
{
    // ------------------ Static Id Generator ------------------
    public static class IdGenerator
    {
        private static int _counter = 0;

        public static int GenerateId()
        {
            _counter++;
            return _counter;
        }
    }

    // ------------------ Grade ------------------
    public class Grade
    {
        public int Value { get; set; }

        public Grade(int value)
        {
            Value = value;
        }

        public static Grade operator +(Grade g1, Grade g2)
        {
            return new Grade(g1.Value + g2.Value);
        }

        public static bool operator ==(Grade g1, Grade g2)
        {
            if (g1 == null && g2 == null) return true;
            if (g1 == null || g2 == null) return false;
            return g1.Value == g2.Value;
        }

        public static bool operator !=(Grade g1, Grade g2)
        {
            return !(g1 == g2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Grade g)
                return this.Value == g.Value;
            return false;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

    // ------------------ Enum ------------------
    public enum CourseLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }

    internal class program4
    {
        //public static void Main(string[] args) 
        //{
        //    Instractor instructor = new Instractor("Dr. Ali", 45);

        //    Student s1 = new Student("Ahmed", 20);
        //    Student s2 = new Student("Sara", 21);

        //    course c3 = new course("C# Programming", CourseLevel.Beginner);
        //    course c4 = new course("Algorithms", CourseLevel.Advanced);

        //    instructor.TeachCourse(c3);
        //    instructor.TeachCourse(c4);

        //    s1.RegisterCourse(c3);
        //    s1.RegisterCourse(c3);
        //    s2.RegisterCourse(c4);

        //    Grade g1 = new Grade(80);
        //    Grade g2 = new Grade(90);
        //    Grade g3 = new Grade(90);

        //    Grade total = g1 + g2;
        //    Console.WriteLine($"\nTotal grade = {total.Value}");

        //    Console.WriteLine($"g2 == g3 ? {g2 == g3}");
        //    Console.WriteLine($"g1 != g2 ? {g1 != g2}");
        //}
    }

}
