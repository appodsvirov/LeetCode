using System;
using System.Collections;
using System.Collections.Generic;

Solution s = new Solution();
Console.WriteLine(string.Join(" ",s.TwoSum(new int[] {2, 7, 11, 15 }, 9)));

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int value;

            if (dict.TryGetValue(nums[i], out value))
            {
                result[0] = i;
                result[1] = value;
                return result;
            }
            dict.TryAdd(target - nums[i], i);
        }
        throw new System.Exception();
    }
}