﻿using System.Collections.Generic;
using System.Text;

Solution s = new Solution();
Console.WriteLine(s.LengthOfLongestSubstring("abcabcbb"));
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0, tmpLength = 0, first = 0 ;
        char c;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            c = s[i];
            if (dict.ContainsKey(c))
            {
                if (dict[c] < first)
                {
                    dict[c] = i;
                    tmpLength++;

                    if (tmpLength > maxLength)
                    {
                        maxLength = tmpLength;
                    }
                }
                else
                {
                    first = dict[c] + 1;
                    tmpLength = i - dict[c];
                    dict[c] = i;
                }
            }
            else
            {
                dict[c] = i;
                tmpLength++;

                if (tmpLength > maxLength)
                {
                    maxLength = tmpLength;
                }
            }

        }
        return maxLength;
    }
}