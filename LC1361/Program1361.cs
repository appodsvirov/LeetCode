Solution s = new Solution();
Console.WriteLine(s.ValidateBinaryTreeNodes(4, 
    new int[]{ 1, 0, 3, -1 }, 
    new int[]{ -1, -1, -1, -1 }));
public class Solution
{
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        int[] treeNodes = Enumerable.Repeat(-1, n).ToArray();
        // индекс - номер узла, а сооттветсвующее значение - индекс родителя =>
        // в конце только у 1 узла не будет родителя, у остальных по 1
        // + надо проверить массив на наличие циклов (a)->(b)->(c)->(a)
        int sum = -n; // изначально treeNodes заполнен -1, их сумма -n
        // при нахождении родителя, во первых, будет проверяться, что родитель один, а во-вторых, sum += 1
        // если это действительно бинарное дерево, то в конце sum == -1
        for (int i = 0; i < n;  i++) // i - номер рассматриваемого родителя
        {

            if (leftChild[i] != -1)
            {
                if (treeNodes[leftChild[i]] != -1) return false;
                sum++;
                treeNodes[leftChild[i]] = i;
            }
            if (rightChild[i] != -1)
            {
                if (treeNodes[rightChild[i]] != -1) return false;
                sum++;
                treeNodes[rightChild[i]] = i;
            }
        }
        if (sum != -1) return false; // только у 1 узла нет родителя
        bool[] scan = new bool[n];
        int len = 0;
        for (int i = 0; i < n; i++) // ищем циклы
        {
            if (searchСycles(treeNodes, scan, i, len, ref n) == false)
                return false;
        }
        return true;
    }
    private bool searchСycles(int[] treeNodes, bool[] scan, int index, int len, ref  int max)
    {
        if (scan[index] == true) return true;
        if (treeNodes[index] == -1)
        {
            scan[index] = true;
            return true;
        }
        if (len >= max) return false;
        bool result = searchСycles(treeNodes, scan, treeNodes[index], len+1, ref max);
        if (result) scan[index] = true;
        return result;
    }
}