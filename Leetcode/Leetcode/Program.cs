using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] brr_temp = ReadLine().Split(' ');
            int[] brr = Array.ConvertAll(brr_temp, Int32.Parse);
            int[] result = MissingNumbers.missingNumbers(arr, brr);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }

        private static string ReadLine()
        {
            Stream inputStream = Console.OpenStandardInput(1000);
            byte[] bytes = new byte[1000];
            int outputLength = inputStream.Read(bytes, 0, 1000);
            //Console.WriteLine(outputLength);
            char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
            return new string(chars);
        }

    }
}
