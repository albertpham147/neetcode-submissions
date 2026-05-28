public class Solution {

    public string Encode(IList<string> strs)
    {
        string encodeStr = null;

        if(strs.Count == 0)
        {
            return encodeStr;
        }

        for (int i = 0; i < strs.Count; i++)
        {
            encodeStr += strs[i];
            if(i >= 0 && i < strs.Count - 1)
            {
                encodeStr += "`";
            }
        }

        return encodeStr;
    }

    public List<string> Decode(string s)
    {
        if(s is null) // check null
        {
            return new List<string>() { };
        }
        if (string.IsNullOrEmpty(s)) // check empty
        {
            return new List<string>() { "" };
        }

        List<string> result = new List<string>();


        string str = "";
        for (int i = 0; i < s.Length; i++)
        {
            bool canAdd = true;

            if (s[i] == '`')
            {
                result.Add(str);
                str = "";
                canAdd = false;
            }

            if(canAdd)
                str += s[i];


            if (i == s.Length - 1)
            {
                result.Add(str);
                break;
            }
        }

        return result;
    }
}
