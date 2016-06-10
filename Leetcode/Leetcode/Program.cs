using System;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            int[] nums = {2,1};
            
            MoveZeroes mz = new MoveZeroes();

            mz.Move(nums);

            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        
    }
}
