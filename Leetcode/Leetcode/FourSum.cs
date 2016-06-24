using System;
using System.Collections.Generic;

namespace Leetcode
{
    class FourSum
    {
        public IList<IList<int>> GetFourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            HashSet<IList<int>> hashSet = new HashSet<IList<int>>();

            int sum = 0;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = i+1; j < nums.Length -2; j++)
                {
                    int low = j + 1;
                    int height = nums.Length - 1;

                    while (low < height)
                    {
                        sum = nums[i] + nums[j] + nums[low] + nums[height];

                        if (sum < target)
                        {
                            low ++;
                        }
                        else if (sum > target)
                        {
                            height --;
                        }
                        else
                        {
                            IList<int> temp = new List<int>();

                            temp.Add(nums[i]);
                            temp.Add(nums[j]);
                            temp.Add(nums[low]);
                            temp.Add(nums[height]);

                            if (!hashSet.Contains(temp))
                            {
                                hashSet.Add(temp);
                                result.Add(temp);
                            }

                            low ++;
                            height --;
                        }
                    }
                }
            }
            return result;
        }
    }
}
