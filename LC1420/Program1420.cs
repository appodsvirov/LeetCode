
Solution s = new Solution();

Console.WriteLine(s.NumOfArrays(2, 3, 1));
public class Solution
{
    public int NumOfArrays(int n, int m, int k)
    {
        const int mod = 1000000007;

        int[][][] dp = new int[n + 1][][];
        int[][][] prefix = new int[n + 1][][];

        for (int i = 0; i <= n; i++)
        {
            dp[i] = new int[m + 1][];
            prefix[i] = new int[m + 1][];
            for (int j = 0; j <= m; j++)
            {
                dp[i][j] = new int[k + 1];
                prefix[i][j] = new int[k + 1];
            }
        }

        for (int j = 1; j <= m; j++)
        {
            dp[1][j][1] = 1;
            prefix[1][j][1] = j;
        }

        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                for (int l = 1; l <= k; l++)
                {
                    dp[i][j][l] = (int)((1L * j * dp[i - 1][j][l]) % mod);

                    if (j > 1 && l > 1)
                    {
                        dp[i][j][l] = (dp[i][j][l] + prefix[i - 1][j - 1][l - 1]) % mod;
                    }

                    prefix[i][j][l] = (prefix[i][j - 1][l] + dp[i][j][l]) % mod;
                }
            }
        }

        return prefix[n][m][k];
    }
}