using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTTest
{
    class Waveform
    {
        public static double[] Sinusoidal(int numSamples, double sampleRate, int freq, int amplitude, int phase)
        {

            var result = new double[numSamples];

            double step = freq * 2 * Math.PI / sampleRate;

            for (int i = 0; i < numSamples; i++)
            {
                result[i] = amplitude * Math.Sin(i * step + phase);
            }
            return result;
        }

    }
}
