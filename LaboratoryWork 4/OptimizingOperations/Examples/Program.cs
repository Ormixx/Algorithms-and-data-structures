using OptimizingOperations.Examples;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        string separator = "__________________________________________________________";
        Random random = new Random();
        int size = 100;
        CommonArray commonArray = new CommonArray(size);
        OrderedArray orderedArray = new OrderedArray(size);
        for (int i = 0; i < size; i++) // заполнение массива
        {
            bool insertResultCommonArray = false;
            bool insertResultOrderedArray = false;
            while (!insertResultCommonArray)
            {
                insertResultCommonArray = commonArray.Insert(random.Next(1000));
            }
            while (!insertResultOrderedArray)
            {
                insertResultOrderedArray = orderedArray.Insert(random.Next(1000));
            }
        }
        long searchValue = random.Next(1000);
        if (commonArray.Contains(searchValue))
        {
            Console.WriteLine("Значение было найдено. " + searchValue);
        }
        else
        {
            Console.WriteLine("Не удалось найти значение. " + searchValue);
        }
        Console.WriteLine(separator);
        if (orderedArray.Contains(searchValue))
        {
            Console.WriteLine("Значение было найдено. " + searchValue);
        }
        else
        {
            Console.WriteLine("Не удалось найти значение. " + searchValue);
        }
        Console.WriteLine("Максимальное значение массива: " + orderedArray.GetMax());
        Console.WriteLine("Минимальное значение массива: " + orderedArray.GetMin());
    }
}

