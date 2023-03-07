// Name: Zach Coomer
// Date: 3/6/2023
// Assignment: CW9: Threading in C#
// Class: 352
// Description: Class to store main, program used to determine pi with random dart throws

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CW9Threading
{
    /// <summary>
    /// This class houses Main()
    /// </summary>
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

                Thread.Sleep(16); // pauses main for 16 milliseconds to ensure that the random number generators in each FindPiThread get a unique seed.
            }

            foreach (Thread thread in threads) { thread.Join(); } // tells Main() to wait until every thread is done before continuing

            long count = 0;
            foreach (FindPiThread piThread in findPiThreads) // adds the dart throws inside the dartboard together from each thread
            {
                count += piThread.DartInsideCount;
            }
            
            double pi = ((double)4 * (count) / (numDarts * numThreads)); // pi calculation

            Console.WriteLine("Pi = " + pi + "\nPress any key to close");

            Console.ReadKey();
        }
    }
}
