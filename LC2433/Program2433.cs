

Solution s = new Solution();
Console.WriteLine(string.Join(" ", s.FindArray(new int[] { 13}) ));

public class Solution
{

    public int[] FindArray(int[] pref)
    {
        if (pref is null && pref?.Length == 0)
        {
            return new int[0];
        }
        int[] result = new int[pref.Length];
        
        int last = result[0] = pref[0];
        for (int i = 1; i < pref.Length; i++)
        {
            result[i] = last^pref[i];
            last ^= result[i];
        }

        return result;
    }
}