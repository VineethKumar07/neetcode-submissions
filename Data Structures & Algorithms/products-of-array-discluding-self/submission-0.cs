public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //Main logic is create two array which has product of left elements and right elements 
        //Then get the product of left[i] and right[i]
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        int[] result = new int[nums.Length];

        left[0] = 1;
        right[nums.Length-1] = 1 ;

        int i = 0;

        //for getting left array multiplications
        for(i = 1; i < nums.Length ; i++)
        {
            left[i] = left[i-1] * nums[i-1];
        }

        for(i = nums.Length - 2 ; i >= 0; i --)
        {
            right[i] = right[i+1] * nums[i+1];
        }

        for(i = 0 ; i< nums.Length ; i++)
        {
            result[i] = left[i]*right[i];
        }

        return result;
    }
}
