using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 3 };
            IList<IList<int>> results = Subsets.GetSubsets(nums);
            foreach (var r in results)
            {
                Console.Write("[");
                foreach (var s in r)
                {
                    Console.Write(s.ToString());
                        Console.Write(",");
                }
                Console.Write("]");
            }
            Console.ReadKey();
        }

        private static string ReadLine()
        {
            Stream inputStream = Console.OpenStandardInput(1000);
            byte[] bytes = new byte[1000];
            int outputLength = inputStream.Read(bytes, 0, 1000);
            char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
            return new string(chars);
        }

        private static void OutputMatrix(int[,] arr)
        {

            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
