public class Solution {
    public int[] TwoSum(int[] nums, int target) {


        Dictionary<int,int>storage = new ();

        for (int i = 0; i < nums.Length; i++)
        {

            int current = nums[i];
            int needed = target - current;

            if (storage.TryGetValue(needed, out var slot))
            {
                return new int[] {slot,i};
            }

            storage[current] = i;

        }

        return null;

    }
}
