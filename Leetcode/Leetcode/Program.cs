using System;

namespace Leetcode
{
    class Program
    {
        public static void Main()
        {
            MinSubArrayLen msal = new MinSubArrayLen();

            int[] nums = {2, 3, 1, 2, 4, 3};
            int s = 7;

            var result = msal.GetMinSubArrayLen(s, nums);
            
            Console.WriteLine(result);
                
            Console.ReadLine();
        }
        
    }
}
