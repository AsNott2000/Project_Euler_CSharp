namespace Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
     

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode ptr = result;

            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int sum = 0 + carry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                carry = sum / 10;
                sum = sum %10;
                ptr.next = new ListNode(sum);
                ptr = ptr.next;
            }
            if (carry == 1)
            {
                ptr.next = new ListNode(1);
            }
            return result.next;
        }
    }


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
}