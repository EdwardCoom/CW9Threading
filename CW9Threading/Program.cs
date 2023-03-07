using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CW9Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of darts per thread: ");
            int numDarts = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of threads: ");
            int numThreads = int.Parse(Console.ReadLine());
                      
            List<Thread> threads = new List<Thread>();
            List<FindPiThread> findPiThreads = new List<FindPiThread>();



            for (int i = 0; i < numThreads; i++)
            {
                FindPiThread piThread = new FindPiThread(numDarts);
                findPiThreads.Add(piThread);

                Thread thread = new Thread(new ThreadStart(piThread.throwDarts));
                threads.Add(thread);

                thread.Start();

                Thread.Sleep(16);
            }

            foreach (Thread thread in threads) { thread.Join(); }

            long count = 0;
            foreach (FindPiThread piThread in findPiThreads) 
            {
                count += piThread.DartInsideCount;
            }
            
            double pi = ((double)4 * (count) / (numDarts * numThreads));

            Console.WriteLine("Pi = " + pi + "\nPress any key to close");

            Console.ReadKey();
        }
    }
}
