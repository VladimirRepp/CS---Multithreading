using System;
using System.Threading;

// Пример создания и запуска потоков
namespace Sample_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sample0();
            Sample1();
        }

        private static void Print_ForSample0() => Console.WriteLine("Hello Threads!");

        private static void Sample0()
        {
            // Инициализируем потоки 
            Thread myThread = new Thread(Print_ForSample0);
            Thread myThread1 = new Thread(new ThreadStart(Print_ForSample0));
            Thread myThread2 = new Thread(() => Console.WriteLine("Hello Threads!"));

            // Запустить потоки
            myThread.Start();
            myThread1.Start();
            myThread2.Start();

            Console.ReadLine();
        }

        private static void Sample1()
        {
            Thread thread = new Thread(Print_ForSample1);
            thread.Start();
            thread.Priority = ThreadPriority.Normal;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Вывод ГЛАВНОГО потока №{i}");
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }

        private static void Print_ForSample1() 
        { 
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Вывод порожденного потока №{i}");
                Thread.Sleep(400);
            }
        }
    }
}
