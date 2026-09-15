public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++) {
            int[] count = new int[26];
            foreach (char c in strs[i]) {
                count[c - 'a']++;
            }
            string key = string.Join("#", count);
            if(!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(strs[i]);
        }
        return map.Values.ToList();
    }
}
