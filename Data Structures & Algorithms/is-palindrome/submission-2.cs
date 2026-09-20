public class Solution {
    public bool IsPalindrome(string s) {
        //optimal solution is using two pointers where left pointer traverse from left and right from right
        //and we check each letter or digit if we find
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            //Here we are skipping the inmvalid characters until we find a letter ot digit
            while(left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while(left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if(char.ToLower(s[left])!=char.ToLower(s[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;  
    }
}
