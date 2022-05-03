using StacksAndQueues;
using System;
public class Program
{
    public static void Main(String[] args)
    {
        Stacks stack = new Stacks();
        Queue queue = new Queue();
        Console.WriteLine("WELCOME IN THE STACK AND QUEUE");
        bool check = true;
        Console.WriteLine(" 1. push \n 2. IS_EMPTY \n 3. peek \n 4. pop \n 5. Display stack \n 6.Enqueue \n 7.Display Queue \n 8. end");
        while (check)
        {
            Console.WriteLine(" **** ENTER THE ABOVE OPTION TO EXECUTE THE METHODS *****");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Stack");
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    break;
                case 2:
                    stack.IsEmpty();
                    break;
                case 3:
                    stack.Peek();
                    break;
                case 4:
                    stack.Pop();
                    break;
                case 5:
                    stack.DisplayStack();
                    break;
                case 6:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    break;
                case 7:
                    queue.DisplayQueue();
                    break;
                case 8:
                    check = false;
                    break;
            }
        }

    }
}
