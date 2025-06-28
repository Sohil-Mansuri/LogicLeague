using System.Dynamic;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self/
    /// without division
    /// </summary>
    internal class ProductOfArrary
    {
        // T(n), S(3n)
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] prefixProduct = new int[nums.Length];
            int[] postFixProduct = new int[nums.Length];

            int[] result = new int[nums.Length];

            for (int index = 0; index < nums.Length; index++)
            {
                if (index == 0)
                {
                    prefixProduct[index] = 1;
                }
                else
                {
                    prefixProduct[index] = nums[index - 1] * prefixProduct[index - 1];
                }
            }

            for (int index = nums.Length - 1; index > -1; index--)
            {
                if (index == nums.Length - 1)
                {
                    postFixProduct[index] = 1;
                }
                else
                {
                    postFixProduct[index] = nums[index + 1] * postFixProduct[index + 1];
                }
            }


            for (int index = 0; index < result.Length; index++)
            {
                result[index] = prefixProduct[index] * postFixProduct[index];
            }

            return result;
        }

        // Optimal in terms of Space complexity S(n) = O(1), just need 2 extra variables
        public static int[] ProductExceptSelfV2(int[] nums)
        {
            int prefixMul = 1;
            int postfixMul = 1;
            int[] result = new int[nums.Length];

            for (int index = 0; index < nums.Length; index++)
            {
                if (index == 0)
                {
                    prefixMul = 1;
                }
                else
                {
                    prefixMul = nums[index - 1] * prefixMul;
                }

                result[index] = prefixMul;
            }


            for (int index = nums.Length - 1; index > -1; index--)
            {
                if (index == nums.Length - 1)
                {
                    postfixMul = 1;
                }
                else
                {
                    postfixMul = nums[index + 1] * postfixMul;
                }

                result[index] = postfixMul * result[index];
            }

            return result;
        }
    }
}
