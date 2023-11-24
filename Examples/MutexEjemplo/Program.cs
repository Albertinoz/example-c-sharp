using System;
using System.Threading;

namespace MutexEjemplo
{
    internal class Program
    {
        private static Mutex mutex = new Mutex();

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(DoWork);
                thread.Start();
            }

            Console.ReadLine();
        }

        static void DoWork()
        {
            Console.WriteLine($"Hilo {Thread.CurrentThread.ManagedThreadId}");

            mutex.WaitOne();

            Console.WriteLine($"Hilo {Thread.CurrentThread.ManagedThreadId}");

            mutex.ReleaseMutex();

            Console.WriteLine($"Hilo {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
