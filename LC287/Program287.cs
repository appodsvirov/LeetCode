
public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        int[] greedyDict = new int[200000];
        foreach (int num in nums)
        {
            if (greedyDict[num] != 0)
            {
                return num;
            }
            else
            {
                greedyDict[num]++;
            }
        }
        throw new Exception();
    }
}