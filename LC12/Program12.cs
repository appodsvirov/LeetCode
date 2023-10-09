using System.Text;

public class Solution
{
    public string IntToRoman(int num)
    {
        StringBuilder result = new StringBuilder();

        while(num != 0)
        {
            if (num >= 1000 )
            {
                num -= 1000;
                result.Append("M");
            }
            else if (num >= 900)
            {
                num -= 900;
                result.Append("CM");
            }
            else if (num >= 500)
            {
                num -= 500;
                result.Append("D");
            }
            else if (num >= 400)
            {
                num -= 400;
                result.Append("CD");
            }
            else if (num >= 100)
            {
                num -= 100;
                result.Append("C");
            }
            else if (num >= 90)
            {
                num -= 90;
                result.Append("XC");
            }
            else if (num >= 50)
            {
                num -= 50;
                result.Append("L");
            }
            else if (num >= 40)
            {
                num -= 40;
                result.Append("XL");
            }
            else if (num >= 10)
            {
                num -= 10;
                result.Append("X");
            }
            else if (num >= 9)
            {
                num -= 9;
                result.Append("IX");
            }
            else if (num >= 5)
            {
                num -= 5;
                result.Append("V");
            }
            else if (num >= 4)
            {
                num -= 4;
                result.Append("IV");
            }
            else if (num >= 1)
            {
                num -= 1;
                result.Append("I");
            }
        }


        return result.ToString();
    }
}