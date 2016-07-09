using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            NQueen nq = new NQueen();
            int n = 20;

            string[,] result = new string[n,n];

            nq.GetNQueen(n, result);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i,j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();

        }
        
    }
}
