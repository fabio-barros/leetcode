using System.Linq;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
    
    var len = nums.Length;
    if (len == 0)
        return 0;

    int k = 1;
    int prev = nums[0]; 
    int a;
     for (int i = 1; i < len; i++)
    {
        a = nums[i];
        if (a != prev)
        {
            nums[k] = a; 
            prev = a; 
            k++;
        }
    }

    return k;
        
    }
}