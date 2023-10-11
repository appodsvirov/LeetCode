Solution s = new Solution();
Console.WriteLine(s.MinOperations(new int[] {1, 10, 100, 1000 }));
public class Solution
{
    public int MinOperations(int[] nums)
    {
        var uniqueNums = nums.ToHashSet().ToArray();
        Array.Sort(uniqueNums);
        int k = 0, tmp = 0, result = nums.Length;
        for (int i = 0; i < uniqueNums.Length; i++)
        {
            for (; (k < uniqueNums.Length) &&
             (uniqueNums[k] - uniqueNums[i] < nums.Length); k++) ;

            tmp = nums.Length - k + i;
            result = (result < tmp) ? result : tmp;
        }
        return result;
    }
}