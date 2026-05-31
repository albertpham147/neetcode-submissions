public class Solution {
    public bool IsValidSudoku(char[][] board) {
                    Dictionary<int, HashSet<char>> rowMap = new();
            Dictionary<int, HashSet<char>> colMap = new();
            Dictionary<int, HashSet<char>> subBoxMap = new();

            for (int i = 0; i < 9; i++)
            {
                rowMap[i] = new HashSet<char>();
                colMap[i] = new HashSet<char>();
                subBoxMap[i] = new HashSet<char>();
            }

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == '.')
                    {
                        continue;
                    }

                    if (rowMap[row].Contains(board[row][col]) || colMap[col].Contains(board[row][col]))
                    {
                        return false;
                    }
                    rowMap[row].Add(board[row][col]);
                    colMap[col].Add(board[row][col]);
                }
            }

            for(int subBox = 0; subBox < subBoxMap.Count; subBox++)
            {
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        // Check every coloum in a row
                        int row = (subBox / 3) * 3 + i; // Assing Row of subbox (3x3)
                        int col = (subBox % 3) * 3 + j; // Assing Col of subbox (3x3)
                        if (board[row][col] == '.')
                            continue;
                        if (subBoxMap[subBox].Contains(board[row][col]))
                            return false;
                        subBoxMap[subBox].Add(board[row][col]);
                    }
                }
            }

            return true;
    }
}
