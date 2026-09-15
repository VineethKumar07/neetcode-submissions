public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums == null || nums.Length == 0)
        {
            return false;
        }
        // Array.Sort(nums);
        // for(int i = 0; i< nums.Length - 1 ; i++)
        // {
        //     if(nums[i] == nums[i+1])
        //     {
        //         return true;
        //     }
        // }
        // return false;

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