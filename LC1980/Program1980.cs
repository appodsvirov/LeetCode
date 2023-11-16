// See https://aka.ms/new-console-template for more information


using System.Text;

Solution s = new Solution(); 

Console.WriteLine(s.FindDifferentBinaryString(new string[] { "111", "011", "001" }));
public class Solution
{
    public string FindDifferentBinaryString(string[] nums)
    {
        int n = nums[0].Length;
        int capcity = (1 << n);

        for (int i = 1; i < capcity; i++)
        {
            bool isEquale = true;
            string tmp = IntToString(i, capcity);
            foreach (string str in nums)
            {
                if (tmp == str)
                {
                    isEquale = false;
                    break;
                }
            }
            if (isEquale)
            {
                return tmp;
            }

        }
        return string.Join("", Enumerable.Repeat('0', n).ToArray());
    }

    public string IntToString(int num, int capcity)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 1; i < capcity; i <<= 1)
        {
            if ((num & i) != 0)
            {
                result.Append('1');
            }
            else
            {
                result.Append('0');
            }
        }
        return string.Join("",result.ToString().Reverse());
    }
}
