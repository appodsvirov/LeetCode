Solution s = new Solution();

Console.WriteLine(string.Join(" ", s.BuildArray(new int[] {1,2, 3 }, 3)));

public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        List<string> result = new List<string>();
        for (int i = 0, j = 1; i < target.Length; i++)
        {
            while (target[i] > j)
            {
                j = (j + 1) % (n+1);
                result.Add("Push");
                result.Add("Pop");
            }
            result.Add("Push");
            j = (j + 1) % (n + 1);
        }
        return result;
    }
}