
Solution s = new Solution();
Console.WriteLine(s.NumWays(2, 4));
public class Solution
{
    public int NumWays(int steps, int arrLen)
    {
        int mod = 1000000007;
        int m = steps + 1;
        int n = Math.Min(steps / 2 + 1, arrLen);

        int[,] dp = new int[m, n];
        dp[0, 0] = 1;

        for(int i = 1; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j] = dp[i - 1, j]; // (dp[i, j] = 0) можно остаться на том же месте

                if (j > 0) // можно пойти влево
                {
                    dp[i, j] = (dp[i, j] + dp[i - 1, j - 1]) % mod;
                }
                if (j < n - 1) // можно вправо
                {
                    dp[i, j] = (dp[i, j] + dp[i - 1, j + 1]) % mod;
                }
            }
        }
        return dp[m - 1, 0];
    }
}