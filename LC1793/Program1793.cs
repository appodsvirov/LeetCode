// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Solution
{
    public int MaximumScore(int[] nums, int k)
    {
        int left = k, right = k; // старт из k
        int minValue = nums[k], result = nums[k];
        while (left > 0 || right < nums.Length - 1)
        {
            // сначала k, а потом
            // k, (k+1) или  (k-1), k в зависимости от Max(k-1, k+1)
            // и так далее.. 
            if (left == 0 || (right < nums.Length - 1 && nums[right + 1] > nums[left - 1]))
            {
                right++;
                // Ранее мы посчитали minValue для предыдущией subArray, а сейчас считаем для новой
                minValue = Math.Min(minValue, nums[right]);
            }
            else
            {
                left--;
                minValue = Math.Min(minValue, nums[left]);
            }
            // для subArray = {nums[k]}: result = k*(k-k+1) = k
            result = Math.Max(result, minValue * (right - left + 1));
        }

        return result;
    }
}