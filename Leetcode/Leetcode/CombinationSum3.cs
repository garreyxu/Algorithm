using System.Collections.Generic;

namespace Leetcode
{
    class CombinationSum3
    {
        public IList<IList<int>> GetCombinationSum3(int k, int n)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> list = new List<int>();
            Dfs(k, n, result, 1, list);
            return result;
        }

        public void Dfs(int k, int n, IList<IList<int>> result, int start, IList<int> list)
        {
            if (n == 0 && list.Count == k) //match the requirement;
            {
                IList<int> temp = new List<int>();
                foreach (var item in list)
                {
                    temp.Add(item);
                }
                result.Add(temp);
            }

            for (int i = start; i <= 9; i++)
            {
                if (n < 0)
                    break;
                if (list.Count > k)
                    break;

                list.Add(i);
                Dfs(k, n-i, result, i + 1, list);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
