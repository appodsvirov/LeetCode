Solution s = new Solution();
Console.WriteLine(string.Join(", ", s.CountBits(16)));

public class Solution
{
    public int[] CountBits(int n)
    {
        int[] result = new int[n + 1];
        result[0] = 0;
        result[1] = 1;
        for (int i = 2, j = 2; i <= n; i++)
        {
            if (i >= (j<<1))
            {
                j <<= 1;
                result[i] = 1;
            }
            else
                result[i] = 1 + result[i - j];
        }
        return result;
    }
}