// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

public class Solution
{
    public int[] RestoreArray(int[][] adjacentPairs)
    {
        Dictionary<int, List<int>> iDsDict = new Dictionary<int, List<int>>();

        foreach (int[] ch in adjacentPairs)
        {
            if (!iDsDict.ContainsKey(ch[0]))
            {
                iDsDict[ch[0]] = new List<int>();
            }
            if (!iDsDict.ContainsKey(ch[1]))
            {
                iDsDict[ch[1]] = new List<int>();
            }
            iDsDict[ch[0]].Add(ch[1]);
            iDsDict[ch[1]].Add(ch[0]);
        }

        int start = 0;
        foreach (var ch in iDsDict)
        {
            if (ch.Value.Count == 1)
            {
                start = ch.Key;
                break;
            }
        }

        int n = adjacentPairs.Length + 1;
        int[] result = new int[n];
        result[0] = start;
        result[1] = iDsDict[start][0];

        for (int i = 2; i < n; i++)
        {
            var list = iDsDict[result[i - 1]];
            result[i] = result[i - 2] == list[0] ? list[1] : list[0];
        }

        return result;
    }
}