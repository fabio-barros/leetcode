func removeDuplicates(nums []int) int {
    length := len(nums)
    if length == 0 {
        return 0
    }

    k := 1 
    prev := nums[0]
    for i := 1; i < length; i++ {
        if nums[i] != prev {
            nums[k] = nums[i] 
            k++
        }
        prev = nums[i]
    }

    return k
    
}