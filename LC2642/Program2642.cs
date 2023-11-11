
public class Graph
{
    private List<List<(int, int)>> graph = new List<List<(int, int)>>();

    public Graph(int n, int[][] edges)
    {
        for (int i = 0; i < n; i++)
        {
            graph.Add(new List<(int, int)>());
        }

        foreach(var edge in edges)
        {
            AddEdge(edge);
        }
    }

    public void AddEdge(int[] edge)
    {
        graph[edge[0]].Add((edge[1], edge[2]));
    }

    public int ShortestPath(int node1, int node2)
    {
        //Алгоритм Дейкстры
        int n = graph.Count;

        var pq = new PriorityQueue<List<int>, List<int>>(
            Comparer<List<int>>.Create((a, b) => a[0].CompareTo(b[0])));

        //Инициализация: метка oo для всех node1 элементов, для node 1 метка = 0 
        int[] labels = Enumerable.Repeat(int.MaxValue, n).ToArray();
        labels[node1] = 0;


        int lab, vertex;
        var root = new List<int>() { 0, node1 };
        pq.Enqueue(root, root);

        while (pq.Count > 0) //Если все вершины посещены, алгоритм завершается. 
        {
            var curr = pq.Dequeue();
            lab = curr[0];
            vertex = curr[1];
            //Если полученное значение длины меньше значения метки соседа, заменим значение метки полученным значением длины.
            if (lab > labels[vertex])
            {
                continue;
            }
            if (vertex == node2)
            {
                return lab; //Доп. остновка: Алгоритм Дейкстры находит кратчайшие пути от node1 до ВСЕХ вершин. А нам надо найти только до node2
            }
            foreach (var node in graph[vertex]) //выбирается вершина u, имеющая минимальную метку.
            {
                int neighborNode = node.Item1;
                int cost = node.Item2;
                int newCost = lab + cost;
                //Если полученное значение длины меньше значения метки соседа, заменим значение метки полученным значением длины.
                if (newCost < labels[neighborNode])
                {
                    labels[neighborNode] = newCost;
                    var newPath = new List<int>() { newCost, neighborNode };
                    pq.Enqueue(newPath, newPath);
                }
            }
        }
        return -1;
    }
}