
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x == 0) return true;

        int[] arrX = new int[50];
        int first = 0;
        int second = 0;
        for (int i = 0; x != 0; x /= 10, i++)
        {
            second = i;
            arrX[i] = x % 10;
        }
        while (true)
        {
            if (first >= second) return true;
            if (arrX[first] != arrX[second]) return false;
            first++;
            second--;
        }
        return false;
    }
}