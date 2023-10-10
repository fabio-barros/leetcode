using System.Linq;

public class Solution {
    public int RemoveDuplicates(int[] nums) {

    if (nums.Length == 0)
        return 0;

    int k = 1;
    int prev = nums[0]; 

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != prev)
        {
            nums[k++] = nums[i]; 
            prev = nums[i]; 

        }
    }

    return k;
        
    }
}