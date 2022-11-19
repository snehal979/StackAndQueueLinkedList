using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Add(70);
            Console.WriteLine("1.add \n 2.addinsertedat position\n 3.display\n 4.removefirst\n5.removelast\n6.search position of value\n 7.reversemethod \n 8.size\n 9.delectatPostion");
            int choice =Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    linkedList.Add(78);
                    
                    linkedList.Display();
                    break;
                case 2:
                    linkedList.InsertedAtParticularPosition(3, 45);
                    linkedList.Display();
                    break;
                case 3:
                    linkedList.Display();
                    break;
                case 4:
                    linkedList.RemoveFirstNode();
                    linkedList.Display();
                    break;
                case 5:
                    linkedList.LastRemove();
                    linkedList.Display();
                    break;
                case 6:
                    int a =linkedList.Search(79);
                    Console.WriteLine(a);

                    linkedList.SearchNUM(98);

                    break;
                case 7:
                    linkedList.AddInREverseOrder(30);
                    linkedList.AddInREverseOrder(56);
                    linkedList.AddInREverseOrder(70);
                    linkedList.Display();

                    break;
                case 8:

                    int b =linkedList.Size();
                    Console.WriteLine(b);
                    break;
                    case 9:
                    linkedList.DelectAtparticularPosition(1);
                    break;
                case 10:
                    int x =linkedList.AddSortLinkedList(5);
                    int y =linkedList.AddSortLinkedList(10);
                   int z = linkedList.AddSortLinkedList(15);

                    linkedcompariorMethod(x,y,z);
                    break;





            }
            
           


        }
        public static void linkedcompariorMethod(int x,int y,int z)
        {
            if (x.CompareTo(y)>0 &&x.CompareTo(z)>0)
                Console.WriteLine(x);
            if (y.CompareTo(x)>0 &&y.CompareTo(z)>0)
                Console.WriteLine(y);
            if (z.CompareTo(x)>0 &&z.CompareTo(y)>0)
                Console.WriteLine(z);
        }
    }
}