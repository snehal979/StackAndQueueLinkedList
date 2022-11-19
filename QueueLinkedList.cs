using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStackAndQueProblem
{
    public class QueueLinkedList
    {
        Node headtop;
        public void Equeue(int data)
        {
            Node node = new Node(data);
            if (this.headtop == null)
            {
                this.headtop = node;
            }
            else
            {
                Node temp = headtop;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        public void Display()
        {
            Node temp = this.headtop;
            if (temp ==null)
            {
                Console.WriteLine("stacklist is empty");
            }
            while (temp !=null)
            {
                Console.WriteLine(temp.data +" ");
                temp =temp.next;
            }
        }



    }
}
