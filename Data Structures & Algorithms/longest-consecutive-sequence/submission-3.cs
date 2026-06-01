public class Solution {
    public int LongestConsecutive(int[] nums) {

            if(nums.Length == 0) return 0;
            HashSet<int> result = new HashSet<int>();
            HashSet<int> checkMap = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!result.Contains(nums[i]))
                {
                    result.Add(nums[i]);
                    Console.WriteLine(nums[i]); 
                }
            }

            int longestConsecutive = 1;
            int currentConsecutive = 0;
            foreach (int i in result)
            {   
                if (checkMap.Contains(i))
                    continue;
                int increment = i;
                currentConsecutive = 0;
                while (result.Contains(increment))
                {                    
                    checkMap.Add(increment);
                    currentConsecutive++;
                    increment++;
                }
                if (currentConsecutive > longestConsecutive)
                {
                    longestConsecutive = currentConsecutive;
                }

            }


            return longestConsecutive;
    }
}
