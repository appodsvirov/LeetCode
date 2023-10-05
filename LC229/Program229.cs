Solution s = new Solution();
Console.WriteLine(string.Join(" ", s.MajorityElement(new int[] { 1, 2})));

public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        Dictionary<int, int> numsAndCount = new Dictionary<int, int>();
       List<int> list = new List<int>();
        if (nums.Length == 1 || (nums.Length == 2 && nums[0] == nums[1]))
        {
            list.Add(nums[0]);
            return list;
        }
        if (nums.Length == 2)
        {
            list.Add(nums[0]);
            list.Add(nums[1]);
            return list;
        }
        int current;
        int countAppear = (nums.Length / 3);

        for (int i = 0; i < nums.Length; i++)
        {
            current = nums[i];

            if (numsAndCount.ContainsKey(current))
            {
                numsAndCount[current]++;
                if (numsAndCount[current] == countAppear + 1)
                {
                    list.Add(current);
                }
            }
            else
            {
                numsAndCount[current] = 1;
            }


        }
        return list;
    }
}