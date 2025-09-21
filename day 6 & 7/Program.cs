using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6___7
{
    public class Program
    {
        //*********************** Q1 *******************
        static void BubbleSortOptimized(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
        //*********************** Q2 *******************
        public class Range<T> where T : IComparable<T>
        {
            public T Min { get; private set; }
            public T Max { get; private set; }

            // Constructor
            public Range(T min, T max)
            {
                if (min.CompareTo(max) > 0)
                    throw new ArgumentException("Minimum value cannot be greater than maximum value.");

                Min = min;
                Max = max;
            }
            public bool IsInRange(T value)
            {
                return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
            }

            // Calculate the length of the range (only works with numeric types)
            public dynamic Length()
            {
                return (dynamic)Max - (dynamic)Min;
            }
        }
        //*********************** Q3 *******************
        static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {

                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
        //************************ q4 ********************
        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }

            return evenNumbers;
        }
        //************************ q5 ********************
        public class FixedSizeList<T>
        {
            private List<T> items;   
            private int capacity;    

            // Constructor
            public FixedSizeList(int capacity)
            {
                if (capacity <= 0)
                    throw new ArgumentException("Capacity must be greater than 0.");

                this.capacity = capacity;
                items = new List<T>();
            }

            // Add method
            public void Add(T item)
            {
                if (items.Count >= capacity)
                {
                    throw new InvalidOperationException("Cannot add more items: list is full.");
                }
                items.Add(item);
            }

            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
                return items[index];
            }

            public int Count => items.Count;

            public int Capacity => capacity;


        }
        //************************ q6 ********************
        static int FirstNonRepeatedCharIndex(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count occurrences of each character
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Find the first character with count 1
            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                    return i;
            }

            return -1; // No non-repeated character
        }


        //************************ MAIN *********************************

        static void Main(string[] args)
        {
            int[] data = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Unsorted: " + string.Join(", ", data));

            BubbleSortOptimized(data);

            Console.WriteLine("Sorted:   " + string.Join(", ", data));

            Console.WriteLine("******************************");

            //************************ q2 ********************
            Range<int> intRange = new Range<int>(10, 20);
            Console.WriteLine("Is 15 in range? " + intRange.IsInRange(15)); 
            Console.WriteLine("Is 25 in range? " + intRange.IsInRange(25)); 
            Console.WriteLine("Length of int range: " + intRange.Length()); 

            Range<double> doubleRange = new Range<double>(5.5, 10.2);
            Console.WriteLine("Is 7.8 in range? " + doubleRange.IsInRange(7.8)); 
            Console.WriteLine("Length of double range: " + doubleRange.Length());

            Console.WriteLine("******************************");

            //************************ q3 ********************
            ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original: " + string.Join(", ", numbers.ToArray()));

            ReverseArrayList(numbers);

            Console.WriteLine("Reversed: " + string.Join(", ", numbers.ToArray()));

            Console.WriteLine("******************************");

            //************************ q4 ********************

            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            List<int> evens = GetEvenNumbers(numbers1);

            Console.WriteLine("Even numbers: " + string.Join(", ", evens));

            Console.WriteLine("******************************");


            //************************ q5 ********************
            FixedSizeList<int> list = new FixedSizeList<int>(3);

            try
            {
                list.Add(10);
                list.Add(20);
                list.Add(30);

                Console.WriteLine("Item at index 1: " + list.Get(1)); // 20

                list.Add(40); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            { 
                Console.WriteLine(list.Get(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("******************************");

            //************************ q6 ********************

            string input = "swiss";
            int index = FirstNonRepeatedCharIndex(input);

            if (index != -1)
                Console.WriteLine($"First non-repeated character: '{input[index]}' at index {index}");
            else
                Console.WriteLine("No non-repeated character found.");


        }
    }
}
