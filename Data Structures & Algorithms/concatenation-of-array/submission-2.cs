public class Solution {
    public int[] GetConcatenation(int[] nums) {       

      int[] array2 = nums;
      
      int[] ans = nums.Concat(array2).ToArray();

      return ans ;
    }
}