using System;
using System.Collections;
using System.Collections.Generic;

Solution solution = new Solution();
Console.WriteLine(solution.RomanToInt("MCMXCIV"));

public class Solution
{
    public Dictionary<char, int> romans = new Dictionary<char, int>() 
    {
        { 'I' , 1 },
        { 'V' , 5 },
        { 'X' , 10 },
        { 'L' , 50 },
        { 'C' , 100 },
        { 'D' , 500 },
        { 'M' , 1000 }
    };
    public int RomanToInt(string s)
    {
        int result = 0;
        int pastChar = 1;
        int current;
        char c;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            c = s[i];  
            current = romans[c];

            if(pastChar > current)
            {
                result -= current; 
            }
            else
            {
                result += current;
                pastChar = current;
            }
            
        }

        return result;
    }
}