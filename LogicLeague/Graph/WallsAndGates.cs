namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/walls-and-gates
    /// </summary>
    internal class WallsAndGates
    {
        public static int[][] ComputeGateDistances(int[][] rooms)
        {
            int noOfRows = rooms.Length;
            int noOfCols = rooms[0].Length;
            Queue<(int row, int column)> queue = [];

            for (int i = 0; i < noOfRows; i++)
            {
                for (int j = 0; j < noOfCols; j++)
                {
                    if (rooms[i][j] == 0)
                    {
                        queue.Enqueue((i, j));
                    }
                }
            }

            int[] rowDirection = [0, 1, 0, -1];
            int[] colDirection = [1, 0, -1, 0];

            while (queue.Count > 0)
            {
                var gate = queue.Dequeue();

                for (int i = 0; i < rowDirection.Length; i++)
                {
                    var newRow = gate.row + rowDirection[i];
                    var newColumn = gate.column + colDirection[i];

                    if (newRow >= 0 && newColumn >= 0 && newRow < noOfRows && newColumn < noOfCols && rooms[newRow][newColumn] == 2147483647)
                    {
                        rooms[newRow][newColumn] = rooms[gate.row][gate.column] + 1;
                        queue.Enqueue((newRow, newColumn));
                    }
                }
            }

            return rooms;
        }
    }
}
