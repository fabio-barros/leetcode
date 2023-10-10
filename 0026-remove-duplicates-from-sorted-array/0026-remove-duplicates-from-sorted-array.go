func removeDuplicates(nums []int) int {

    k := 1 
    prev := nums[0]
    for i := 1; i < len(nums); i++ {
        if nums[i] != prev {
            if i != k {
                nums[k] = nums[i]
            }
            k++
            prev = nums[i]
        }
    }

    return k
    
}