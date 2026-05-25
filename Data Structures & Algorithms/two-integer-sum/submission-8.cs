public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            int[] numsSort = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numsSort[i] = nums[i];
            }
            Array.Sort(numsSort);

            int right = 0;
            int left = numsSort.Length - 1;

            for (int i = 0; i < numsSort.Length; i++)
            {
                int sum = numsSort[right] + numsSort[left];

                if (sum == target)
                {
                    break;
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

            int finalIndex1 = -1, finalIndex2 = -1;
            bool checkIndex1 = true;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == numsSort[right] && checkIndex1)
                {
                    finalIndex1 = i;
                    checkIndex1 = false;
                }
                if(nums[i] == numsSort[left])
                {
                    finalIndex2 = i;
                }
            }

            int[] result = [finalIndex1, finalIndex2];
            Array.Sort(result);

            return result;
    }
}
