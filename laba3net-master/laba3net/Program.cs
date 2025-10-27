using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Выберите функцию (1-7). Для выхода нажмите '0'");
                Console.WriteLine("1)Среди заданных чисел найти количество четных чисел.\n" +
                    "2)Найти и вывести на экран все целые числа из промежутка от 1 до К, которые заканчиваются на цифру 3.\n" +
                    "3)Вводиться последовательность чисел заканчивающаяся 0 Найти количество введенных чисел.\n" +
                    "4)Найти сумму бесконечного ряда\n" +
                    "5)Вычисление значений функции на отрезке\n" +
                    "6)В натуральном числе, найти количество цифр, которые больше его десятков.\n" +
                    "7)Нахождение суммы\n");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Неверный ввод данных");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 5:
                        task5();
                        break;
                    case 6:
                        task6();
                        break;
                    case 7:
                        task7();
                        break;
                    case 0:
                        return;
                    default: 
                        Console.WriteLine("Нет такой функции!\n");
                        break;
                }

            }
        }
        static void task1()
        {
            Console.WriteLine("Введите числа:\n");
            int numInput;
            int evenCount = 0;

            int choice;
            int flag = 1;
            while (flag == 1)
            {
                if (int.TryParse(Console.ReadLine(), out numInput))
                {
                    if (numInput % 2 == 0)
                    {
                        evenCount++;
                    }
                } else
                {
                    Console.WriteLine("Неверный ввод данных, хотите продолжить? (Введите 1 для продолжения)");
                    int.TryParse(Console.ReadLine(), out choice);
                    if (choice != 1)
                    {
                        Console.WriteLine($"Количество четных чисел: {evenCount}");
                        flag = 0;
                    }
                }
            }
        }

        static void task2()
        {
            int K;

            int flag = 1;
            while (flag == 1)
            {
                try
                {
                    K = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= K; i++)
                    {
                        if (i % 10 == 3)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    flag = 0;
                }
                catch { Console.WriteLine("Введено не число!"); }
            }
    
        }

        static void task3()
        {
            int count = 0;

            int choice;
            int flag = 1;
            while (flag == 1)
            {
                try
                {
                    while (Convert.ToDouble(Console.ReadLine()) != 0)
                    {
                        count++;
                    }
                    Console.WriteLine($"Количество введенных чисел: {count}");
                    flag = 0;
                }
                catch { 
                    Console.WriteLine("Неверный ввод данных, хотите продолжить? (Введите 1 для продолжения)");
                    int.TryParse(Console.ReadLine(), out choice);
                    if (choice != 1)
                    {
                        Console.WriteLine($"Количество введенных чисел: {count}");
                        flag = 0;
                    }
                }
            }
        }
        static void task4()
        {
            Task4 task4 = new Task4();
            task4.FormClosed += (s, args) => { };
            task4.ShowDialog();
        }
        static void task5()
        {
            Form1 task5 = new Form1();
            task5.FormClosed += (s, args) => { };
            task5.ShowDialog();
        }
        static void task6()
        {
            Form2 task6 = new Form2();
            task6.FormClosed += (s, args) => { };
            task6.ShowDialog();
        }
        static void task7()
        {
            Task7 task7 = new Task7();
            task7.FormClosed += (s, args) => { };
            task7.ShowDialog();
        }
    }
}

