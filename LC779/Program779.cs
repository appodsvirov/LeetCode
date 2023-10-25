

Solution s = new Solution();
Console.WriteLine(s.KthGrammar(30, 15));
public class Solution
{
    public int KthGrammar(int n, int k)
    {
        if (n == 1) return 0;
        int half = 1 << (n - 2);
        if (k <= half) // если k в 1 половине, то n[k-1] == (n-1)[k]
        {
            return KthGrammar(n - 1, k);
        }
        else // если k в 2 половине, то (n-1)[k] имеет противопложный знак: n[k-1] == 1 - (n-1)[k]
        {
            return (1 - KthGrammar(n - 1, k - half));
        }
    }
}