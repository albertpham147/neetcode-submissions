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
        if(s == null) // check null
        {
            return new List<string>() { };
        }

        List<string> result = new List<string>();


        result = s.Split("`").ToList();


        return result;
    }
}
