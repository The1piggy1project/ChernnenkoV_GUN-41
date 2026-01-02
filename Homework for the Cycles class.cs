using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // Задание 1
            // =========================

            Console.WriteLine("Fibonacci numbers:");

            int a = 0; 
            int b = 1; 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);

                int temp = a + b; 
                a = b;
                b = temp;
            }

            // =========================
            // Задание 2
            // =========================

            Console.WriteLine("\nEven numbers from 2 to 20:");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            // =========================
            // Задание 3
            // =========================

            Console.WriteLine("\nMultiplication table:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }

            // =========================
            // Задание 4
            // =========================

            string password = "qwerty";
            string input;

            do
            {
                Console.Write("Enter password: ");
                input = Console.ReadLine();

                if (input != password)
                {
                    Console.WriteLine("Wrong password!");
                }

            } while (input != password);

            Console.WriteLine("Password is correct!");
        }
    }
}