
Solution s = new Solution();


Console.WriteLine(string.Join(" ", s.LargestValues(
    new TreeNode(-12, null, new TreeNode(85, new TreeNode(57)))




    )));


// Definition for a binary tree node.
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
    public IList<int> LargestValues(TreeNode root)
    {
        if (root == null || root.val == null) return new List<int>();
        List<int> result = new List<int>(){root.val};
        Traversal(root, 0, result);
        
        return result;
    }

    private void Traversal(TreeNode treeNode, int depth, List<int> result)
    {
        if (treeNode == null || treeNode.val == null) return;
        if (result.Count - 1 < depth)
        {
            result.Add(treeNode.val);
        }
        else
        {
            result[depth] = Math.Max(result[depth], treeNode.val);

        }
        if (treeNode.left != null)
        {
            Traversal(treeNode.left, depth + 1, result);
        }

        if (treeNode.right != null)
        {
            Traversal(treeNode.right, depth + 1, result);
        }
    }
}