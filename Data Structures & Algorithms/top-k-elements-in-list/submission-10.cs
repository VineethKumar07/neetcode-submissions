public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Here Optimal solution is buck sort
        //In Bucket sort what we do is create buckets with the frequencies of nums
        //as frequency of the element will be in the range of (0,n) we create n+1 buckets
        //below I will add code in steps for easy


        //step 1 Get Dictionary to get all the frequencies
        Dictionary<int,int> count = new Dictionary<int,int>();
        foreach(int num in nums)
        {
            count[num] = count.GetValueOrDefault(num,0)+1;
        }

        //step 2 : create buckets where buckets are Array of List to store the elements with 
        //same frequency , and create buckets with 0 and nums.Length+1

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var entry in count)
        {
            int frequency = entry.Value;
            int element = entry.Key;

            if(buckets[frequency]==null)
            {
                buckets[frequency] = new List<int>();
            }
            buckets[frequency].Add(element);
        }

        //Now traverse back the bucketlist and Add it in a Array so we can get maximum
        //frequency elements
        List<int> result = new List<int>();
        for(int i = buckets.Length - 1 ; i>=0 && result.Count < k ; i--)
        {
            if(buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }

        //Now return elements
        return result.Take(k).ToArray();
    }
}
