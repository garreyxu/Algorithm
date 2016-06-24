using System;
using System.Collections.Generic;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            FourSum sf = new FourSum();

            int[] nums = {-3,-2,-1,0,0,1,2,3};
            int target = 0;

            var result = sf.GetFourSum(nums, target);

            foreach (IList<int> list in result)
            {
                foreach (var item in list)
                {
                    Console.Write(item+", ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
        
    }
}
