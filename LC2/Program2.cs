

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = null, currentList = new ListNode();
        bool add = false;
        while (true)
        {
            if (add)
            {
                currentList.val += 1;
                add = false;
            }
            if (l1 != null)
            {
                currentList.val += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                currentList.val += l2.val;
                l2 = l2.next;
            }
            if(currentList.val >= 10)
            {
                currentList.val -= 10;
                add = true;
            }
            if(l1 != null || l2 != null)
            {
                currentList = new ListNode(0, currentList);
            }
            else
            {
                if(add) currentList = new ListNode(1, currentList);
                break;
            }

        }

        while (currentList != null)
        {
            result = new ListNode(currentList.val, result);
            currentList = currentList.next;
        }

        return result;
    }
}