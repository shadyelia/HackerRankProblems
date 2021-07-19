using System;

namespace QHEAP1
{
    class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }
    }
    class BinaryTree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        public Node Find(int value)
        {
            return this.Find(value, this.Root);
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        public int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }
        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }

            return null;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCases = Convert.ToInt32(Console.ReadLine());
            BinaryTree numbers = new BinaryTree();
            string[] line;
            int Q;
            int c1 = 0;
            int minValue = 0;

            for (int i = 0; i < numberOfCases; i++)
            {
                line = Console.ReadLine().Split(' ');
                Q = Convert.ToInt32(line[0]);
                if (Q == 1)
                {
                    int newNumber = Convert.ToInt32(line[1]);
                    numbers.Add(newNumber);
                    c1++;
                }
                else if (Q == 2)
                {
                    int numberToRemove = Convert.ToInt32(line[1]);
                    numbers.Remove(numberToRemove);
                    c1++;
                }
                else if (Q == 3)
                {

                    if (c1 == 0)
                        Console.WriteLine(minValue);
                    else
                    {
                        minValue = numbers.MinValue(numbers.Root);
                        Console.WriteLine(minValue);
                        c1 = 0;
                    }
                }
            }

        }
    }
}
