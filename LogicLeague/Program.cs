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
            var searchTarget2 = SearchInRotatedArray.Search([3,1], 1);

            var twoSumPart2 = TwoSumPart2.TwoSum([-1, 0], -1);
            Console.WriteLine("Hello, World!");
        }
    }
}
