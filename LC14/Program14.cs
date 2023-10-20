
using System.Text;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        StringBuilder result = new StringBuilder();
        int minLength = int.MaxValue;
        foreach (string str in strs)
        {
            minLength = Math.Min(minLength, str.Length);
        }
        bool check;
        for (int i = 0; i < minLength; i++)
        {
            check = true;
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j - 1][i] != strs[j][i])
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                result.Append(strs[0][i]);
            }
            else
            {
                break;
            }
        }
        return result.ToString();
    }
}