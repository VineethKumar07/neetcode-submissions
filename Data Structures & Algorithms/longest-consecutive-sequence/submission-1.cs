public class Solution {
    public int LongestConsecutive(int[] nums) {
        //when array is given in args hashset has that nums
        HashSet<int> map = new HashSet<int>(nums);
        int longest = 0;

        foreach(int num in nums)
        {
            if(!map.Contains(num-1))
            {
                int length = 1 ;
                while(map.Contains(num + length))
                {
                    length++;
                }
                longest = Math.Max(longest,length);
            }
        }

        return longest;
    }
}
