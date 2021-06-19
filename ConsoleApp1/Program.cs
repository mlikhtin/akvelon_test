//using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(1, 100);
            Console.WriteLine("Array to be sorted: ");
            foreach (var number in numbers)
                Console.Write(number + " ");
            Console.WriteLine();
 //           Sort.BubbleSort(numbers);
            Console.WriteLine("Array is sorted: ");
            foreach (var number in numbers)
                Console.Write(number + " ");
            Console.WriteLine();
        }
    }
}
