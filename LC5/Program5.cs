using System.Text;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        if(s is null && s?.Length == 0)
        {
            return "";
        }
        // ^#[0]#[1]#[2]#[3]#[4]#[5]#...[n-3]#[n-2]#[n-1]#$
        StringBuilder metaS = new StringBuilder("^#");
        foreach (char c in s)
        {
            metaS.Append(c).Append("#");
        }
        metaS.Append("$");
        string modifiedString = metaS.ToString();

        int strLength = modifiedString.Length;
        int[] palindromeLengths = new int[strLength];
        int center = 0;  
        int rightEdge = 0;  

        for (int i = 1; i < strLength - 1; i++)
        {
            palindromeLengths[i] = (rightEdge > i) ? Math.Min(rightEdge - i, palindromeLengths[2 * center - i]) : 0;

            while (modifiedString[i + 1 + palindromeLengths[i]] == modifiedString[i - 1 - palindromeLengths[i]])
            {
                palindromeLengths[i]++;
            }

            if (i + palindromeLengths[i] > rightEdge)
            {
                center = i;
                rightEdge = i + palindromeLengths[i];
            }
        }
        int maxLength = 0;
        int maxCenter = 0;
        for (int i = 0; i < strLength; i++)
        {
            if (palindromeLengths[i] > maxLength)
            {
                maxLength = palindromeLengths[i];
                maxCenter = i;
            }
        }
        int start = (maxCenter - maxLength) / 2;
        int end = start + maxLength;

        return s.Substring(start, end - start);
    }
}