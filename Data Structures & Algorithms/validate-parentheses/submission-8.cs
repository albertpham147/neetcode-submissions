public class Solution {
    public bool IsValid(string s) {
            if (s.Length % 2 != 0) return false; // odd number of characters can never be valid

            Stack<char> openParenthasesStack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    openParenthasesStack.Push(c); // push open brackets first
                }
                else // check closing brackets, if we encounter a closing bracket, we should have an opening bracket on the stack to match it
                {
                    if (openParenthasesStack.Count == 0) return false; // no opening bracket to match
                    char top = openParenthasesStack.Pop();
                    if ((top == '(' && c != ')') ||
                        (top == '{' && c != '}') ||
                        (top == '[' && c != ']'))
                        return false; // mismatched brackets
                    
                }
            }

            if (openParenthasesStack.Count > 0)
                return false;

            return true;
    }
}
