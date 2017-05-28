using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace testChart2
{
    class PlotChart: Chart
    {
        public int  TotalSec { get; set; }
        public int  FreshInterval { get; set; }
        public int  DataSamplePerSec { get; set; }


    }
}
