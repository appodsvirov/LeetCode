// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Solution
{
    public int CountHomogenous(string s)
    {
        if (s.Length == 1) return 1;
        int add = 0, result = s.Length;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                add = (add + 1) % (1000000007);
                result = (result + add) % (1000000007);
            }
            else
            {
                add = 0;
            }
        }
        return result;
    }
}