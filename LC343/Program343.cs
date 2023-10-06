
Solution s = new Solution();
Console.WriteLine(s.IntegerBreak(14));

public class Solution
{
    public int IntegerBreak(int n)
    {
        if (n == 3) return 2;
        if (n % 3 == 0) return (int)Math.Pow(3, (int)(n/3));
        if(n == 2) return 1;

        bool isMoreCheckNumber = false;
        double checkNumber = 2.0 + 1.0 / 3.0;
        int k = 0;
        double tmp = 0, minTmp = int.MaxValue;
        for (int i = (n + 1) / 2; i >= n / 3; i--)
        { 
            tmp = (double)n / i;
            if (tmp >= checkNumber && tmp <= 3.0)
            {
                isMoreCheckNumber = true;
                minTmp = tmp;
                k = i;
            }
        }
        if (!isMoreCheckNumber) return (int)Math.Pow(2, (int)(n / 2));
        int b = (int)Math.Round((minTmp % 1) * k);
        return (int)(Math.Pow(3, b) * Math.Pow(2, k-b));

    }   
}