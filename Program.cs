using Microsoft.VisualBasic.FileIO;
using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1
            Console.WriteLine("Task1\n");
            for (int i = 0; i <= 99; i++)
            {

                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            // Task 2
            Console.WriteLine("Task2\n");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // Task 3
            Console.WriteLine("Task3\n");

            Console.WriteLine("Введите любое положительное число:");
            int choose = int.Parse(Console.ReadLine());
            int res = 0;

            for (int i = 1; i < choose; i++)
            {
                res = res + i;
            }
            Console.WriteLine(res);

            //Task 4
            Console.WriteLine("Task4\n");

            for (int i = 7; i <= 98; i = i + 7)
            {
                Console.WriteLine(i);
            }

            //Task 5
            Console.WriteLine("Task5\n");

            for (int i = -5; i >= -5 * 10; i = i - 5)
            {
                Console.WriteLine(i);
            }

            //Task 6
            Console.WriteLine("Task6\n");

            double resultate = 0;
            for (double i = 10; i <= 20; i++)
            {
                resultate = Math.Pow(i, 2);
                Console.WriteLine(resultate);

            }

            //Task 7 Arrays
            Console.WriteLine("Task7\n");

            Console.WriteLine("Введите число, чтобы узнать его наличии в массиве:");

            int number = int.Parse(Console.ReadLine());

            int[] array = { 2, 4, 6, 7, 9, 20, 46, 37, 12 };

            for (int i = 0; i <= array.Length; i++)
            {
                if (array.Contains(number))
                {
                    Console.WriteLine("Такоe числo в массиве есть");
                    break;

                }

                else
                {
                    Console.WriteLine("Такого числа в массиве нет");
                    break;
                }

            }

            // Task 8
            Console.WriteLine("Task8\n");

            Console.WriteLine("Введите число, чтобы удалить его из массива:");

            int numbertodelete = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] array1 = { 1, 3, 5, 6, 8, 3, 9, 12, 32, 34 };
            int[] newarray = new int[array1.Length];
            if (array1.Contains(numbertodelete))
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == numbertodelete)
                    {
                        continue;
                    }
                    else
                    {
                        newarray[i] = array1[i];
                        Console.Write($"{newarray[i]}\t");
                    }

                }
            }
            else
            {
                Console.WriteLine("Такого числа в массиве нет");
            }




            // Task 9
            Console.WriteLine("Task9\n");

            Console.WriteLine("Введите размер массива:");
            int sizeofarray = int.Parse(Console.ReadLine());
            int[] arraymath = new int[sizeofarray];
            int middle = 0;

            Random ran = new Random();
            Console.WriteLine("Ваш массив:");
            for (int i = 0; i < sizeofarray; i++)
            {
                arraymath[i] = ran.Next(-100, 100);
                Console.Write($"{arraymath[i]}\t");
            }
            for (int i = 0; i < sizeofarray; i++)
            {
                middle += arraymath[i];

            }
            Console.WriteLine("");
            Console.WriteLine("\nСреднее число массива: " + middle / sizeofarray);
            Console.WriteLine("\nМинимальное число массива: " + arraymath.Min());
            Console.WriteLine("\nМаксимальное число массива: " + arraymath.Max());

            //Task 10
            Console.WriteLine("Task10\n");
            int firstmiddle = 0;
            int secondmiddle = 0;

            int[] firstarray = new int [5];
            int[] secondarray = new int [5];

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                firstarray[i] = rand.Next(-100,100);
             Console.Write($"{firstarray[i]}\t" );
            }

            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                secondarray[i] = rand.Next(-100, 100);
                Console.Write($"{secondarray[i]}\t");
            }

            for (int i = 0; i < 5; i++)
            {
                firstmiddle += firstarray[i];

             }

            for (int i = 0; i < 5; i++)
            {
                secondmiddle += secondarray[i];

            }
            

            if ((secondmiddle / 2) > (firstmiddle / 2))
                {
                Console.WriteLine("\nСреднее арифметическое второго массива больше, чем первого");
                }
            else if ((secondmiddle/2) == (firstmiddle/2))
            {
                Console.WriteLine("\nСреднее арифметическое первого и второго массивов равны");
            }
            else
            { 
                Console.WriteLine("\nСреднее арифметическое первого массива больше, чем второго");
            }
  













        }
    }
}