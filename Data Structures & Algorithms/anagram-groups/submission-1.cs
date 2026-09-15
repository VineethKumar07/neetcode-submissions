public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        for(int i = 0 ; i< strs.Length ; i++)
        {
            char[] strArray = strs[i].ToCharArray();
            Array.Sort(strArray);
            string signKey = new string(strArray);
            if(!map.ContainsKey(signKey))
            {
                map[signKey] = new List<string>();
            }
            map[signKey].Add(strs[i]);
        }
        return map.Values.ToList();
    }
}
