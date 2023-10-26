
public class Solution
{
    public int NumFactoredBinaryTrees(int[] arr)
    {
        int mod = 1000000007;
        int result = 0;
        Array.Sort(arr);
        Dictionary<int, long> dp = arr.ToDictionary(x => x, x => 1L); // ключ -- узел, значение -- кол-во дереьвев 
        HashSet<int> arrSet = new HashSet<int>(arr);
        int div;
        long mult;
        foreach (int first in arr)
        {
            foreach (int second in arr)
            {
                if (second*second > first)
                {
                    break;
                }

                div = first / second;

                if (first % second == 0 && arrSet.Contains(div))
                {
                    mult = dp[second] * dp[div];
                    dp[first] = (dp[first] + ((div == second) ? mult : 2 * mult)) % mod;
                }
            }
        }

        foreach (int count in dp.Values)
        {
            result = (result + count) % mod;
        }
        return result;
    }
}