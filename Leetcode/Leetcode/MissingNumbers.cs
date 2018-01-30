using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class MissingNumbers
    {
        public MissingNumbers(){}

        public static int[] missingNumbers(int[] arr, int[] brr)
        {
            // Complete this function
            int[] temp = new int[10001];
            ArrayList result = new ArrayList();

            if (arr.Length == brr.Length)
                return result.ToArray(typeof(int)) as int[];

            for (int i = 0; i <= 10000; i++)
                temp[i] = 0;

            foreach (var number in arr)
            {
                temp[number]--;
            }

            foreach (var number in brr)
            {
                temp[number]++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > 0)
                {
                    while (temp[i] > 0)
                    {

                        result.Add(i);
                        temp[i]--;
                    }
                }
            }

            return result.ToArray(typeof(int)) as int[];
        }
    }
}
