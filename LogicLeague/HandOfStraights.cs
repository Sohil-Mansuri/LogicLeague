namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/hand-of-straights/
    /// </summary>
    internal class HandOfStraights
    {
        public static bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0) return false;

            SortedDictionary<int, int> treeMap = [];

            foreach (int card in hand)
            {
                treeMap[card] = treeMap.GetValueOrDefault(card) + 1;
            }

            while (treeMap.Count > 0)
            {
                int first = treeMap.First().Key;
                for (int i = 0; i < groupSize; i++)
                {
                    var current = first + i;

                    if (treeMap.ContainsKey(current))
                    {
                        treeMap[current]--;
                        if (treeMap[current] == 0) treeMap.Remove(current);
                    }
                    else 
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// https://leetcode.com/problems/divide-array-in-sets-of-k-consecutive-numbers/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool IsPossibleDivide(int[] nums, int k)
        {
            SortedDictionary<int, int> treeMap = [];

            foreach (int num in nums)
            {
                treeMap[num] = treeMap.GetValueOrDefault(num) + 1;
            }


            while(treeMap.Count > 0)
            {
                int first = treeMap.First().Key;

                for (int i = 0; i < k; i++)
                {
                    var current = first + i;

                    if (treeMap.ContainsKey(current))
                    {
                        treeMap[current]--;
                        if (treeMap[current] == 0) treeMap.Remove(current);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
