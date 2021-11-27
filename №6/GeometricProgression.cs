using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public class GeometricProgression : IIndexableSeries
    {
        public double this[int index] => _start*Math.Pow(_step, index-1);

        private double _start;//Начальное значение
        private int _step;//Шаг
        private double _current;//Текущее значение

        public GeometricProgression( double start, int step)
        {
            _start = start;
            _step = step;
            _current=_start;
        }
        public double GetCurrent()
        {
            return _current;
        }

        public bool MoveNext()
        {
            _current = _current * _step;
            return true;
        }

        public void Reset()
        {
            _current = _start;
        }
    }
}
