public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            List<int[]> unsortedNumber = new();

            for (int i = 0; i < nums.Length; i++)
            {
                unsortedNumber.Add([nums[i], i]); // [number, index]
            }

            List<int[]> sortedNumber = unsortedNumber.OrderBy(arr => arr[0]).ToList();

            int right = 0;
            int left = nums.Length - 1;

            while (right < left)
            {
                int sum = sortedNumber[right][0] + sortedNumber[left][0];

                if (sum == target)
                {
                    if(sortedNumber[right][1] > sortedNumber[left][1])
                        return [sortedNumber[left][1], sortedNumber[right][1]];
                    return [sortedNumber[right][1], sortedNumber[left][1]];
                }
                else if (sum > target)
                {
                    left--;
                }
                else if (sum < target)
                {
                    right++;
                }
            }

            return [0];
    }
}
