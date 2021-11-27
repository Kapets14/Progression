using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public class ArithmeticProgression : IIndexableSeries
    {
        public double this[int index] => _start + (index - 1) * _step;

        private double _start;
        private int _step;
        private double _current;
        public ArithmeticProgression(double start, int step)
        {
            _start = start;
            _step = step;
            _current = start;
        }

        public double GetCurrent()//получение текущего элемента прогресси
        {
            return _current;
        }

        public bool MoveNext()//следующий элемент прогрессии
        {
            _current = _current + _step;
            return true;
        }

        public void Reset()//Сбросить до начального значениялох
        {
            _current = _start;
        }
    }
}
