

namespace LogicLeague
{
    internal class PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = [];

            result.Add([1]);

            for (int rowNumber = 1; rowNumber < numRows; rowNumber++)
            {
                IList<int> currentRow = [];
                var previous = result[rowNumber - 1];

                //first
                currentRow.Add(1);

                for (int j = 1; j < rowNumber; j++)
                {
                    currentRow.Add(previous[j] + previous[j - 1]);
                }

                //last
                currentRow.Add(1);
                result.Add(currentRow);
            }



            return result;
        }
    }
}
