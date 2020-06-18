using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    public static class RandomNumberGenerator_Counter
    {
        public static Random _generator = new Random();

        public static int counterRed;

        public static int counterYellow;
        public static int CounterRed
        {
            get { return counterRed; }
            set { counterRed = value; }
        }

        public static int CounterYellow
        {
            get { return counterYellow; }
            set { counterYellow = value; }
        }

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _generator.Next(minimumValue, maximumValue + 1);
        }

        public static int CounterUpRed()
        {
            return CounterRed++;
        }

        public static int CounterUpYellow()
        {
            return CounterYellow++;
        }
    }
}
