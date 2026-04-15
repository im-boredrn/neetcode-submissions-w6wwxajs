public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        Dictionary<int,int>list = new Dictionary<int,int>();

        for (int i = 0; i <nums.Length; i++)
        {
            int current = nums[i];

            if (list.TryGetValue(current, out var stored))
            {

                return true;
            }

            list[current] = i;

        }
        return false;
    }
}