// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Solution
{
    long G { get { return G; } set { G = value; } }
    public int MinimumTime(int n, int[][] relations, int[] time)
    {
        List<List<int>> graph = new List<List<int>>();
        for (int i = 0; i < n; i++)
            graph.Add(new List<int>());


        foreach (int[] keyValue in relations)
        {
            int prev = keyValue[0] - 1;
            int next = keyValue[1] - 1;
            graph[next].Add(prev);
        }

        int[] memo = new int[n];
        int minTime = 0;

        for (int course = 0; course < n; course++)
        {
            minTime = Math.Max(minTime, Time(course, graph, time, memo));
        }

        return minTime;
    }

    private int Time(int course, List<List<int>> graph, int[] time, int[] memo)
    {
        if (memo[course] != 0)
        {
            return memo[course];
        }

        int maxPrerequisiteTime = 0;
        foreach (int prereq in graph[course])
        {
            maxPrerequisiteTime = Math.Max(maxPrerequisiteTime, Time(prereq, graph, time, memo));
        }

        memo[course] = maxPrerequisiteTime + time[course];
        return memo[course];
    }
}