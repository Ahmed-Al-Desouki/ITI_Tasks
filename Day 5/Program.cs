
namespace Day_5
{

    struct Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;
        public void Print()
        {
            Console.WriteLine($"{Hours}H:{Minutes}M:{Seconds}S");
        }
    }
    class Task_1_2
    {
        static void Main(string[] args)
        {
            #region task_1

            #region q1
            //Console.Write("Enter a character: ");
            //char ch = Console.ReadKey().KeyChar;  
            //Console.WriteLine(); 

            //int asciiCode = (int)ch;
            //Console.WriteLine($"The ASCII code of '{ch}' is: {asciiCode}");
            #endregion

            #region q2
            //Console.Write("Enter an ASCII code: ");
            //int asci = int.Parse(Console.ReadLine());
            //char cha = (char)asci;
            //Console.WriteLine($"The character for ASCII code {asci} is: '{cha}'");
            #endregion

            #region q3
            //Console.Write("Enter a Number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} is even");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is odd");
            //}
            #endregion

            #region q4
            //Console.Write("Enter First Number: ");
            //int Fnum = int.Parse(Console.ReadLine());
            //Console.Write("Enter second Number: ");
            //int Snum = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The Sum of tow numbers equal: {Fnum + Snum}");
            //Console.WriteLine($"The subtraction, of tow numbers equal: {Fnum - Snum}");
            //Console.WriteLine($"The multiplication. of tow numbers equal: {Fnum * Snum}");
            #endregion

            #region q5
            //Console.Write("Enter student degree (0 - 100)%: ");
            //int degree = int.Parse(Console.ReadLine());
            //string grade;
            //if (degree >= 90 && degree <= 100)
            //    grade = "A";
            //else if (degree >= 80)
            //    grade = "B";
            //else if (degree >= 70)
            //    grade = "C";
            //else if (degree >= 60)
            //    grade = "D";
            //else
            //    grade = "F";
            //Console.WriteLine($"The grade for degree {degree} is: {grade}");
            #endregion

            #region q6
            //Console.Write("Enter a number to display its multiplication table: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"\nMultiplication Table of {num}:");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num} x {i} = {num * i}");
            //}
            #endregion

            #endregion
            //-----------------------------\\
            #region task_2

            #region q1
            //Console.Write("Enter number of students: ");
            //int n = int.Parse(Console.ReadLine());
            //string[] students = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter name of student {i + 1}: ");
            //    students[i] = Console.ReadLine();
            //}
            //Console.WriteLine("\nList of Students:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Student {i + 1}: {students[i]}");
            //}
            #endregion

            #region q2
            //Console.Write("Enter number of tracks: ");
            //int tracks = int.Parse(Console.ReadLine());
            //Console.Write("Enter number of students per track: ");
            //int students = int.Parse(Console.ReadLine());
            //int[,] ages = new int[tracks, students];
            //for (int t = 0; t < tracks; t++)
            //{
            //    Console.WriteLine($"\nTrack {t + 1}:");
            //    for (int s = 0; s < students; s++)
            //    {
            //        Console.Write($"Enter age of student {s + 1}: ");
            //        ages[t, s] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int t = 0; t < tracks; t++)
            //{
            //    Console.WriteLine($"\nTrack {t + 1} ages:");
            //    int sum = 0;
            //    for (int s = 0; s < students; s++)
            //    {
            //        Console.WriteLine($"Student {s + 1}: {ages[t, s]}");
            //        sum += ages[t, s];
            //    }
            //    double avg = (double)sum / students;
            //    Console.WriteLine($"Average age for Track {t + 1}: {avg}");
            //}
            #endregion

            #region q3
            Time t1;
            t1.Hours = 12;
            t1.Minutes = 37;
            t1.Seconds = 55;
            t1.Print();
            #endregion

            #endregion
        }
    }
}

         
        
   
