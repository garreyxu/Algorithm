using System.Collections.Generic;

namespace Leetcode
{
    class TwoSum
    {
        public int[] getTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> num = new Dictionary<int, int>();
            int[] rst = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                num.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (num.ContainsKey(target - nums[i]))
                {
                    rst[0] = nums[i];
                    rst[1] = num[target - nums[i]];
                }
            }
            return nums;
        }
    }
}
