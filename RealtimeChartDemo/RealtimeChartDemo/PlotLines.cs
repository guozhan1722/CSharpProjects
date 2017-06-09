using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace RealtimeChartDemo
{
    class PlotLines: Series
    {
        private Series waveSeries;

        public PlotLines(Series waveSeries)
        {
            // TODO: Complete member initialization
            this.waveSeries = waveSeries;
            foreach (var item in waveSeries.Points)
	        {
		         this.Points.Add(item);
	        }
        }
    }
}
