

Solution s = new Solution();
Console.WriteLine(s.KthGrammar(30, 15));
public class Solution
{
    public int KthGrammar(int n, int k)
    {
        if (n == 1) return 0;
        int[] dp = new int[(int)Math.Pow(2, n-1)];
        dp[1] = 1;
        for (int i = 1; i < n - 1; i++)
        {
            int half = 1 << (i - 1);
            for (int j = 1 << i; j <= (1 << (i + 1)) - 1; j++, half++)
            {
                if (dp[half] == 0)
                {
                    dp[j++] = 0;
                    dp[j] = 1;
                }
                else if (dp[half] == 1)
                {
                    dp[j++] = 1;
                    dp[j] = 0;
                }
            }
        }

        Console.WriteLine(string.Join(" ", dp));
        return dp[k - 1];
    }
}