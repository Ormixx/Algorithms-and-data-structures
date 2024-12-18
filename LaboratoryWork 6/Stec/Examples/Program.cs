﻿using Stec.Examples;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            StackExample();
            QueueExample();
            PriorityQueueExample();
            TestPalindrome();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void StackExample()
    {
        Console.WriteLine("Stack example: ");
        StackImpl Stack = new StackImpl(10);
        Stack.Push('a');
        Stack.Push('b');
        Stack.Push('c');
        Stack.Push('d');

        while (!Stack.IsEmpty())
        {
            char value = Stack.Pop();
            Console.Write(value + " ");
        }
        Console.WriteLine();

       
        
    }

    public static void QueueExample()
    {
        Console.WriteLine("Queue example: ");
        QueueImpl Queue = new QueueImpl(5);
        Queue.Insert(10);
        Queue.Insert(20);
        Queue.Insert(30);
        Queue.Insert(40);

        Queue.Remove();
        Queue.Remove();
        Queue.Remove();
        Queue.Insert(50);
        Queue.Insert(60);
        Queue.Insert(70);
        Queue.Insert(80);

        while (!Queue.IsEmpty())
        {
            long n = Queue.Remove();
            Console.Write(n + " ");
        }
        Console.WriteLine();

        
        
    }

    public static void PriorityQueueExample()
    {
        Console.WriteLine("Priority queue example: ");
        PriorityQueueImpl PQ = new PriorityQueueImpl(5);
        PQ.Insert(30);
        PQ.Insert(50);
        PQ.Insert(10);
        PQ.Insert(40);
        PQ.Insert(20);

        while (!PQ.IsEmpty())
        {
            long item = PQ.Remove();
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void TestPalindrome()
    {
        string testWord = "level"; // слово можно изменять для тестирования
        if (UsingStack(testWord))
        {
            Console.WriteLine($"Слово \"{testWord}\" является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Слово \"{testWord}\" не является палиндромом.");
        }
    }

    public static bool UsingStack(string input)
    {
        input = input.ToLower();
        StackImpl stack = new StackImpl(input.Length);

        
        foreach (char c in input)
        {
            stack.Push(c);
        }

        
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != stack.Pop())
            {
                return false; 
            }
        }

        return true; 
    }


}
