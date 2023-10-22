// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Solution
{
    public int ConstrainedSubsetSum(int[] nums, int k)
    {
        /*
         * дек будет хранить окно индексов
         **/
        LinkedList<int> dq = new LinkedList<int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (dq.Count > 0)
            {
                nums[i] += nums[dq.First.Value];
            }
            // уменьшаем окно, пока условие с k не выполнится
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
            // отицательные нет смысла добавлять, т.к. если в nums нет других, то в конце nums.Max() выберет 1 число 
            if (nums[i] > 0) 
            {
                dq.AddLast(i);
            }
        }
        return nums.Max(); // (O(n))
    }
}