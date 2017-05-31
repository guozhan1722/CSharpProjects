using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtimeChartDemo
{
    public class InnerReceiverContainer
    {
        public InnerReceiverContainer(double[] data1,double[] data2, double[] data3)
        {
            this.dateEnd = DateTime.Now;
            this.value1 = data1;
            this.value2 = data2;
            this.value3 = data3;
        }
        public DateTime dateEnd;
        public double[] value1;
        public double[] value2;
        public double[] value3;
    }
}
