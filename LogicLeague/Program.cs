namespace LogicLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var profit = BuySellStock.MaxProfit([7, 1, 5, 3, 6, 4]);

            var contains = FindDuplicate.ContainsDuplicate([1, 2, 3, 1]);

            var contains2 = FindDuplicate.ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3], 2);
            var contains3 = FindDuplicate.ContainsNearbyDuplicateV2([1, 0, 1, 1], 1);
            var contains4 = FindDuplicate.ContainsNearbyDuplicateV2([99, 99], 1);


            var productArray = ProductOfArrary.ProductExceptSelf([1, 2, 3, 4]);
            var productArray2 = ProductOfArrary.ProductExceptSelfV2([2, 3, 5, 7]);
            var productArray3 = ProductOfArrary.ProductExceptSelfV2([-1, 1, 0, -3, 3]);


            var maxSum = MaximumSubArray.MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
            var maxSum2 = MaximumSubArray.MaxSubArray([-2, -1]);

            var fib = FibonacciProblem.Fib(10);
            var memo = new Dictionary<int, int>();
            var fib2 = FibonacciProblem.FibV2(10, memo);
            var fib3 = FibonacciProblem.FibV3(10);
            var fib4 = FibonacciProblem.FibV4(10);

            var maxProduct = MaximumProduct.MaxProduct([2, 3, -2, 4]);

            var minInRotatedArray = FindMinimumInRotatedArray.FindMin([2, 1]);

            var searchTarget = SearchInRotatedArray.Search([4, 5, 6, 7, 0, 1, 2], 3);
            var searchTarget2 = SearchInRotatedArray.Search([3, 1], 1);

            var twoSumPart2 = TwoSumPart2.TwoSum([-1, 0], -1);

            var longestSubsstring = LongestSubstring.LengthOfLongestSubstringV2("pwwkew");


            var threeSumResult = ThreeSumProblem.ThreeSum([-5, -5, 0, 1, 5]);
            var threeSumResult2 = ThreeSumProblem.ThreeSum([-1, 0, 1, 2, -1, -4]);
            var threeSumResult3 = ThreeSumProblem.ThreeSum([2, -3, 0, -2, -5, -5, -4, 1, 2, -2, 2, 0, 2, -4, 5, 5, -10]);
            var threeSum = ThreeSumProblem.ThreeSumV2([-1, 0, 1, 2, -1, -4]);

            var mergeSortedArray = MergeSortedArray.Merge([1, 2, 3,], [2, 5, 6]);

            var mergeSortedResult2 = MergeSortedArray.Merge([4, 5, 6, 0, 0, 0], 3, [1, 2, 3], 3);

            var mergeSortedResult = MergeSortedArray.Merge([0, 0, 0, 0, 0], 0, [1, 2, 3, 4, 5], 5);

            var containerResult1 = ContainerWaterProblem.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
            var containerResult2 = ContainerWaterProblem.MaxArea([1, 1]);

            var isValidOrder = AlienDictionary.IsAlienSorted(["hello", "leetcode"], "hlabcdefgijkmnopqrstuvwxyz");
            var isValidOrder1 = AlienDictionary.IsAlienSorted(["word", "world", "row"], "worldabcefghijkmnpqstuvxyz");

            var isValidOrder2 = AlienDictionary.IsAlienSorted(["apple", "app"], "abcdefghijklmnopqrstuvwxyz");


            var nextPermutation1 = NexuPermutation.NextPermutation([1, 2, 3, 4, 5]);
            var nextPermutation2 = NexuPermutation.NextPermutation([5, 4, 3, 2, 1]);
            var nextPermutation3 = NexuPermutation.NextPermutation([2, 5, 4, 3, 1]);
            var nextPermutation4 = NexuPermutation.NextPermutation([1, 2, 5, 4, 3]);


            var uniqueElementsCount = RemoveDuplicatesProblem.RemoveDuplicatesV2([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);

            var uniqueElementsCount1 = RemoveDuplicatesProblem.RemoveDuplicatesV2([1, 1, 2]);

            var uniqueElementsCount2 = RemoveDuplicatesProblem.RemoveDuplicatesV2([1, 1]);

            var uniqueElementsCount3 = RemoveDuplicatesProblem.RemoveDuplicatesV2([1, 2, 3]);

            var uniqueElemetns4 = RemoveDuplicatesProblem.RemoveDuplicatesV2([1, 2, 2]);

            var firstAndLastIndex = FirstAndLastPosition.SearchRange([5, 7, 7, 8, 8, 10], 8);
            var firstAndLastIndex2 = FirstAndLastPosition.SearchRange([0, 0, 1, 1, 1, 8, 9, 10], 12);
            var firstAndLastIndex3 = FirstAndLastPosition.SearchRange([1], 1);
            var firstAndLastIndex4 = FirstAndLastPosition.SearchRange([1, 2, 3, 3, 3, 3, 4, 5, 9], 3);
            var firstAndLastIndex5 = FirstAndLastPosition.
                SearchRange([0, 0, 1, 1, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 6, 6, 6, 8, 10, 10], 4);

            var firstAndLastIndex6 = FirstAndLastPosition.SearchRange([2, 2], 2);

            var firstAndLastIndex7 = FirstAndLastPosition.SearchRange([5, 7, 7, 7, 7, 8, 8, 10], 8);

            var firstAndLastIndex8 = FirstAndLastPosition.
                SearchRange([0, 0, 0, 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 8, 8, 9, 9, 10, 10, 11, 11], 0);

            var firAndLastIndex9 = FirstAndLastPosition.SearchRange([1, 1, 1, 1, 1, 1, 2, 3, 4, 4, 5, 5, 5, 6, 7, 8, 8, 8, 8], 8);

            var totalWater = TrappingRainWater.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]);
            var totalWater1 = TrappingRainWater.Trap([4, 2, 0, 3, 2, 5]);

            var midean1 = MedianOfSortedArrary.FindMedianSortedArrays([1, 3], [2]);
            var midean2 = MedianOfSortedArrary.FindMedianSortedArrays([1, 2], [3, 4]);
            var midean3 = MedianOfSortedArrary.FindMedianSortedArrays([3, 4], [1, 2]);

            var isValidAnagram = ValidAnagram.IsAnagramV2("anagram", "nagaram");
            var isValidAnagram1 = ValidAnagram.IsAnagramV2("Bat", "nagaram");

            var top5elements = TopKElements.Top5MaximumElements([5, 1, 10, 20, 3, 12, 8, 15]);

            var topKFrequestElements = TopKFrequestElements.TopKFrequent([1, 1, 1, 2, 2, 3], 2);

            var groupAnagram = GropAnagram.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);

            var groupAnagram2 = GropAnagram.GroupAnagrams(["bdddddddddd", "bbbbbbbbbbc"]);


            Console.WriteLine("Hello, World!");
        }
    }
}
