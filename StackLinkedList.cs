using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStackAndQueProblem
{
    public class StackLinkedList
    {
        Node headtop;
        public StackLinkedList()
        {
            this.headtop = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.headtop == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.headtop;
            }
            this.headtop =node;
            Console.WriteLine("added the stack value "+value);
        }
        public void Display()
        {
            Node temp = this.headtop;
            if(temp ==null)
            {
                Console.WriteLine("stacklist is empty");
            }
            while(temp !=null)
            {
                Console.WriteLine(temp.data +" ");
                temp =temp.next;
            }
        }

    }
}
            
