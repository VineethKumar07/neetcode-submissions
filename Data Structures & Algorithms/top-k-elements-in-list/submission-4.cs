public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        HashSet<int> result = new HashSet<int>();
        Dictionary<int,int> count = new Dictionary<int,int>();

        foreach(int num in nums)
        {
            if(!count.ContainsKey(num))
            {
                count[num] = 0;
            }
            count[num]++;
            //count[num] = count.GetValueOrDefault(num,0)+1;
        }
        return count.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();
    }
}
