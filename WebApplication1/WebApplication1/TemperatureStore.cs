using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public class TemperatureStore
    {
        private readonly List<double> _store;

        public TemperatureStore()
        {
            _store = new List<double>();
        }

        public void AddTemperature(double value)
        {
            if (_store.Count == 10)
            {
                _store.RemoveAt(0);
            }

            _store.Add(value);
        }

        public double GetAverage()
        {
            return _store.Average();
        }

        public double GetLastReading()
        {
            return _store.Last();
        }
    }
}
