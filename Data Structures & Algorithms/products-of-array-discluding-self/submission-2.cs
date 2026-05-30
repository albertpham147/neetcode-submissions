public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
            int[] leftPredixSumArr = new int[nums.Length];
            int[] rightPredixSumArr = new int[nums.Length];
            int[] result = new int[nums.Length];

            int leftPredixSum = 1;
            int rightPredixSum = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                rightPredixSum *= nums[i];
                rightPredixSumArr[i] = rightPredixSum;

                leftPredixSum *= nums[nums.Length - 1 - i];
                leftPredixSumArr[nums.Length - 1 - i] = leftPredixSum;
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = leftPredixSumArr[i + 1];
                    continue;
                }
                if (i == result.Length - 1)
                {
                    result[i] = rightPredixSumArr[i - 1];
                    break;
                }

                result[i] = rightPredixSumArr[i - 1] * leftPredixSumArr[i + 1];
            }

            return result;
    }
}
