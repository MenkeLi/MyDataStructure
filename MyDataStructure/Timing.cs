using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure
{
    public class Timing
    {
        private TimeSpan _startingTime;
        private TimeSpan _duration;

        public Timing()
        {
            _startingTime = new TimeSpan(0);
            _duration = new TimeSpan(0);
        }

        public void StopTime()
        {
            //_duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(_startingTime);
            _duration = Process.GetCurrentProcess().TotalProcessorTime.Subtract(_startingTime);
        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            _startingTime = Process.GetCurrentProcess().TotalProcessorTime;
        }

        public TimeSpan Result()
        {
            return _duration;
        }

        public void Reset()
        {
            //_startingTime = new TimeSpan(0);
            _duration = new TimeSpan(0);
        }

        public void Restart()
        {
            Reset();
            StartTime();
        }
    }
}
