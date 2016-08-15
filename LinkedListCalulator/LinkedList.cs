using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class ListNode<T>
    {
        private ListNode<T> next;
        private T item;
        public ListNode<T> Next
	{
		get { return next; }
		set { next = value; }
	}

        public T Item
	{
		get { return item; }
		set { item = value; }
	}
        public ListNode(T item)
            : this(item, null)
        {
        }
        public ListNode(T item, ListNode<T> next)
        {
            this.item = item;
            this.next = next;
        }
    }

    public class SinglyLinkedList<T>
{
	
	private string strListName;
	private ListNode<T> firstNode;
    private ListNode<T> lastNode;
    private int count;
        public ListNode<T> FirstNode
	{
		get { return firstNode; }
	}

        public ListNode<T> LastNode
	{
		get { return lastNode; }
	}
        public bool IsEmpty
        {
            get
            {
                lock (this)
                {
                    return firstNode == null;
                }
            }
        }

        public int Count
        {
            get { return count; }
        }
        public void Reverse()
{
	if (firstNode == null || firstNode.Next == null)
		return;
	lastNode = firstNode;
	ListNode<T> prevNode = null;
	ListNode<T> currentNode = firstNode;
	ListNode<T> nextNode = firstNode.Next;

	while (currentNode != null)
	{
		currentNode.Next = prevNode;
		if (nextNode == null)
			break;
		prevNode = currentNode;
		currentNode = nextNode;
		nextNode = nextNode.Next;
	}
	firstNode = currentNode;
}

        public void InsertAtFront(T item)
        {
            lock (this)
            {
                if (IsEmpty)
                    firstNode = lastNode = new ListNode<T>(item);
                else
                    firstNode = new ListNode<T>(item, firstNode);
                count++;
            }
        }
        
        
        public  ListNode<T> nfromlast(int n)
    {
        
        
            int i;
        ListNode<T> current = firstNode;
        if (n <= 0)
            return current;
        for (i=0;i<n;i++)
        {
            if(current != null)
            {
                current = current.Next;
            }
            else
            {
                return null;
            }
        }
        ListNode<T>  behind = firstNode;
        while (current != null)
        {
            current = current.Next;
            behind = behind.Next;
        }
        return behind;
    }
 

    }

    
    }

