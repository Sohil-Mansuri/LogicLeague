﻿using LogicLeague.Stack;

namespace LogicLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var profit = BuySellStock.MaxProfit([7, 1, 5, 3, 6, 4]);

            var profit1 = BuySellStock.MaxProfitV2([7, 1, 5, 3, 6, 4]);
            var profit2 = BuySellStock.MaxProfitV2([7, 6, 4, 3, 1]);

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
            var minInRotatedArray1 = FindMinimumInRotatedArray.FindMin([6, 1, 2, 3, 4, 5]);

            var searchTarget = SearchInRotatedArray.Search([4, 5, 6, 7, 0, 1, 2], 3);
            var searchTarget2 = SearchInRotatedArray.Search([3, 1], 1);

            var twoSumPart2 = TwoSumPart2.TwoSum([-1, 0], -1);


            var threeSumResult = ThreeSumProblem.ThreeSum([-5, -5, 0, 1, 5]);
            var threeSumResult2 = ThreeSumProblem.ThreeSum([-1, 0, 1, 2, -1, -4]);
            var threeSumResult3 = ThreeSumProblem.ThreeSum([2, -3, 0, -2, -5, -5, -4, 1, 2, -2, 2, 0, 2, -4, 5, 5, -10]);
            var threeSum = ThreeSumProblem.ThreeSumV2([-1, 0, 1, 2, -1, -4]);

            var mergeSortedArray = MergeSortedArray.Merge([1, 2, 3,], [2, 5, 6]);

            var mergeSortedResult2 = MergeSortedArray.Merge([4, 5, 6, 0, 0, 0], 3, [1, 2, 3], 3);
            var mergeSortedResult = MergeSortedArray.Merge([0, 0, 0, 0, 0], 0, [1, 2, 3, 4, 5], 5);

            var mergeSortedResult3 = MergeSortedArray.MergeV2([4, 5, 6, 0, 0, 0], 3, [1, 2, 3], 3);
            var mergeSortedResult4 = MergeSortedArray.MergeV2([0, 0, 0, 0, 0], 0, [1, 2, 3, 4, 5], 5);


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


            var validSudoko = ValidSudokoProblem.IsValidSudoku([["5","3",".",".","7",".",".",".","."]
                                                                ,["6",".",".","1","9","5",".",".","."]
                                                                ,[".","9","8",".",".",".",".","6","."]
                                                                ,["8",".",".",".","6",".",".",".","3"]
                                                                ,["4",".",".","8",".","3",".",".","1"]
                                                                ,["7",".",".",".","2",".",".",".","6"]
                                                                ,[".","6",".",".",".",".","2","8","."]
                                                                ,[".",".",".","4","1","9",".",".","5"]
                                                                ,[".",".",".",".","8",".",".","7","9"]]);

            var encodedString = EncodeDecodeString.EncodeString(["ab", "dfg", "ac", "dg"]);

            var originalString = EncodeDecodeString.Decode(encodedString);

            var longestConsutive = LongestConsecutiveSequence.LongestConsecutive([100, 4, 200, 1, 3, 2]);
            var longestConsutive1 = LongestConsecutiveSequence.LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]);

            var longestCommonPrefix = LongestCommonPrefixProblem.LongestCommonPrefix(["flower", "flow", "flight"]);
            var longestCommonPrefix2 = LongestCommonPrefixProblem.LongestCommonPrefix(["dog", "racecar", "car"]);
            var longestCommonPrefix3 = LongestCommonPrefixProblem.LongestCommonPrefix(["flow", "flower", "floweght"]);

            var fizzBuzz = FizzBuzzProblem.FizzBuzz(15);

            var longestRepeatingCharacter = LongestRepeatingCharacter.CharacterReplacement("AABABBA", 1);
            var longestRepeatingCharacter2 = LongestRepeatingCharacter.CharacterReplacement("ABAB", 2);

            var longestSubsstring = LongestSubstring.LengthOfLongestSubstringV2("pwwkew");
            var longestSubsstring0 = LongestSubstring.LengthOfLongestSubstringV2("dvdf");

            var longestSubsstring1 = LongestSubstring.LengthOfLongestSubstring("pwwkew");
            var longestSubsstring2 = LongestSubstring.LengthOfLongestSubstring("dvdf");

            var longestSubsstring4 = LongestSubstring.LengthOfLongestSubstringV3("pwwkew");
            var longestSubsstring5 = LongestSubstring.LengthOfLongestSubstringV3("pwwwwwwkew");
            var longestSubsstring6 = LongestSubstring.LengthOfLongestSubstringV3("dvdf");

            var validParenthesis = ValidParantheses.IsValid("()");
            var validParenthesis1 = ValidParantheses.IsValid("{{{{{}}");
            var validParenthesis2 = ValidParantheses.IsValid("()[]{}");

            var minimumWindowSubstring = MinimumWindowSubstring.MinWindow("ADOBECODEBANC", "ABC");
            var minimumWindowSubstring2 = MinimumWindowSubstring.MinWindow("A", "B");

            var validPalindrome = ValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama");
            var validPalindrome2 = ValidPalindrome.IsPalindrome("race a car");


            var longestPalindrome = LongestPalindromSubstring.LongestPalindrome("abba");
            var longestPalindrome2 = LongestPalindromSubstring.LongestPalindrome("bhabbagd");
            var longestPalindrome3 = LongestPalindromSubstring.LongestPalindrome("abrbadaadab");
            var longestPalindrome4 = LongestPalindromSubstring.LongestPalindrome("ebbabad");
            var longestPalindrome5 = LongestPalindromSubstring.LongestPalindrome("babad");
            var longestPalindrome6 = LongestPalindromSubstring.LongestPalindrome("cbbd");
            var longestPalindrome7 = LongestPalindromSubstring.LongestPalindrome("a");

            var palindromicSubstrings = PalindromicSubstrings.CountSubstrings("abbc");
            var palindromicSubstrings1 = PalindromicSubstrings.CountSubstrings("aaa");
            var palindromicSubstrings2 = PalindromicSubstrings.CountSubstrings("fjskfjsksjs");


            var head = ListNode.CreateList([1, 2, 2, 1]);
            var palindromeLinkedList = PalindromeLinkedList.IsPalindromeV2(head);
            var palindromeLinkedList12 = PalindromeLinkedList.IsPalindrome(head);

            var head4 = ListNode.CreateList([1, 1, 0, 0, 1]);
            var palindromeLinkedList14 = PalindromeLinkedList.IsPalindromeV2(head4);

            var head1 = ListNode.CreateList([1, 2]);
            var palindromeLinkedList2 = PalindromeLinkedList.IsPalindrome(head1);
            var palindromeLinkedList13 = PalindromeLinkedList.IsPalindrome(head1);


            var head3 = ListNode.CreateList([1, 2, 3]);
            var reh2 = ListNode.ReverseV2(head3);
            var reH = ListNode.Reverse(head3);


            var textJustification = TestJustification.FullJustify(["This", "is", "an", "example", "of", "text", "justification."], 16);

            var letterCombination = LetterCombination.LetterCombinations("23");


            // DP

            var climbingStairs = ClimbingStairs.ClimbStairs(3);

            var minCostofClimbingStairs = MinCostClimblingStairs.MinCostClimbingStairs([5, 1, 10, 2, 1]);
            var minCostofClimbingStairs1 = MinCostClimblingStairs.MinCostClimbingStairs([1, 100, 1, 1, 1, 100, 1, 1, 100, 1]);
            var minCostofClimbingStairs2 = MinCostClimblingStairs.MinCostClimbingStairs([10, 15, 20]);

            var coinChange = CoinChangeProblem.CoinChange([1, 2, 5], 11);
            var coinChange2 = CoinChangeProblem.CoinChange([1, 3, 5, 6], 8);
            var coinChange3 = CoinChangeProblem.CoinChange([2], 3);

            var decodeWays = DecodeWays.NumDecodings("456");
            var decodeWays2 = DecodeWays.NumDecodings("122016");

            var decodeWays3 = DecodeWays.NumDecodingsV2("456");
            var decodeWays4 = DecodeWays.NumDecodingsV2("122016");

            var pascalTriangle = PascalsTriangle.Generate(5);

            var wordBreak = WordBreakProblem.WordBreak("espn", ["e", "sp", "n"]);
            var wordBreak1 = WordBreakProblem.WordBreak("leetcode", ["leet", "code"]);
            var wordBreak2 = WordBreakProblem.WordBreak("applepenapple", ["apple", "pen"]);
            var wordBreak3 = WordBreakProblem.WordBreak("catsandog", ["cats", "dog", "sand", "and", "cat"]);

            var combinationSum = CombinationSumProblem.CombinationSum([2, 5, 6], 10);

            var houseRobber = HouseRobber.RobV2([1, 2, 3, 1]);
            var houseRobber2 = HouseRobber.RobV2([2, 7, 9, 3, 1]);
            var houseRobber3 = HouseRobber.RobV2([2, 1, 1, 2]);

            var houseRobber4 = HouseRobber2.Rob([1, 2, 3, 1]);
            var houseRobber5 = HouseRobber2.Rob([2, 7, 9, 3, 1]);
            var houseRobber6 = HouseRobber2.Rob([2, 1, 1, 2]);
            var houseRobber7 = HouseRobber2.Rob([1, 2, 15, 11, 3, 6, 10]);
            var houseRobber8 = HouseRobber2.Rob([1]);

            var uniquePaths = UniquePathsProblem.UniquePaths(3, 3);
            var uniquePaths2 = UniquePathsProblem.UniquePaths(1, 1);

            var generateParenthesis1 = GenerateParenthesisProblem.GenerateParenthesis(5);

            var jumpGame = JumpGame.CanJump([2, 3, 1, 0, 2, 5]);
            var jumpGame2 = JumpGame.CanJump([3, 2, 1, 0, 4]);
            var jumpGame3 = JumpGame.CanJump([2, 3, 1, 1, 4]);
            var jumpGame4 = JumpGame.CanJump([2]);

            var jumpGame5 = JumpGame.CanJumpV2([2, 3, 1, 0, 2, 5]);
            var jumpGame6 = JumpGame.CanJumpV2([3, 2, 1, 0, 4]);
            var jumpGame7 = JumpGame.CanJumpV2([2, 3, 1, 1, 4]);
            var jumpGame8 = JumpGame.CanJumpV2([2]);


            var jumpGame21 = JumGame2.Jump([1, 3, 1, 3, 1, 1, 1, 2]);
            var jumpGame22 = JumGame2.Jump([2, 3, 0, 1, 4]);
            var jumpGame23 = JumGame2.Jump([2, 3, 1, 1, 4]);

            var raceProblem = RaceCarProblemV2.Racecar(6);


            var longestMaxiSequence = LongesMaximumSubSequence.LengthOfLIS([10, 9, 2, 5, 3, 7, 101, 18]);
            var longestMaxiSequence2 = LongesMaximumSubSequence.LengthOfLIS([0, 1, 0, 3, 2, 3]);
            var longestMaxiSequence3 = LongesMaximumSubSequence.LengthOfLIS([7, 7, 7, 7, 7, 7, 7]);
            var longestMaxiSequence4 = LongesMaximumSubSequence.LengthOfLIS([4, 10, 4, 3, 8, 9]);
            var longestMaxiSequence5 = LongesMaximumSubSequence.LengthOfLIS([1, 3, 6, 7, 9, 4, 10, 5, 6]);


            var longestMaxiSequence22 = LongesMaximumSubSequence.LengthOfLISV2([10, 9, 2, 5, 3, 7, 101, 18]);
            var longestMaxiSequence23 = LongesMaximumSubSequence.LengthOfLISV2([0, 1, 0, 3, 2, 3]);
            var longestMaxiSequence33 = LongesMaximumSubSequence.LengthOfLISV2([7, 7, 7, 7, 7, 7, 7]);
            var longestMaxiSequence44 = LongesMaximumSubSequence.LengthOfLISV2([4, 10, 4, 3, 8, 9]);
            var longestMaxiSequence55 = LongesMaximumSubSequence.LengthOfLISV2([1, 3, 6, 7, 9, 4, 10, 5, 6]);


            var canPartition = PartitionEqualSubsetSum.CanPartition([1, 5, 11, 5]);
            var canPartition2 = PartitionEqualSubsetSum.CanPartition([1, 2, 3, 5]);


            var isRegularExpressionMatch = RegularExpressionMatching.IsMatch("faangm", "fa*n.m");
            var isRegularExpressionMatch2 = RegularExpressionMatching.IsMatch("ab", "a*");


            var knapSackProblem = KnapSackProblem.Knapsack([3, 4, 5], [30, 50, 60], 8);

            var mergeInterval = MergeIntervals.Merge([[1, 3], [2, 6], [8, 10], [15, 18]]);
            var mergeInterval2 = MergeIntervals.Merge([[1, 4], [5, 6]]);
            var mergeInterval3 = MergeIntervals.Merge([[1, 4], [0, 4]]);
            var mergeInterval4 = MergeIntervals.Merge([[1, 4], [0, 0]]);

            var insertIntervals = InsertInterval.Insert([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8]);
            var insertIntervals2 = InsertInterval.Insert([[1, 2], [3, 6], [7, 9], [10, 11], [12, 16]], [4, 5]);
            var insertIntervals4 = InsertInterval.Insert([], [4, 5]);

            var nonOverlapping = NonOverlappingIntervals.EraseOverlapIntervals([[1, 2], [1, 2], [1, 2]]);
            var nonOverlapping2 = NonOverlappingIntervals.EraseOverlapIntervals([[1, 2], [2, 3], [3, 4], [1, 3]]);
            var nonOverlapping3 = NonOverlappingIntervals.EraseOverlapIntervals([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]]);


            var squareSum = HappyNumber.IsHappy(2);
            var squareSum2 = HappyNumber.IsHappy(19);


            var dailyTemptures = DailyTempretures.DailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]);
            var dailyTemptures2 = DailyTempretures.DailyTemperatures([30, 40, 50, 60]);
            var dailyTemptures3 = DailyTempretures.DailyTemperatures([30, 60, 90]);


            var reversePolishEv = ReversePolishNotation.EvalRPN(["2", "1", "+", "3", "*"]);
            var reversePolishEv2 = ReversePolishNotation.EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]);
            var reversePolishEv3 = ReversePolishNotation.EvalRPN(["4", "13", "5", "/", "+"]);


            var minStack = new MinStack();

            minStack.Push(-1);
            var tom3 = minStack.Top();
            var min4 = minStack.GetMin();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            var min1 = minStack.GetMin();
            minStack.Pop();
            var top1 = minStack.Top();
            var min2 = minStack.GetMin();

            var carfleet = CarFleetProblem.CarFleet(12, [10, 8, 0, 5, 3], [2, 4, 1, 1, 3]);
            var carfleet2 = CarFleetProblem.CarFleet(100, [0, 2, 4], [4, 2, 1]);
            var carfleet3 = CarFleetProblem.CarFleet(10, [3], [3]);
            var carfleet4 = CarFleetProblem.CarFleet(10, [6, 8], [3, 2]);


            var minRemoveToMakeItValid = MinimumValidParenthesis.MinRemoveToMakeValid("p)a(r))+((h)");
            var minRemoveToMakeItValid2 = MinimumValidParenthesis.MinRemoveToMakeValid("))((");


            var maxHistogramArea = LargestRectangleInHistogram.LargestRectangleArea([3, 2, 5, 6, 7, 4, 6, 3]);
            var maxHistogramArea2 = LargestRectangleInHistogram.LargestRectangleArea([2, 1, 5, 6, 2, 3]);
            var maxHistogramArea3 = LargestRectangleInHistogram.LargestRectangleArea([4, 3]);
            var maxHistogramArea4 = LargestRectangleInHistogram.LargestRectangleArea([2, 4]);
            var maxHistogramArea5 = LargestRectangleInHistogram.LargestRectangleArea([10]);


            var longestParentheses = LongestValidParenthesesProblem.LongestValidParentheses("(()");
            var longestParentheses2 = LongestValidParenthesesProblem.LongestValidParentheses(")()())");
            var longestParentheses3 = LongestValidParenthesesProblem.LongestValidParentheses("");
            var longestParentheses4 = LongestValidParenthesesProblem.LongestValidParentheses("()(()()");
            var longestParentheses5 = LongestValidParenthesesProblem.LongestValidParentheses("()(()");

            var maxStack = new MaxStack();

            maxStack.Push(1); maxStack.Push(2); maxStack.Push(6); maxStack.Push(3); maxStack.Push(4); maxStack.Push(7);

            var top23 = maxStack.Peek();

            var top24 = maxStack.Pop();

            var top26 = maxStack.PeekMax();

            var top27 = maxStack.PopMax();

            var top28 = maxStack.Peek();

            var top29 = maxStack.PeekMax();

            var largestNumber = LargetNumber.LargestNumber([10, 2]);
            var largestNumber2 = LargetNumber.LargestNumber([3, 30, 34, 5, 9]);
            var largestNumber3 = LargetNumber.LargestNumber([3]);
            var largestNumber4 = LargetNumber.LargestNumber([700000000, 500000000]);
            var largestNumber5 = LargetNumber.LargestNumber([0, 0]);

            var mergeSort = MergeSortAlgo.Sort([3, 5, 2, 7, 9]);

            var sortColors = SortColorsProblem.SortColors([2, 0, 2, 1, 1, 0]);
            var sortColors2 = SortColorsProblem.SortColors([2, 0, 1]);

            var majorityElement = MajorityElementProblem.MajorityElement([3, 2, 3]);
            var majorityElement2 = MajorityElementProblem.MajorityElement([2, 2, 1, 1, 1, 2, 2]);
            var majorityElement3 = MajorityElementProblem.MajorityElement([6, 5, 5]);

            var list1 = ListNode.CreateList([2, 5, 7]);
            var list2 = ListNode.CreateList([1, 3, 4, 9]);

            //var combined = LinkedListSort.MergeList(list1, list2);
            var listMid1 = LinkedListSort.FindMid(list1);
            var listMid2 = LinkedListSort.FindMid(list2);


            var head12 = ListNode.CreateList([4, 5, 7, 9, 1, 3, 5, 23]);

            var sortResult = LinkedListSort.SortList(head12);

            var binarySearch = BinarySearch.Search([-1, 0, 3, 5, 9, 12], 9);
            var binarySearch2 = BinarySearch.Search([-1, 0, 3, 5, 9, 12], 2);
            var binarySearch3 = BinarySearch.Search([2], 2);

            var searchIn2d1 = Search2DMetrix.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3);
            var searchIn2d2 = Search2DMetrix.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13);
            var searchIn2d3 = Search2DMetrix.SearchMatrix([[1, 1]], 2);


            var kokoEatingBanana = KokoEatingBanana.MinEatingSpeed([3, 6, 7, 11], 8);
            var kokoEatingBanana2 = KokoEatingBanana.MinEatingSpeed([30, 11, 23, 4, 20], 6);
            Console.WriteLine("Hello, World!");
        }
    }
}
