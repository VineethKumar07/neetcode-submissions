public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // for optimal space solution we can use only one array to get left multiplcation
        //for right just use a variable and update it everytime
        int[] result = new int[nums.Length];
        result[0] = 1;
        for(int i = 1; i< nums.Length ; i++)
        {
            result[i] = result[i-1] * nums[i-1];
        }
        int rightProduct = 1;
        for(int i = nums.Length - 1 ; i>=0 ; i--)
        {
            result[i] = rightProduct * result[i];
            rightProduct = rightProduct * nums[i];
        }
        return result;
    }
}
