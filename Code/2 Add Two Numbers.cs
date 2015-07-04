using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
	/**
	* Definition for singly-linked list.
	* public class ListNode {
	*     public int val;
	*     public ListNode next;
	*     public ListNode(int x) { val = x; }
	* }
	*/
	public class Solution
	{
		/// <summary>
		/// 两个链表，代表两个非负数，低位在“前”。
		/// </summary>
		/// <param name="l1"></param>
		/// <param name="l2"></param>
		/// <returns>两个数的和</returns>
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			ListNode result = null;
			ListNode prep = result;
			ListNode nowp = result;
			bool carry = false;

			int sum = l1.val + l2.val;
			if (sum >= 10)
			{
				sum -= 10;
				carry = true;
			}
			result = new ListNode(sum);
			nowp = result;
			prep = result;

			while (l1.next != null && l2.next != null)
			{
				l1 = l1.next;
				l2 = l2.next;

				sum = l1.val + l2.val;

				if (carry)
				{
					sum++;
					carry = false;
				}

				if (sum >= 10)
				{
					sum -= 10;
					carry = true;
				}

				nowp = new ListNode(sum);
				prep.next = nowp;
				prep = prep.next;
			}

			if (l1.next == null && l2.next == null)
			{
				if (carry)
				{
					nowp = new ListNode(1);
					prep.next = nowp;
				}
			}
			else
			{
				prep.next = l1.next ?? l2.next;
				nowp = prep.next;

				while (carry)
				{
					nowp.val++;
					carry = false;

					if (nowp.val >= 10)
					{
						carry = true;
						nowp.val -= 10;

						if (nowp.next != null)
						{
							prep = nowp;
							nowp = nowp.next;
						}
						else
						{
							prep = nowp;
							nowp = new ListNode(1);
							prep.next = nowp;
							break;
						}
					}
				}
			}

			return result;
		}
	}

	public class ListNode
	{
		public int val;
		public ListNode next;

		public ListNode(int x)
		{
			val = x;
		}
	}
}
