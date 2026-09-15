public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums == null || nums.Length == 0)
        {
            return false;
        }
        //Now with Hashset

        HashSet<int> seen = new HashSet<int>();
        foreach(int num in nums)
        {
            if(!seen.Add(num))
            {
                return true;
            }
        }
        return false;
    }
}