using System;

namespace _6
{
    class Program
    {
        public static void PrintSeries(ISeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        public static void PrintIndexable(IIndexable indexable, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                
                Console.WriteLine( indexable[i]);

            }
        }
        static void Main(string[] args)
        {
            ArithmeticProgression tip = new ArithmeticProgression(2,2); //Создаём объект
            PrintSeries(tip, 6);
            tip.Reset();
            PrintIndexable(tip, 6);

            Console.WriteLine("Геометрическая прогресия");
            GeometricProgression tip2 = new GeometricProgression(2,2); //Создаём объект
            PrintSeries(tip2, 6);
            tip.Reset();
            PrintIndexable(tip2, 6);
        }

    }
}
