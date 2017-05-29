using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChart
{
    class RxDataContainer
    {
        public RxDataContainer(double[] data)
        {
            this.dateEnd = DateTime.Now;
            this.value = data;
        }
        public DateTime dateEnd;
        public double[] value;
    }
}
