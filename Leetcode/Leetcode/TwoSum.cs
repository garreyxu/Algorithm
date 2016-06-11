using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> num = new Dictionary<int, int>();
            int[] rst = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                num.Add(i, nums[i]);
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (num.ContainsValue(target - num[i]))
                {
                    rst[0] = i;
                    rst[1] = num.FirstOrDefault(x => x.Value.Equals(target - num[i])).Key;
                    return rst;
                }
            }
            return null;
        }
    }
}
