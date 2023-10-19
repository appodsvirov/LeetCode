Solution s = new Solution();

Console.WriteLine(s.BackspaceCompare("a#c###", "ad#c"));


public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        for (int i = s.Length - 1, j = t.Length - 1, skip = 0; ; i--, j--)
        {
            if (i < 0 && j < 0) return true;
            if (i < 0 && t[j] != '#' || j < 0 && s[i] != '#') return false;
            skipBackSpaces(s, ref skip, ref i);
            skipBackSpaces(t, ref skip, ref j);
            if (i < 0 && j < 0) return true;
            if (i < 0 || j < 0) return false;

            if (s[i] != t[j]) return false;
        }
        return true;
    }
    private static void skipBackSpaces(string str, ref int skip, ref int index)
    {
        if (index < 0) return;
        skip = 0;
        while ((index >= 0 && str[index] == '#') || (skip != 0 && index >= 0))
        {
            if (str[index] == '#')
            {
                skip++;
                index--;
            }
            else if (skip != 0)
            {
                skip--;
                index--;
            }
        }
        if (index < 0) return;
        if (str[index] == '#') skipBackSpaces(str, ref skip, ref index);
    }
}