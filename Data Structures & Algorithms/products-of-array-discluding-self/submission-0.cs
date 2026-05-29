public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int Product = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (j == i)
                    continue;
                Product *= nums[j];
            }
            result[i] = Product;
        }
        return result;
    }
}
