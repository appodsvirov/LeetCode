Solution s = new Solution();

Console.WriteLine(s.PoorPigs(4, 29, 15));
public class Solution
{
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
    {
        int result = 0;
        int div = (minutesToTest / minutesToDie) + 1;
        for (; Math.Pow(div, result) < buckets; result++) ;
        return result;
    }
}