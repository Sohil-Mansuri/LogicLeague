namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/valid-sudoku/
    /// </summary>
    internal class ValidSudokoProblem
    {
        public static bool IsValidSudoku(string[][] board)
        {
            int size = 9;

            HashSet<string>[] rows = new HashSet<string>[size];
            HashSet<string>[] columns = new HashSet<string>[size];
            HashSet<string>[] boxes = new HashSet<string>[size];

            for (int i = 0; i < size; i++)
            {
                rows[i] = [];
                columns[i] = [];
                boxes[i] = [];
            }

            for (int row = 0; row < board.Length; row++)
            {
                for (int column = 0; column < board.Length; column++)
                {
                    if (board[row][column] == ".") continue;

                    if (rows[row].Contains(board[row][column])) return false;

                    rows[row].Add(board[row][column]);

                    if (columns[column].Contains(board[row][column])) return false;

                    columns[column].Add(board[row][column]);

                    int boxIndex = (row / 3) * 3 + (column / 3);

                    if (boxes[boxIndex].Contains(board[row][column])) return false;

                    boxes[boxIndex].Add(board[row][column]);
                }
            }

            return true;
        }
    }
}
