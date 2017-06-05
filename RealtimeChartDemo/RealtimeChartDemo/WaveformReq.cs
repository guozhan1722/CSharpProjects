using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtimeChartDemo
{
    public class WaveformReq
    {
        public static int FreqSeriel1;
        public static int FreqSeriel2;
        public static int FreqSeriel3;

        public static int AmpSeriel1;
        public static int AmpSeriel2;
        public static int AmpSeriel3;

        public static int PhaSeriel1;
        public static int PhaSeriel2;
        public static int PhaSeriel3;

        public static int Interval;
        public static int SampleNum;
        public static int SampleRate;
        public static bool StopGenerate;
        public static int PlotLength { get; set; }

        public static string WaveSelected { get; set; }
    }
}
