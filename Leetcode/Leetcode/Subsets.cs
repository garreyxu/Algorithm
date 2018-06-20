using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Subsets
    {
        public static IList<IList<int>> GetSubsets(int[] nums)
        {
            
            IList<IList<int>> results = new List<IList<int>>();

            if (nums == null)
            {
                return results;
            }
            if (nums.Length == 0)
            {
                results.Add(new List<int>());
                return results;
            }

            IList<int> subset = new List<int>();

            Array.Sort(nums);

            Helper(results, subset, nums, 0);

            return results;

        }

        //1. Get all subsets start from "subset", add to "results" (definition)
        private static void Helper(IList<IList<int>> results,
                            IList<int> subset,
                            int[] nums,
                            int startIndex)
        {
            //deep copy; due to List<Int> saves data's address but value;
            results.Add(new List<int>(subset));

            //2. dismantling recursion
            //subset = []
            for (int i = startIndex; i < nums.Length; i++)
            {
                //[] -> 1
                subset.Add(nums[i]);
                //look for all subset start from 1, then add to "results"
                Helper(results, subset, nums, i + 1);
                //3. back tracking
                //List<>'s index start from 1;
                subset.Remove(subset.Count);
            }
            
            //return;
        }
    }
}
