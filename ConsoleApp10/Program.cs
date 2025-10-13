using System;
public class Program
{
    static void Main(string[] args)
    {
        task3();
    }
    static void task1()
    {
        Console.WriteLine("Вводите числа:\n");
        int numInput;
        int evenCount = 0;
        while (int.TryParse(Console.ReadLine(), out numInput)){
            if (numInput % 2 == 0)
            {
                evenCount ++;
            }
        }

        Console.WriteLine(evenCount);
    }

    static void task2()
    {
        int K;
        try {
            K = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= K; i++)
            {
                if (i % 10 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        } catch { Console.WriteLine("Введено не число!"); };
    }

    static void task3()
    {
        int count = 0;
        try
        {
            while (Convert.ToDouble(Console.ReadLine()) != 0)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        catch { Console.WriteLine("Введено не число!"); }
    }
}