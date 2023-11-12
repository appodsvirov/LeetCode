public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target) return 0; // мы на месте

        //graph содержит пыры= key: номер остановки, value: List автобусов, которые проходят через данную остановку
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        for (int i = 0; i < routes.Length; i++)
        {
            foreach (int v in routes[i])
            {
                if (!graph.ContainsKey(v))
                {
                    graph[v] = new List<int>();
                }
                graph[v].Add(i);
            }
        }

        Queue<int> queue = new Queue<int>();
        HashSet<int> logStops = new HashSet<int>(); // уже посещенные остановки
        HashSet<int> logBuses = new HashSet<int>(); // уже посещенные автобусы

        queue.Enqueue(source);
        logStops.Add(source);

        int result = 0;

        while (queue.Count > 0)
        {
            int stopsAtThisLevel = queue.Count;

            for (int i = 0; i < stopsAtThisLevel; i++)
            {
                int currentStop = queue.Dequeue();

                List<int> busesAtStop = (graph.ContainsKey(currentStop)) ? graph[currentStop] : new List<int>();

                foreach (int bus in busesAtStop)
                {
                    if (logBuses.Contains(bus)) // уже катались на нем
                    {
                        continue; 
                    }

                    logBuses.Add(bus); 

                    foreach (int nextStop in routes[bus]) // обход в ширину
                    {
                        if (logStops.Contains(nextStop))// уже были на этой остановке
                        {
                            continue;
                        }

                        logStops.Add(nextStop);

                        if (nextStop == target) return result + 1;

                        queue.Enqueue(nextStop);
                    }
                }
            }

            result++;
        }

        return -1;
    }
}