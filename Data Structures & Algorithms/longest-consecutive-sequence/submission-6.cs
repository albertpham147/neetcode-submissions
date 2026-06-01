public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();
        numSet = nums.ToHashSet();

        int longestStreak = 0;
        int currentStreak = 0;

        foreach (int i in numSet)
        {
            if (numSet.Contains(i - 1)) // if the number is not the start of a sequence, skip it
            {
                continue;
            }

            // if the number is the start of a sequence
            int currentNum = i;
            currentStreak = 1;

            while (numSet.Contains(currentNum + 1))
            {
                currentNum++;
                currentStreak++;
            }

            if (currentStreak > longestStreak)
            {
                longestStreak = currentStreak;
            }
        }

        return longestStreak;
    }
}
