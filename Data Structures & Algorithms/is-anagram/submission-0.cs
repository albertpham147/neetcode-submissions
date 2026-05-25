public class Solution {
    public bool IsAnagram(string s, string t) {
            char[] string1 = s.ToCharArray();
            char[] string2 = t.ToCharArray();

            if(string1.Length != string2.Length)
                return false;

            Array.Sort(string1);
            Array.Sort(string2);

            for (int i = 0; i < string1.Length; i++)
            {
                if(string1[i] != string2[i])
                {
                    return false;
                }
            }

            return true;
    }
}
