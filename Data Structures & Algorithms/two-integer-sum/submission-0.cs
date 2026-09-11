public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // Loop through pairs until target is reached

        for (int i = 0; i < nums.Count(); i++){

            for (int j = i+1; j < nums.Count(); j++){

                int total = nums[i] + nums[j];

               if (total == target){
                    return new int[] { i, j };
                }
            }
        }

        return [];
    }
}
