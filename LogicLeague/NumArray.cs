

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-query-immutable/
    /// </summary>
    internal class NumArray
    {
        List<int> _prefixSum = [];
        List<int> input = [];
        public NumArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                input.Add(nums[i]);
                _prefixSum.Add(_prefixSum.LastOrDefault() + nums[i]);
            }
        }

        public int SumRange(int left, int right)
        {
            return _prefixSum[right] - _prefixSum[left] + input[left];
        }
    }

    public class NumArrayV2
    {
        private int[] _prefixSum;
        public NumArrayV2(int[] nums)
        {
            _prefixSum = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                _prefixSum[i + 1] = _prefixSum[i] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            return _prefixSum[right + 1] - _prefixSum[left];
        }
    }
}
