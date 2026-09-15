public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new List<List<string>>();
        HashSet<string> seen = new HashSet<string>();
        int length = strs.Length;
        for (int i = 0; i < strs.Length - 1; i++) {
            List<string> anagramList = new List<string>();
            if (!seen.Contains(strs[i]))
            {
                anagramList.Add(strs[i]);
                for (int j = i + 1; j < strs.Length; j++) {
                    if (IsAnagram(strs[i], strs[j])) {
                        anagramList.Add(strs[j]);
                        seen.Add(strs[i]);
                        seen.Add(strs[j]);
                    }
                }
                result.Add(anagramList);
            }
           
        }
         if (!seen.Contains(strs[length - 1]))
            {
                result.Add(new List<string>{strs[length - 1]});
            }
        return result;
    }

    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }
        foreach (char c in count) {
            if (c != 0) {
                return false;
            }
        }
        return true;
    }
}
