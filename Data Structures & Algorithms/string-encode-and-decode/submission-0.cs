public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach (string str in strs) {
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int wordLength = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j + 1, wordLength));
            i = j + 1 + wordLength;
        }
        return result;
    }
}
