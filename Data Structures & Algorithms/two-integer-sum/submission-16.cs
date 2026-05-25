public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> prevMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (prevMap.ContainsKey(diff) && prevMap[diff] != i)
                {
                    if (prevMap[diff] > i)
                    {
                        return [i, prevMap[diff]];
                    }
                    return [prevMap[diff], i];
                }

                prevMap[nums[i]] = i; // add/replace new number|index

            }

            return [0];
    }
}
