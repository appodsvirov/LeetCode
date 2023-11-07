Solution s = new Solution();

Console.WriteLine(s.EliminateMaximum(
    new int[] { 1, 1, 2, 3 },
    new int[] {1,1,1,1}
    
    ));

public class Solution
{
    public int EliminateMaximum(int[] dist, int[] speed)
    {
        double[] times = dist.Zip(speed, (a, b) => (double) a / b).OrderBy(c => c).ToArray();
        int result = 1;

        double past = times[0];
        for(int i = 1; i < times.Length; past = times[i], i++)
        {
            if (Math.Abs(times[i] - past - 1) < double.Epsilon || times[i] > i)
            {
                result++;
            }
            else
            {
                break;
            }
        }

        return result;
    }
}