using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace RealtimeChartDemo
{
    class PlotLine: Series
    {
        private System.Windows.Forms.DataVisualization.Charting.Series waveSeries;

        public PlotLine(System.Windows.Forms.DataVisualization.Charting.Series waveSeries)
        {
            this.waveSeries = waveSeries;
            this.ChartType = waveSeries.ChartType;
            this.Color = waveSeries.Color;
            
            foreach (var item in waveSeries.Points)
            {
                this.Points.Add(item);
            }
        }
    }
}
