using System.Linq;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
    
    var len = nums.Length;
    if (len == 0)
        return 0;

    int k = 1;
    int prev = nums[0]; 

     for (int i = 1; i < len; i++)
    {
        if (nums[i] != prev)
        {
            nums[k] = nums[i]; 
            prev = nums[i]; 
            k++;
        }
    }

    return k;
        
    }
}