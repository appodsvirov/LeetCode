

Solution solution = new Solution();

int[] ints = new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
Console.WriteLine(string.Join(" ", ints));
Console.WriteLine(string.Join(" ", solution.SortByBits(ints)));


public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        int[] result = new int[arr.Length];

        for(int i = 1;  i <= 10000; i <<= 1)
        {
            for(int j = 0; j < arr.Length; j++)
            {
                if( (i & arr[j]) != 0)
                {
                    result[j]++;
                }
            }
        }
        var pairs = result.Zip(arr, (r, a) => new { Result = r, Value = a });
        var sortedPairs = pairs.OrderBy(p => p.Result).ThenBy(p => p.Value);
        result = sortedPairs.Select(p => p.Result).ToArray();
        arr = sortedPairs.Select(p => p.Value).ToArray();

        return arr;

    }
}