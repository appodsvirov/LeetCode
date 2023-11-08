
public class Solution
{
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
    {
        int dist = Math.Max(Math.Abs(fx - sx), Math.Abs(fy - sy));
        if (dist == 0 && (t == 0 || t == 2)) return true;
        if (dist == 0 && t == 1) return false;
        return dist <= t;
    }
}
