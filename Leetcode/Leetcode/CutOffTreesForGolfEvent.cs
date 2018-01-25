using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CutOffTreesForGolfEvent
    {
        public CutOffTreesForGolfEvent() { }

        public int CutOffTree(IList<IList<int>> forest)
        {
            int result = -1;

            if (!CutAllTree(forest))
                result = -1;

            return result;
        }

        public bool CutAllTree(IList<IList<int>> forest)
        {
            foreach (var row in forest)
            {
                foreach (var column in row)
                {
                    if (column > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
