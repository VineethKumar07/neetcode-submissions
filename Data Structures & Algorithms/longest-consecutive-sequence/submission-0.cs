public class Solution {
    public int LongestConsecutive(int[] nums) {
        //when array is given in args hashset has that nums
        HashSet<int> map = new HashSet<int>(nums);
        int longest = 0;

        foreach(int num in nums)
        {
            if(!map.Contains(num-1))
            {
                int current = num;
                int length = 0 ;
                while(map.Contains(current))
                {
                    current++;
                    length++;
                }
                longest = Math.Max(longest,length);
            }
        }

        return longest;
    }
}
