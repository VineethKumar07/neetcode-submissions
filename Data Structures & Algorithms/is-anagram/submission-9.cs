public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
            char[] sCharArray = s.ToCharArray();
            char[] tCharArray = t.ToCharArray();

            Array.Sort(sCharArray);
            Array.Sort(tCharArray);

           string sSorted = new string(sCharArray);
           string tSorted = new string(tCharArray);

           return sSorted == tSorted;

    }
}
