public class Solution
{
    public int MinPairSum(int[] nums)
    {
        Array.Sort(nums);
        int result = int.MinValue;
        for (int i = 0, j = nums.Length - 1; i < j; i++, j--)
        {
            int sub = nums[j] + nums[i];
            if (sub > result)
            {
                result = sub;
            }
        }
        return result;
    }
}