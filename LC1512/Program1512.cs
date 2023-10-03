using System.Collections.Generic;
using System;
using System.Collections;

Solution s = new Solution();

int[] nums = new int[] {
    1,2,3
};
Console.WriteLine(s.NumIdenticalPairs(nums));


public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        Dictionary<int, List<int>> numAndIndices = new Dictionary<int, List<int>>();
        int result = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (numAndIndices.ContainsKey(nums[i]))
            {
                foreach (int j in numAndIndices[nums[i]])
                {
                    if(i < j)
                    {
                        result++;
                    }    
                }
                numAndIndices[nums[i]].Add(i);
            }
            else
            {
                numAndIndices[nums[i]] = new List<int>() { i };
            }
        }
        return result;
    }
}