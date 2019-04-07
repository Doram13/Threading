using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Counting));
            Thread thread2 = new Thread(new ThreadStart(Counting));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            System.Console.ReadLine();

        }

        static void Counting()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Current iteration: {i}. Current thread: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);

            }
        }
    }
}
