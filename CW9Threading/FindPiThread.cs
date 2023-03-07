using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW9Threading
{
    class FindPiThread
    {
        private int _numDarts;
        private int _dartInsideCount;
        private Random _random;

        public FindPiThread(int numDarts) 
        { 
            _numDarts = numDarts;
            _random = new Random();
            _dartInsideCount = 0;
        }

        public int DartInsideCount { get => _dartInsideCount; }

        public void throwDarts()
        {
            for (int i = 0; i < _numDarts; i++)
            {
                double x = _random.NextDouble();
                double y = _random.NextDouble();

                if (Math.Sqrt(x * x + y * y) <= 1)
                    _dartInsideCount++;
            }
        }
    }
}
