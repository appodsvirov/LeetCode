
public class Solution
{
    public int GetLastMoment(int n, int[] left, int[] right)
    {
        return Math.Max((left.Length > 0) ? left.Max() : int.MinValue, (right.Length > 0) ? n - right.Min() : int.MinValue);
    }
}