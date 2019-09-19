using System;

namespace Linked_List_2
{

    public class Node
    {
        public int data;
        public Node next;

        //constructor
        public Node (int i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "| ");
            if(next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }

    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {


            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }
        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }

        public void AddFirst(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void Delete(int a)
        {
            Console.WriteLine("This number wil be deleted: " + a);
            var node = headNode;
            Node currentNode = headNode;
            Node previousNode = null;
            while (node != null)
            {
                currentNode = node;
                if (node.data == a)
                {
                    if (previousNode != null)
                    {
                        previousNode.next = currentNode.next;
                    }
                    else
                    {
                        headNode = headNode.next;
                    }
                    break;
                }
                previousNode = currentNode;
                node = node.next;
            }
        }
    }
            
    
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();



            Console.WriteLine("List 1 method below is adding nodes at the end of the linked list\n");
            list.AddToEnd(2);
            list.AddToEnd(5);
            list.AddToEnd(8);
            list.AddToEnd(9);
            list.AddToEnd(4);
            list.AddToEnd(1);

            list.Print();

            MyList list2 = new MyList();
            Console.WriteLine("\n\nList 2 method below is adding nodes to beginning of the linked list\n");

            list2.AddFirst(12);
            list2.AddFirst(23);
            list2.AddFirst(15);
            list2.AddFirst(54);
            list2.AddFirst(68);
            list2.AddFirst(72);
                
            list2.Print();

            MyList list3 = new MyList();

            Console.WriteLine("\n\nList 3 below will be used to Delete node.\n");
            list3.AddToEnd(99);
            list3.AddToEnd(23);
            list3.AddToEnd(34);
            list3.AddToEnd(76);
            list3.Print();

            Console.WriteLine("\n");
             list3.Delete(99);

            Console.WriteLine("List 3 after deleting node\n");
            list3.Print();




            Console.WriteLine("\n\nPress enter key to exit");
            Console.ReadLine();
        }
    }
}
