public class Solution {
    public bool IsValidSudoku(char[][] board) {
        //In Sudoku no elemeny should be same in row , column and in the box so I created 9 HashSet of rows
        //boxes and cols
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for(int i = 0 ; i < 9 ; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i = 0 ; i < 9 ; i++)
        {
            for(int j = 0 ; j < 9 ; j++)
            {
                char value = board[i][j];
                if(value == '.')
                {
                    continue;
                }

                int box = (i/3)*3 + (j/3);
                
                if(rows[i].Contains(value) || cols[j].Contains(value) || boxes[box].Contains(value))
                {
                    return false;
                }
                rows[i].Add(value);
                cols[j].Add(value);
                boxes[box].Add(value);
            }
        }
        return true;
    }
}
