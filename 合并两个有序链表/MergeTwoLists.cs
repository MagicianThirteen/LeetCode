using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.合并两个有序链表
{
 

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
    internal class MergeTwoLists
    {
        public ListNode Sort(ListNode list1,ListNode list2)
        {
            //定义个临时的存储结果的list
            ListNode result = new ListNode();
            ListNode tmp=new ListNode();
            result = tmp;
            //边界条件,l1和l2一个有一个没有
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }
            //当双方链表都有时
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tmp.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tmp.next = list2;
                    list2 = list2.next;
                }
                tmp = tmp.next;
            }
            if (list1.next == null)
            {
                tmp.next = list2;
            }
            if (list2.next == null)
            {
                tmp.next = list1;
            }
            return result;
        }
    }
}
