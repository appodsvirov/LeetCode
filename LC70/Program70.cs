public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        int past = 2, pastPast = 1, current = 2;

        for (int i = 3; i <= n; i++, pastPast = past, past = current)
        {
            current = past + pastPast;
        }
        return current;
    }
}