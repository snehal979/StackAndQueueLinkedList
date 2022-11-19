using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListProblem
{
    
    public class LinkedList
    {
        public Node head;
       
        public Node tail;
        /// <summary>
        /// Uc1
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List",node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                while(temp != null)
                {
                    Console.WriteLine(temp.data +" ");
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// Uc2
        /// </summary>
        /// <param name="data"></param>
        public void AddInREverseOrder(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next= temp;
            }
        }
        /// <summary>
        /// UC3
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void InsertedAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if(this.head == null)
            {
                Console.WriteLine(newestNode);
            }
            if (position==0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                Console.WriteLine(this.head);
            }
            else
            {
                Node prev = null;
                Node current = this.head;
                int count = 0;
                while(current != null && count < position)
                {
                    prev = current;
                    current = current.next;
                    count++;
                }
                newestNode.next  = prev.next;
                prev.next =newestNode;
                Console.WriteLine(this.head);
            }
        }
        /// <summary>
        /// uc4
        /// 
        /// </summary>
        public void RemoveFirstNode()
        {
            if(this.head == null)
            {
                Console.WriteLine("linked list is empty");

            }
            else
            {
                this.head = this.head.next;
            }
        }
        /// <summary>
        /// uc6
        /// </summary>
        public void LastRemove()
        {
            if(head == null)
            {
                Console.WriteLine("linked list is empty");
            } else if(head.next == null)
            {
                head = null;
            }
            else
            {
                Node newNode = head;
                while(newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
            }
        }
        /// <summary>
        /// uc7 position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Search(int value)
        {
            Node node = this.head;
            if(node == null)
            {
                return -1;
            }
            int count = 0;
            while(node !=null)
            {
                
                if(node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;

        }
        /// <summary>
        /// uc7 8 value 
        /// </summary>
        /// <param name="value"></param>
        public void SearchNUM(int value)
        {

            if (this.head.data == value)
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");

            }

        }
        public int Size()
        {
            Node temp = this.head;
            int count = 0;
            if(temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
                count++;
            }
            return count;




        }
        public void DelectAtparticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
            }
            for (int i = 0; temp !=null&& i<position-1; i++)
            {
                temp = temp.next;
            }
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }

        public int AddSortLinkedList(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
           return node.data;
        }


    }
}
