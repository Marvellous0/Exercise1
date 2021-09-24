using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[,] arr = 
            {
                {10, 2, 9}, 
                {4, 8, 6}, 
                {12, 8, 9}
            };

            int sum1 = 0,
            sum2 = 0;
            
            for (int i = 0; i < n; i++)
            {
                sum1 += arr[i, i];
                
                sum2 += arr[i, n-i-1];
                
            }
            Console.WriteLine(Math.Abs(sum1));
            Console.WriteLine(Math.Abs(sum2));
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}