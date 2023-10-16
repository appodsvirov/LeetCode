public class Solution
{

    public IList<int> GetRow(int rowIndex)
    {
        List<int> result = new List<int>() { 1 };
        long last = 1, tmp;
        for (int i = 1; i <= rowIndex; i++)
        {
            tmp = last * (rowIndex - i + 1) / i;
            result.Add((int)tmp);
            last = tmp;
        }
        return result;
    }
}