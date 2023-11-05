public class Solution
{
    public int GetWinner(int[] arr, int k)
    {
        int max = Math.Max(arr[0], arr[1]);
        for (int i = 2, j = 1; i < arr.Length; i++)
        {
            if (j == k)
            {
                return max;
            }
            if (max < arr[i])
            {
                max = arr[i];
                j = 1;
            }
            else
            {
                j++;
            }

        }

        return max;
    }
}