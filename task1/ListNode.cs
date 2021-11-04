using System;
using System.Collections;
using System.Linq;

namespace task1
{
    public class ListNode
    {
        public readonly int value;
        public ListNode next;

        public ListNode(int value)
        {
            this.value = value;
        }

        public void Insert(int newValue)
        {
            SearchTail().next = new ListNode(newValue);
        }

        private ListNode SearchTail()
        {
            ListNode currentNode = this;

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            return currentNode;
        }

        public override string ToString()
        {
            ListNode currentNode = this;
            String result = String.Empty;
            
            while (currentNode != null)
            {
                result = String.Concat(result, $"{currentNode.value} ");
                currentNode = currentNode.next;
            }

            return result.Trim();
        }
    }
}