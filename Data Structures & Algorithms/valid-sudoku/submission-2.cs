public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> rowMap = new();
        Dictionary<int, HashSet<char>> colMap = new();
        Dictionary<string, HashSet<char>> subBoxMap = new();

        for (int i = 0; i < 9; i++)
        {
            rowMap[i] = new HashSet<char>();
            colMap[i] = new HashSet<char>();
        }

        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                string subBoxKey = (row / 3) + "," + (col / 3);
                if(!subBoxMap.ContainsKey(subBoxKey))
                    subBoxMap.Add(subBoxKey, new HashSet<char>());
                
                char value = board[row][col];

                if (board[row][col] == '.')
                {
                    continue;
                }

                if (rowMap[row].Contains(value) || colMap[col].Contains(value) || subBoxMap[subBoxKey].Contains(value))
                {
                    return false;
                }
                
                rowMap[row].Add(value);
                colMap[col].Add(value);
                subBoxMap[subBoxKey].Add(value);

            }
        }

        return true;
    }
}
