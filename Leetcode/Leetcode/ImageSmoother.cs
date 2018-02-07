using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ImageSmoother
    {
        public ImageSmoother() { }

        public static void GetAnswer(int[,] M, int[,] ans)
        {
            SelectAndExecuteCalculation(M, ans);
        }

        public static void SelectAndExecuteCalculation(int[,] M, int[,] ans)
        {
            int rowLen = M.GetLength(0);
            int colLen = M.GetLength(1);

            if (rowLen < 2 && colLen < 2)
            {
                //do nothing;
            }
            else if (rowLen == 2 && colLen == 2)
            {
                WriteCornerValue(M, ans);
            }
            else if (rowLen < 2 && colLen >= 2)
            {
                WriteAnsIfInputIsOneCol(M, ans);
            }
            else if (rowLen >= 2 && colLen < 2)
            {
                WriteAnsIfInputIsOneRow(M, ans);
            }
            else
            {
                WriteCornerValue(M, ans);
                WriteSideValue(M, ans);
                WriteMiddleValue(M, ans);
            }
        }

        public static void WriteCornerValue(int[,] M, int[,] ans)
        {

            int rowLen = M.GetLength(1) - 1;
            int colLen = M.GetLength(0) - 1;

            ans[0, 0] = (M[0, 0] + M[0, 1] + M[1, 0] + M[1, 1]) / 4;
            ans[0, rowLen] = (M[0, rowLen] + M[0, rowLen - 1] + M[1, rowLen - 1] + M[1, rowLen]) / 4;
            ans[colLen, 0] = (M[colLen, 0] + M[colLen - 1, 0] + M[colLen - 1, 1] + M[colLen, 1]) / 4;
            ans[colLen, rowLen] = (M[colLen, rowLen] + M[colLen, rowLen - 1] + M[colLen - 1, rowLen] + M[colLen - 1, rowLen - 1]) / 4;

        }

        public static void WriteSideValue(int[,] M, int[,] ans)
        {

            int rowLen = M.GetLength(0);
            int colLen = M.GetLength(1);

            //Top
            for (int i = 1; i < colLen - 1; i++)
            {
                ans[0, i] = (M[0, i] + M[0, i - 1] + M[1, i - 1] + M[1, i] + M[1, i + 1] + M[0, i + 1]) / 6;
            }
            //Left
            for (int i = 1; i < rowLen - 1; i++)
            {
                ans[i, 0] = (M[i, 0] + M[i - 1, 0] + M[i - 1, 1] + M[i, 1] + M[i - 1, 1] + M[i + 1, 0]) / 6;
            }
            //Bottom
            for (int i = 1; i < colLen - 1; i++)
            {
                ans[rowLen - 1, i] = (M[rowLen - 1, i] + M[rowLen - 1, i - 1] + M[rowLen - 2, i - 1] + M[rowLen - 2, i] + M[rowLen - 2, i + 1] + M[rowLen - 1, i + 1]) / 6;
            }
            //Right
            for (int i = 1; i < rowLen - 1; i++)
            {
                ans[i, colLen - 1] = (M[i, colLen - 1] + M[i - 1, colLen - 1] + M[i - 1, colLen - 2] + M[i, colLen - 2] + M[i - 1, colLen - 2] + M[i + 1, colLen - 1]) / 6;
            }
        }

        public static void WriteMiddleValue(int[,] M, int[,] ans)
        {
            int rowLen = M.GetLength(0);
            int colLen = M.GetLength(1);

            for (int col = 1; col < colLen - 1; col++)
            {
                for (int row = 1; row < rowLen - 1; row++)
                {
                    ans[row, col] = (M[row, col] + M[row - 1, col - 1] + M[row - 1, col] + M[row - 1, col + 1] + M[row, col - 1] + M[row, col + 1] + M[row + 1, col - 1] + M[row + 1, col] + M[row + 1, col + 1]);
                }
            }
        }

        public static void WriteAnsIfInputIsOneRow(int[,] M, int[,] ans)
        {
            int colLen = M.GetLength(1);

            for (int i = 1; i < colLen - 1; i++)
            {
                ans[0, i] = (M[0, i] + M[0, i - 1] + M[0, i + 1]) / 3;
            }
            ans[0, 0] = (M[0, 0] + M[0, 1]) / 2;
            ans[0, colLen] = (M[0, colLen] + M[0, colLen - 1]) / 2;
        }

        public static void WriteAnsIfInputIsOneCol(int[,] M, int[,] ans)
        {
            int rowLen = M.GetLength(0);

            for (int i = 1; i < rowLen - 1; i++)
            {
                ans[i, 0] = (M[i, 0] + M[i - 1, 0] + M[i - 1, 1] + M[i, 1] + M[i - 1, 1] + M[i + 1, 0]) / 6;
            }
            ans[0, 0] = (M[0, 0] + M[1, 0]) / 2;
            ans[rowLen, 0] = (M[rowLen, 0] + M[rowLen - 1, 0]) / 2;

        }
    }
}
