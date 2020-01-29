using System;

class Solution
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
    {
        while (node != null)
        {
            Console.Write(node.data);

            node = node.next;

            if (node != null)
            {
                Console.Write(sep);
            }
        }
    }

    // Complete the insertNodeAtPosition function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
    {
        while (true)
        {
            SinglyLinkedListNode newHead = new SinglyLinkedListNode(data);
            if (position == 0)
            {
                SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
                newNode.next = head;
                return newNode;
            }
            else
            {
                newHead = new SinglyLinkedListNode(head.data);
                position--;
                newHead.next = insertNodeAtPosition(head.next, data, position);
                return newHead;
            }
        }
    }

    static void Main(string[] args)
    {
        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < llistCount; i++)
        {
            int llistItem = Convert.ToInt32(Console.ReadLine());
            llist.InsertNode(llistItem);
        }

        int data = Convert.ToInt32(Console.ReadLine());

        int position = Convert.ToInt32(Console.ReadLine());

        SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

        PrintSinglyLinkedList(llist_head, " ");
        Console.WriteLine();
    }
}
