

///*
/// [1,18,153,816,3060,8568,18564,31824,43758,1276,43758,31824,18564,8568,3060,816,153,18,1]
/// [1,18,153,816,3060,8568,18564,31824,43758,48620,43758,31824,18564,8568,3060,816,153,18,1]
///


Solution s = new Solution();
Console.WriteLine(string.Join(", ", s.GetRow(18)));



public class Solution
{
    private static Dictionary<(int, int), long> memo = new Dictionary<(int, int), long>();
    private static long Factorial(int n, int k = 1)
    {
        if (n < 0) throw new ArgumentException("Error: n < 0");

        if (n == 0 || n == 1) return 1;

        if (n == k) return 1;

        if (memo.ContainsKey((n, k)))
            return memo[(n, k)];

        checked
        {
            long result = n * Factorial(n - 1, k);
            memo[(n, k)] = result;

            return result;
        }

    }

    private static int Combination(int n, int k)
    {
        int max, min, sub = n - k;
        if (sub > k)
        {
            max = sub;
            min = k;
        }
        else
        {
            max = k;
            min = sub;
        }


        return (int)(Factorial(n, max) / Factorial(min));

    }

    public IList<int> GetRow(int rowIndex)
    {
        List<int> result = new List<int>();
        int middle;
        middle = rowIndex / 2;
        for (int i = 0; i <= middle; i++)
        {
            if (i == 8)
                Console.WriteLine(8);
            result.Add(Combination(rowIndex, i));
        }
        if (rowIndex % 2 == 0)
        {
            for (int i = middle - 1; i >= 0; i--)
            {
                result.Add(result[i]);
            }
        }
        else
        {
            for (int i = middle; i >= 0; i--)
            {
                result.Add(result[i]);
            }
        }
        return result;
    }
}