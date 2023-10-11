Solution s = new Solution();

Console.WriteLine(string.Join(", ",
    s.FullBloomFlowers(
        new int[][] { new int[] { 1, 10 }, new int[] { 3, 3 }},
        new int[] { 3, 3, 2}
        )));
public class Solution
{
    public int[] FullBloomFlowers(int[][] flowers, int[] people)
    {
        int first, last, index, temp, sum = 0;
        var timesOfPeople = new int[people.Length];
        var memo = new Dictionary<int, int>();
        foreach (int[] time in flowers)
        {
            memo.TryAdd(time[0], 0);
            memo[time[0]] ++;

            memo.TryAdd(time[1] + 1, 0);
            memo[time[1] + 1] --;
        }

        int[] keys = memo.Keys.ToArray();
        Array.Sort(keys);
        foreach (int key in keys)
        {
            memo[key] += sum;
            sum = memo[key];
        }

        for (int i = 0; i < people.Length; ++i)
        {

            first = 0;
            last = keys.Count() - 1;
            index = -1;

            while (first <= last)
            {
                temp = first + (last - first) / 2;

                if (keys[temp] <= people[i])
                {
                    index = keys[temp];
                    first = temp + 1;
                }
                else
                {
                    last = temp - 1;
                }
            }

            timesOfPeople[i] = (index == -1)? 0 : memo[index];
        }

        return timesOfPeople;
    }
    private int BinarySearch(int[] people, int target, int first, int last) //O(people.Length log people.Length)
    {
        if (first > last) return -1;

        int middleIndex = (last + first) / 2;
        int middleValue = people[middleIndex];

        if (middleValue == target) return middleIndex;

        if (middleValue > target)
        {
            return BinarySearch(people, target, first, middleIndex - 1);
        }
        else
        {
            return BinarySearch(people, target, middleIndex + 1, last);
        }

    }
}