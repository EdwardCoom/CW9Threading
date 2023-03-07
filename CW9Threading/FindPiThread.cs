// Name: Zach Coomer
// Date: 3/6/2023
// Assignment: CW9: Threading in C#
// Class: 352
// Description: Class for FindPiThread, used to generate random throws

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace CW9Threading
{
    /// <summary>
    /// Class that holds thread state and thread function
    /// </summary>
    class FindPiThread
    {
        private int _numDarts;
        private int _dartInsideCount;
        private Random _random;

        // Parameterized constructor for FindPiThread Class
        public FindPiThread(int numDarts) 
        { 
            _numDarts = numDarts;
            _random = new Random();
            _dartInsideCount = 0;
        }

        // Accessor function to get darts inside the dartboard quarter in main.
        public int DartInsideCount { get => _dartInsideCount; }

        // Function that generates random dart throws and checks to see if they are within the dart board quarter or not
        public void throwDarts()
        {
            for (int i = 0; i < _numDarts; i++)
            {
                double x = _random.NextDouble();
                double y = _random.NextDouble();

                if (Math.Sqrt(x * x + y * y) <= 1) // hypotenuse formula, used to check if x and y are within the dartboard range
                    _dartInsideCount++;
            }
        }
    }
}
