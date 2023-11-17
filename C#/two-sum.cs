// https://leetcode.com/problems/two-sum/ Completed
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){            
            
            for(int j=0;j<nums.Length;j++){
                
                if(i!=j && nums[i]+nums[j]==target){
                    int[] output = {i,j};
                    return output;
                }
            }
        }
        return null;
    }
}