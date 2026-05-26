public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (count.ContainsKey(num)) count[num]++;
            else count[num] = 1;
        }

        List<int[]> arr = count.Select(value => new int[]{value.Key, value.Value}).ToList();

        arr.Sort((a,b) => b[1].CompareTo(a[1]));

        int[] res = new int[k];
        for (int i = 0; i < res.Length; i++)
        {
            res[i] = arr[i][0];
        }

        return res;
    }
}
