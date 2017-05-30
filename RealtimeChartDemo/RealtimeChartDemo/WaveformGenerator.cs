using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtimeChartDemo
{
    class WaveformGenerator
    {
        internal static double[] Sinusoidal(int sampleNum, double sampleRate, int freq, int amp, int pha)
        {

            var result = new double[sampleNum];

            double step = freq * 2 * Math.PI / sampleRate;

            for (int i = 0; i < sampleNum; i++)
            {
                result[i] = amp * Math.Sin(i * step + pha);
            }
            return result;
        }
    }
}
