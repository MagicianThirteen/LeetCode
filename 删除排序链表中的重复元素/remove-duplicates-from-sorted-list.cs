using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.删除排序链表中的重复元素
{
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
    internal class removeduplicatesfromsortedlist
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            //一般做法
            if (head == null) return null;
            ListNode current = head;
            while (current.next != null)
            {
                if (current.next.val == current.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;

            //递归解法
            /*if (head == null) return head;
            head.next = DeleteDuplicates(head);
            return head.val == head.next.val ? head.next : head;*/
        }
    }
}
