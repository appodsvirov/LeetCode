
Solution s = new Solution();
Console.WriteLine(s.MaximumElementAfterDecrementingAndRearranging(new int[] { 2, 2, 1, 2, 1 }));
public class Solution
{
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        //return arr.OrderBy(x => x).Aggregate(1, (a, b) => b - a <= 1 ? b : a + 1);
        Array.Sort(arr);
        arr[0] = 1;
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i-1])
            {
                arr[i] = arr[i-1] + 1;
            }
        }
        return arr[arr.Length-1];
    }
}