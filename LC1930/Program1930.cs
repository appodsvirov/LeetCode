
using System.Collections;
using static Solution;



Solution s = new Solution();
Console.WriteLine(s.CountPalindromicSubsequence("bbcbaba"));

public class Package
{
    public HashSet<int> UniqueChars { get; private set; } = new HashSet<int>();
    public int СountPalindromes { get; private set; }

    public void UpdateСountPalindromes()
    {
        СountPalindromes = UniqueChars.Count;
    }
}
public class Solution
{

    public int CountPalindromicSubsequence(string s)
    {
        Dictionary<char, Package> dict = new Dictionary<char, Package>();
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {

            if (dict.ContainsKey(s[i]))
            {
                dict[s[i]].UpdateСountPalindromes();
                foreach (var kv in dict)
                {
                    kv.Value.UniqueChars.Add(s[i]);
                }
            }
            else
            {
                foreach (var kv in dict)
                {
                    kv.Value.UniqueChars.Add(s[i]);
                }
                dict[s[i]] = new Package();
            }
        }

        foreach (Package package in dict.Values)
        {
            result += package.СountPalindromes;
        }


        return result;////---------
    }
}