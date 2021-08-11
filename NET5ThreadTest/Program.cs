using System;
using System.Threading;

namespace NET5ThreadTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("[MT] Hello World!");
            new Thread(new ThreadStart(() => {
                Console.WriteLine("[T1] Hello from thread 1!");
                Thread.Sleep(2000);
                Console.WriteLine("[T1] Hello from thread 1 after 2 seconds!");
                Thread.Sleep(2000);
                Console.WriteLine("[T1] Hello from thread 1 after 4 seconds!");
            })).Start();

            new Thread(new ThreadStart(() => {
                Console.WriteLine("[T2] Hello from thread 2!");
                Thread.Sleep(3000);
                Console.WriteLine("[T2] Hello from thread 2 after 3 seconds!");
                Thread.Sleep(2000);
                Console.WriteLine("[T2] Hello from thread 2 after 5 seconds!");
            })).Start();

            new Thread(new ThreadStart(() => {
                Console.WriteLine("[T3] Hello from thread 3!");
                Thread.Sleep(1000);
                Console.WriteLine("[T3] Hello from thread 3 after 1 seconds!");
                Thread.Sleep(1000);
                Console.WriteLine("[T3] Hello from thread 3 after 2 seconds!");
                Thread.Sleep(1000);
                Console.WriteLine("[T3] Hello from thread 3 after 3 seconds!");
                Thread.Sleep(1000);
                Console.WriteLine("[T3] Hello from thread 3 after 4 seconds!");
                Thread.Sleep(1000);
                Console.WriteLine("[T3] Hello from thread 3 after 5 seconds!");
                Thread.Sleep(1000);
                Console.WriteLine("[T3] Hello from thread 3 after 6 seconds!");
            })).Start();

            new Thread(new ThreadStart(() => {
                Console.WriteLine("[T4] Hello from thread 4!");
                Thread.Sleep(7000);
                Console.WriteLine("[T4] Hello from thread 4 after 7 seconds!");
            })).Start();
            
            new Thread(new ThreadStart(() => {
                while (true) {
                    var k = Console.ReadKey(true);
                    Console.WriteLine($"[T5] {k.KeyChar} was pressed");

                    if (k.Key == ConsoleKey.DownArrow) {
                        Console.WriteLine("[T5] Exiting thread 5...");
                        break;
                    }
                }
            })).Start();
            
            Console.WriteLine("[MT] Hello from main!");
        }
    }
}