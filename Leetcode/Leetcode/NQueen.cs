namespace Leetcode
{
    class NQueen
    {
        public void GetNQueen(int n, string[,] board)
        {
            
            Initial(board, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (IfCanPlaceQueen(i, j, board, n))
                    {
                        board[i, j] = "Q";
                    }
                }
            }
        }

        public void Initial(string[,] board, int n)
        {
            for (int i=0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i,j] = ".";
                }
            }
        }

        public bool IfCanPlaceQueen(int row, int col, string[,] board, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (board[row, i] == "Q")
                    return false;
            }
            for (int i = 0; i < n; i++)
            {
                if (board[i, col] == "Q")
                    return false;
            }
            for(int k = 1 ; k < n ; k++)
            {
                if (row - k >= 0 && col - k >= 0 && board[row - k, col - k] == "Q")
                {
                    return false;
                }
                if (row - k >= 0 && col + k < n && board[row - k, col + k] == "Q")
                {
                    return false;
                }
                if (row + k < n && col + k < n && board[row + k, col + k] == "Q")
                {
                    return false;
                }
                if (row + k < n && col - k >= 0 && board[row + k, col - k] == "Q")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
