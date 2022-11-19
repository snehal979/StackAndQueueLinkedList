namespace LinkedStackAndQueProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("1.push \n2.display \n3.pop \n 4.peek \n5,empty\n 6.exit");
            //int choice = Convert.ToInt32(Console.ReadLine());
           
           
            //StackLinkedList stackLinkedList = new StackLinkedList();
            //stackLinkedList.Push(70);
            //stackLinkedList.Push(30);
            //stackLinkedList.Push(56);
            
            //switch (choice)
            //{
            //        case 1:
            //            stackLinkedList.Push(70);
            //            stackLinkedList.Push(30);
            //            stackLinkedList.Push(56);
            //        stackLinkedList.Display();
            //        break;
            //        case 2:
            //            stackLinkedList.Display();
            //            break;
            //        case 3:
            //            stackLinkedList.Pop();
            //            stackLinkedList.Display();
            //            break;
            //        case 4:
            //            stackLinkedList.peek();
            //            break;
            //        case 5:
            //            stackLinkedList.Empty();
            //            break;
                    
            //}
            
           QueueLinkedList queueLinkedList = new QueueLinkedList();
            queueLinkedList.Equeue(56);
            queueLinkedList.Equeue(30);
            queueLinkedList.Equeue(70);
            queueLinkedList.Display();
            
        }
    }
}
