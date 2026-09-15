public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        //     char[] sCharArray = s.ToCharArray();
        //     char[] tCharArray = t.ToCharArray();

        //     Array.Sort(sCharArray);
        //     Array.Sort(tCharArray);

        //    string sSorted = new string(sCharArray);
        //    string tSorted = new string(tCharArray);

        //    return sSorted == tSorted;

        // Now For Optimal Solution
        // We create a index of 26 each representing each character and we increament for one array
        // and decrement for another array array so at the end we get 0 in all array
        int[] countOfAlphabets = new int[26];
        for (int i = 0; i < s.Length; i++) {
            countOfAlphabets[s[i] - 'a']++;
            countOfAlphabets[t[i] - 'a']--;
        }
        foreach(int c in countOfAlphabets)
        {
            if(c!=0)
            {
                return false;
            }
        }
        return true;
    }
}
