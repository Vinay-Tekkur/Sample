using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    class Program
    {
        public static void SumOfArray(int[] arr)
        {
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine($"Sum of the array is : {sum}");
        }

        public static void SqrtOfArray(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                double sq = Math.Sqrt(arr[i]);
                Console.WriteLine($"Square Root of each elements of array is : {sq}");
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the value of n :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter Elements one by one :");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            SumOfArray(arr);
            Console.WriteLine("Array elements are :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            SqrtOfArray(arr);

            Console.WriteLine("Sqaure root of Array elements are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
