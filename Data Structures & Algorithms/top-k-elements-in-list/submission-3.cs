public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>(); // number | number of frequency
            int[] frequencyArray = new int[k];

           
            for (int i = 0; i < nums.Length; i++)
            {
                if (frequencyMap.ContainsKey(nums[i]))
                {
                    frequencyMap[nums[i]]++;
                    continue;
                }
                frequencyMap[nums[i]] = 1;
            }

            Dictionary<int, int> sortedFrequencyMap = (Dictionary<int, int>) frequencyMap.OrderByDescending(f => f.Value).ToDictionary();

            int numberReturn = 0;
            foreach (int key in sortedFrequencyMap.Keys)
            {
                if (numberReturn == k)
                    break;
                frequencyArray[numberReturn++] = key;
            }

            return frequencyArray;
    }
}
