public class Solution {
    public bool IsAnagram(string s, string t) {
            if (s.Length != t.Length)
                return false;

            char[] charArr1 = s.ToCharArray();
            char[] charArr2 = t.ToCharArray();

            Array.Sort(charArr1);
            Array.Sort(charArr2);

            for (int i = 0; i < charArr1.Length; i++)
            {
                if (charArr1[i] != charArr2[i])
                {
                    return false;
                }
            }

            return true;
    }
}
