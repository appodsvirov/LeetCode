// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




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
    private int? currentVal = null, currentCount = 0, max = 0;
    private System.Collections.Generic.List<int> modes = new System.Collections.Generic.List<int>();

    public int[] FindMode(TreeNode root)
    {
        GetModes(root);
        return modes.ToArray();
    }

    private void GetModes(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        GetModes(node.left);

        currentCount = (node.val == currentVal) ? currentCount + 1 : 1;

        if (currentCount > max)
        {
            max = currentCount;
            modes.Clear();
            modes.Add(node.val);
        }
        else if (currentCount == max)
        {
            modes.Add(node.val);
        }
            
            
        currentVal = node.val;

        GetModes(node.right);
    }
}