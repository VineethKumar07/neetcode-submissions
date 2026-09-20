public class Solution {
    public bool IsPalindrome(string s) {
        //By Brute Force
        StringBuilder sb = new StringBuilder();
        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLower(c));
            }
        }
        string cleanedS = sb.ToString();
        char[] newArray = cleanedS.ToCharArray();
        Array.Reverse(newArray);
        string reversedS = new string(newArray);

        return cleanedS == reversedS;
    }
}
