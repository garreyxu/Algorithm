using System;

namespace Leetcode
{
    class MinSubArrayLen
    {
        public int GetMinSubArrayLen(int s, int[] nums)
        {
            if (nums == null)
                return 0;
            if (nums.Length == 0)
                return 0;
            if (nums[0] >= s)
                return 1;

            int start = 0;
            int i = 1;
            int result = nums.Length;
            int sum = nums[start];
            var exist = false;

            while (i <= nums.Length)
            {
                if (sum >= s)
                {
                    exist = true;
                    result = Math.Min(result, i - start);
                    sum = sum - nums[start];
                    start++;
                    if (start == nums.Length - 1)
                        break;
                }
                else
                {
                    if (i == nums.Length)
                        break;
                    sum = sum + nums[i];
                    i++;
                }
            }

            if (exist)
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
