Solution s = new Solution();
Console.WriteLine(s.WinnerOfGame("AAAABBBB"));
public class Solution
{
    public bool WinnerOfGame(string colors)
    {
        int countBobMove = 0, countAliceMove = 0;
        for (int i = 1; i < colors.Length - 1; i++)
        {
            if (colors[i - 1] == 'A' &&
            colors[i] == 'A' &&
            colors[i + 1] == 'A')
            {
                countAliceMove++;
            }
            else if (colors[i - 1] == 'B' &&
            colors[i] == 'B' &&
            colors[i + 1] == 'B')
            {
                countBobMove++;
            }
        }
        return (countAliceMove > countBobMove);
    }
}