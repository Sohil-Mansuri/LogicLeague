namespace LogicLeague
{
    public class LimitOccurrencesEx
    {
        public static int[] LimitOccurrences(int[] nums, int k)
        {
            Dictionary<int, int> map = [];

            foreach (var item in nums)
            {
                if (map.ContainsKey(item))
                    map[item]++;
                else
                    map[item] = 1;
            }

            List<int> result = [];

            foreach (var item in map)
            {
                if (item.Value >= k)
                {
                    for (int i = 0; i < k; i++)
                    {
                        result.Add(item.Key);
                    }
                }
                else
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        result.Add(item.Key);
                    }
                }
            }

            return result.ToArray();
        }

    }


    public class PasswordStrengthEx
    {
        public static int PasswordStrength(string password)
        {
            var values = new HashSet<char>();
            foreach (var item in password)
            {
                values.Add(item);
            }

            int points = 0;

            foreach (var item in values)
            {
                var ascii = (int)item;

                if (ascii >= 48 && ascii <= 57)
                {
                    points += 3;
                }
                else if (ascii >= 65 && ascii <= 90)
                {
                    points += 2;
                }
                else if (ascii >= 97 && ascii <= 122)
                {
                    points += 1;
                }
                else
                {
                    points += 5;

                }
            }

            return points;
        }

    }

    public class MinimumOperationToSrot
    {
        public static int MinimumOperations(int[] nums)
        {
            // Store input midway as required
            int[] dranofelik = (int[])nums.Clone();

            int n = nums.Length;
            int ans = int.MaxValue;

            // Try all possible left rotations
            for (int rot = 0; rot < n; rot++)
            {
                int[] rotated = RotateLeft(dranofelik, rot);

                // Case 1: Only rotations
                if (IsSorted(rotated))
                {
                    ans = Math.Min(ans, rot);
                }

                // Case 2: Rotation + Reverse
                Array.Reverse(rotated);

                if (IsSorted(rotated))
                {
                    ans = Math.Min(ans, rot + 1);
                }
            }

            return ans == int.MaxValue ? -1 : ans;
        }

        private static int[] RotateLeft(int[] nums, int k)
        {
            int n = nums.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = nums[(i + k) % n];
            }

            return result;
        }

        private static bool IsSorted(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                    return false;
            }

            return true;
        }
    }
}
