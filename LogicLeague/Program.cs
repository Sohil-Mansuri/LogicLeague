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
            Console.WriteLine("Hello, World!");
        }
    }
}
