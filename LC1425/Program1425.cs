// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Solution
{
    public int ConstrainedSubsetSum(int[] nums, int k)
    {
        LinkedList<int> dq = new LinkedList<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dq.Count > 0)
            {
                nums[i] += nums[dq.First.Value];
            }
            while (dq.Count > 0 &&
                (i - dq.First.Value >= k || nums[i] >= nums[dq.Last.Value]))
            {
                if (nums[i] >= nums[dq.Last.Value])
                {
                    dq.RemoveLast();
                }
                else
                {
                    dq.RemoveFirst();
                }
            }

            if (nums[i] > 0)
            {
                dq.AddLast(i);
            }
        }
        return nums.Max(); // (O(n))
    }
}