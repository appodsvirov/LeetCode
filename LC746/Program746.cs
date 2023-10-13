﻿public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] dp = new int[cost.Length];
        dp[cost.Length - 1] = cost[cost.Length - 1];
        dp[cost.Length - 2] = cost[cost.Length - 2];
        for (int i = cost.Length - 3; i >= 0; i--)
        {
            dp[i] = cost[i] + Math.Min(dp[i + 1], dp[i + 2]);
        }
        return Math.Min(dp[0], dp[1]);
    }
}