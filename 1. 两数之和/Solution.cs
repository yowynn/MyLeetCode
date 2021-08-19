public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            int t = target - nums[i];
            for (int j = i + 1; j < n; j++)
                if (t == nums[j])
                    return new int[] { i, j };
        }
        return null;
    }
}
