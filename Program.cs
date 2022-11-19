namespace LinkedStackAndQueProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.push \n2.display \n3.pop \n 4.peek \n5,empty\n 6.exit");
            int choice = Convert.ToInt32(Console.ReadLine());


            StackLinkedList stackLinkedList = new StackLinkedList();
            QueueLinkedList queueLinkedList = new QueueLinkedList();
            stackLinkedList.Push(70);
            stackLinkedList.Push(30);
            stackLinkedList.Push(56);
            queueLinkedList.Equeue(56);
            queueLinkedList.Equeue(30);
            queueLinkedList.Equeue(70);

            switch (choice)
            {
                case 1:
                    stackLinkedList.Push(70);
                    stackLinkedList.Push(30);
                    stackLinkedList.Push(56);
                    stackLinkedList.Display();
                    break;
                case 2:
                    stackLinkedList.Display();
                    break;
                case 3:
                    stackLinkedList.Pop();
                    stackLinkedList.Display();
                    break;
                case 4:
                    stackLinkedList.peek();
                    break;
                case 5:
                    stackLinkedList.Empty();
                    break;
                case 6:
                    queueLinkedList.Equeue(56);
                    queueLinkedList.Equeue(30);
                    queueLinkedList.Equeue(70);
                    queueLinkedList.Display();
                    break;
                case 7:
                    queueLinkedList.Dequeue();
                    queueLinkedList.Display();
                    break;
                case 8:
                    queueLinkedList.Size();
                    break;
                case 9:
                    queueLinkedList.Empty();
                    break;
               
            }

           
            

           
          
           



        }
    }
}
