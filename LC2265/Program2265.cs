

Solution s = new Solution();
Console.WriteLine(s.AverageOfSubtree(new TreeNode(4, new TreeNode(8, new TreeNode(0), new TreeNode(1)), new TreeNode(5, null, new TreeNode(6)))));

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int AverageOfSubtree(TreeNode root)
    {
        int result = 0, count = 1, total = 0;
        GetAverageOfSubtree(root, ref result, ref total, ref count);
        return result;
    }


    public static void GetAverageOfSubtree(TreeNode root, ref int result, ref int total, ref int count)
    {


        int currentCount = count, currentTotal = total;
        count++;
        total += root.val;

        // лист? => вне завимости от root.val result++;
        if (root.left is null && root.right is null)
        {
            result++;
            return;
        }
        if (root.left is not null)
        {
            GetAverageOfSubtree(root.left, ref result, ref total, ref count);
        }
        if (root.right is not null)
        {
            GetAverageOfSubtree(root.right, ref result, ref total, ref count);
        }

        int tmp = (int)Math.Round((decimal)((total - currentTotal) / (count - currentCount)));
        if (tmp == root.val)
        {
            result++;
        }

    }
}