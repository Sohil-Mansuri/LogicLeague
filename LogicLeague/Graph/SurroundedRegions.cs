namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/surrounded-regions/
    /// </summary>
    internal class SurroundedRegions
    {
        public static string[][] Solve(string[][] board)
        {
            //corners
            int[] rows = [0, board.Length - 1];
            int[] columns = [0, board[0].Length - 1];

            for (int i = 0; i < rows.Length; i++)
            {
                int currentRow = rows[i];
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[currentRow][j] == "O")
                    {
                        BackTrack(currentRow, j, board);
                    }
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < columns.Length; j++)
                {
                    if (board[i][columns[j]] == "O")
                    {
                        BackTrack(i, columns[j], board);
                    }
                }
            }


            //now just replace 
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == "O") board[i][j] = "X";
                    else if (board[i][j] == "S") board[i][j] = "O";
                }
            }

            return board;
        }


        private static void BackTrack(int row, int column, string[][] board)
        {
            int[] rowDirection = [0, 1, 0, -1];
            int[] columnDirection = [1, 0, -1, 0];

            board[row][column] = "S";

            for (int k = 0; k < rowDirection.Length; k++)
            {
                int newRow = row + rowDirection[k];
                int newColumn = column + columnDirection[k];

                if (newRow < 0 || newColumn < 0 || newRow >= board.Length || newColumn >= board[0].Length)
                    continue;

                if (board[newRow][newColumn] == "O")
                    BackTrack(newRow, newColumn, board);
            }
        }


        public static string[][] SolveV2(string[][] board)
        {

            for (int i = 0; i < board.Length; i++)
            {
                DFS(board, i, 0);
                DFS(board, i, board[0].Length - 1);
            }

            for (int j = 0; j < board[0].Length; j++)
            {
                DFS(board, 0, j);
                DFS(board, board.Length - 1, j);
            }


            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == "S") board[i][j] = "O";
                    else if (board[i][j] == "O") board[i][j] = "X";
                }
            }

            return board;
        }

        private static void DFS(string[][] board, int row, int column)
        {
            if (row < 0 || column < 0 || row >= board.Length || column >= board[0].Length || board[row][column] != "O")
                return;

            board[row][column] = "S";

            DFS(board, row, column + 1);
            DFS(board, row, column - 1);
            DFS(board, row + 1, column);
            DFS(board, row - 1, column);
        }
    }
}
