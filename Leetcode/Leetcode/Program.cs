using System;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            
            TwoSum ts = new TwoSum();
            
            foreach (int item in ts.GetTwoSum(nums, target))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        
    }
}
