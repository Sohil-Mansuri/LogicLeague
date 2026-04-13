

namespace LogicLeague.Graph
{
    //https://leetcode.ca/2016-09-02-277-Find-the-Celebrity/
    internal class FindCelebratiy
    {
        private static int[][] graph = [[1, 0, 1, 0, 1, 0],
                                 [0, 1, 0, 0, 1, 0],
                                 [0, 1, 1, 1, 1, 0],
                                 [1, 0, 1, 1, 1, 0],
                                 [0, 0, 0, 0, 1, 0],
                                 [0, 0, 0, 1, 1, 0]];

        public static int FindCelebrity(int n)
        {
            int cele = 0;

            for (int i = 0; i < n; i++)
            {
                if (Knows(cele, i))
                    cele = i;
            }


            for (int i = 0; i < n; i++)
            {
                if (cele == i) continue;

                if (Knows(cele, i) || !Knows(i, cele))
                    return -1;
            }

            return cele;
        }

        public static bool Knows(int a, int b)
        {
            return graph[a][b] == 1;
        }
    }
}
