public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
            // create hash map for (sorted word, index of array)
            List<List<string>> result = new List<List<string>>();

            Dictionary<string, int> groupMap = new Dictionary<string, int>(); // key word|index

            int mapIndex = 0;

            foreach (var str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string sortString = new(chars);

                if (groupMap.ContainsKey(sortString))
                {
                    result[groupMap[sortString]].Add(str);
                    continue;
                }
                // only add if have new keyword
                groupMap[sortString] = mapIndex; // add|replace keyword|index
                result.Add(new List<string> { str} ); 
                mapIndex++;

            }

            return result;

        
    }
}
