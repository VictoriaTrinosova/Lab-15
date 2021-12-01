using System;

namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            Console.WriteLine("Начальное число = 10");
            arithProgression.setStart(10);
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Следующее число = " + arithProgression.getNext());
            }
            arithProgression.reset();
            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("Начальное число = 2");
            geomProgression.setStart(2);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число = " + geomProgression.getNext());
            }
            geomProgression.reset();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int number;
        int start;
        public ArithProgression()
        {
            number = 0;
            start = 0;
        }
        public int getNext()
        {
            number += 2;
            return number;
        }

        public void reset()
        {
            number = start;
            Console.WriteLine("Сброс к начальному значению {0}",number);
        }

        public void setStart(int x)
        {
            start = x;
            number = start;
        }
    }
    class GeomProgression : ISeries
    {
        int start;
        int number;
        public GeomProgression()
        {
            start = 0;
            number = 0;
        }
        public int getNext()
        {
            number *= 3;
            return number;
        }

        public void reset()
        {
            number = start;
            Console.WriteLine("Сброс к начальному значению {0}", number);
        }

        public void setStart(int x)
        {
            start = x;
            number = start;
        }
    }
}
