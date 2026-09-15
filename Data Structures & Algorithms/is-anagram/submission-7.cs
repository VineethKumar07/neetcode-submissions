public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
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
