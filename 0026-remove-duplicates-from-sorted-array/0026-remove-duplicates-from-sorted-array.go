func removeDuplicates(nums []int) int {
    length := len(nums)
    if length == 0 {
        return 0
    }

    k := 1 

    for i := 1; i < length; i++ {
        if nums[i] != nums[i-1] {
            nums[k] = nums[i] 
            k++
        }
    }

    return k
    
}