using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class CountPrimeSetBits
    {
        public CountPrimeSetBits() { }

        public static int GetAnswer(int L, int R)
        {
            int count = 0;
            for (int i = L; i <= R; i++) {
                if (IsPrime(CountSetBitsOfInt(i))) {
                    count++;
                }
            }
            return count;
        }

        public static bool IsPrime(int x) {
            int[] a = { 2, 3, 5, 7, 11, 13, 17, 19 };
            return (a.Contains(x));
        }

        public static int CountSetBitsOfInt(int x) {
            string binary = Convert.ToString(x,2);
            int count = 0;

            foreach (char ch in binary) {
                if (ch == '1') {
                    count++;
                }
            }
            return count;
        }
    }
}
