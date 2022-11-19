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
        public void peek()
        {
            if (this.headtop==null)
            {
                Console.WriteLine("list is empty");
            }
            Console.WriteLine("{0} is the top of the stack list",this.headtop.data);
        }
        public void Pop()
        {
            if (this.headtop==null)
            {
                Console.WriteLine("list is empty");
            }
            Console.WriteLine("value is pop "+this.headtop.data);
            this.headtop = this.headtop.next;
        }
        public void Empty()
        {
            while (this.headtop!=null)
            {
                peek();
                Pop();
            }
        }
        public void Size()
        {
            Node temp = this.headtop;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("size of stack list is "+count); 




        }
    }
}
            
