using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            int[] nums = {0,1,3};
            

            MissingNumber mn = new MissingNumber(nums);

            var result = mn.GetMissingNumber();

            Console.WriteLine("Missing Number is: " + result);

            Console.ReadLine();

        }
        
    }
}
