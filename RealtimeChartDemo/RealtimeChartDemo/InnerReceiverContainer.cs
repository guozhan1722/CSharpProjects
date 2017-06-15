using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RealtimeChartDemo
{
    public class RxDataContainer
    {
        public RxDataContainer(double[] data1,double[] data2)
        {
            this.dateEnd = DateTime.Now;
            this.value1 = data1;
            this.value2 = data2;
            SetTimpStampBuf();
            SetCompSample();
        }

        private void SetCompSample()
        {
            comSample = new Complex[value1.Length];
            comValue = new double[value1.Length];

            for (int i = 0; i < value1.Length; i++)
            {
                comSample[i] = new Complex(value1[i] + value2[i],0);
                comValue[i] = comSample[i].Real;
            }
        }

        private void SetTimpStampBuf()
        {
            tmStamp = new String[value1.Length];
            DateTime tm = dateEnd.AddMilliseconds(1000 * (-1));
            double tmSplite = 1000 / WaveformReq.SampleRate;
            for (int i = 0; i < value1.Length; i++)
            {
                tm = tm.AddMilliseconds(tmSplite);
                tmStamp[i] = tm.ToString("HH:mm:ss");
                
                //tmStamp[i] = tm.AddMilliseconds(tmSplite).ToString("HH:mm:ss");
            }
        }
 
        public DateTime dateEnd;
        public double[] value1;
        public double[] value2;
        public String[] tmStamp;
        public Complex[] comSample;
        public double[] comValue;
    }
}
