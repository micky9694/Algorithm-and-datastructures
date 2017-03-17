using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DLL
{
    public class TimeMeasurement
    {
        private long start;
        private long stop;
        private long frequency;
        Decimal multiplier = new Decimal(1.0e9);

        // Importing important DLL's that will be used
        [DllImport("KERNEL32")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        // Timing constructor
        public TimeMeasurement()
        {
            if (QueryPerformanceFrequency(out frequency) == false)
            {
                // Frequency not supported
                throw new Win32Exception();
            }
        }

        // Method for starting the counter
        public void Start()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            QueryPerformanceCounter(out start);
        }

        // Method for stopping the counter
        public void Stop()
        {
            QueryPerformanceCounter(out stop);
        }

        // Returns the average time between iterations in nanoseconds
        public double Duration(int iterations)
        {
            return ((((double)(stop - start) * (double)multiplier) / (double)frequency) / iterations);
        }

        // Get the elapsed time between the start and the stop function in nanoseconds
        public double GetElapsedTime()
        {
            //return ((TimeSpan)(dtEndTime - dtStartTime)).TotalMilliseconds;
            return (((double)(stop - start) * (double)multiplier) / (double)frequency);
        }
    }
}
