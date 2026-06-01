public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> result = new HashSet<int>();

        result = nums.ToHashSet();

        int longestConsecutive = 0;
        int currentConsecutive = 0;
        foreach (int i in result)
        {
            int increment = i;                    
            currentConsecutive = 0;
            while (result.Contains(increment)) 
            {
                currentConsecutive++;
                increment++; // Add number begin consecutive, replace if exist
            }
            if (currentConsecutive > longestConsecutive)
            {
                longestConsecutive = currentConsecutive;
            }

        }


        return longestConsecutive;
    }
}
