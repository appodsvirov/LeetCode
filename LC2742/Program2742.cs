Solution s = new Solution();
Console.WriteLine(s.PaintWalls(new int[] { 1, 2, 3, 2 }, new int[] { 1, 2, 3, 2     }));
public class Solution
{
    public int PaintWalls(int[] cost, int[] time)
    {
        int n = cost.Length;
        int[] dp = Enumerable.Repeat(int.MaxValue - 1, n+1).ToArray();
        dp[0] = 0;
        for (int i = 0; i < n; ++i)
        {
            for (int j = n; j > 0; --j)
            {
                dp[j] = Math.Min(dp[j], dp[Math.Max(j - time[i] - 1, 0)] + cost[i]);
            }
        }
        return dp[n];
    }
}