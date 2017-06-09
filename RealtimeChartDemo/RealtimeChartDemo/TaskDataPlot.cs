using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace RealtimeChartDemo
{
    class TaskDataPlot
    {
        private List<RxDataContainer> rxData;
        private Chart chartWaveform;
        private List<RxDataContainer> rxDataBackup;
        private DataPointCollection ddd;

        private int maxPlotSize = WaveformReq.SampleRate * 60;
        private int totalDotsForRemove;
        private int CCC;

        public TaskDataPlot(List<RxDataContainer> rxData, Chart chartWaveform)
        {
            this.rxData = rxData;
            this.chartWaveform = chartWaveform;
            rxDataBackup = new List<RxDataContainer>();
            InitChartAreas();
            InitSeries();
        }

        private void InitChartAreas()
        {
            var dots2 = chartWaveform.Series[2].Points;
            var area = chartWaveform.ChartAreas[0];
            int interval = maxPlotSize / 6;

            area.AxisX.MajorGrid.Interval = interval;
            area.AxisX.MinorGrid.Interval = interval;
            area.AxisX.Interval = interval;
        }

        private void InitSeries()
        {
            var series = chartWaveform.Series;
            int totalLength = maxPlotSize / WaveformReq.SampleRate;
            //totalLength = 0;
            DateTime timeStamp = DateTime.Now.AddMilliseconds(1000 * totalLength * (-1));
            double timeSplite = 1000 / WaveformReq.SampleRate;
            for (int i = 0; i < maxPlotSize; i++)
            {
                timeStamp = timeStamp.AddMilliseconds(timeSplite);
                foreach (var item in series)
            	{
                    var dots = item.Points;
                    dots.AddXY(timeStamp.ToString("HH:mm:ss"), 0);
	            }
            }
        }

        public void StartPlot()
        {
            plotAsync();
        }
        
        private async void plotAsync()
        {
            await Task.Run(()=>
                {
                    while (rxData.Count <= 0)
                    {
                        Thread.Sleep(100);
                    }

                    lock (rxData)
                    {
                        rxDataBackup.Clear();
                        rxDataBackup.AddRange(rxData);
                        rxData.Clear();
                    }
                    CalNeedRemovedDots();
                    Debug.WriteLine("Task Plot: " + CCC++);
                    
                });
            DrawDotsOnUI();
        }
        
        private void CalNeedRemovedDots()
        {
            int total = 0;
            var dots =chartWaveform.Series[0].Points;
            foreach (var item in rxDataBackup)
            {
                total += item.value1.Length;
            }

            totalDotsForRemove = dots.Count - maxPlotSize + total;
        }
       
        private void DrawDotsOnUI()
        {
            var sers = chartWaveform.Series;
            var dot00 = chartWaveform.Series[0].Points;
            var dot01 = chartWaveform.Series[1].Points;
            var dot02 = chartWaveform.Series[2].Points;
            var dot03 = chartWaveform.Series[3].Points;
            foreach (var item in sers)
            {
                var dot = item.Points;
                dot.SuspendUpdates();
            }

            if (totalDotsForRemove >= 0)
            {
                RemoveDotsFromChart(totalDotsForRemove);
            }

            int count=0;
            foreach (var item in rxDataBackup)
            {
                for (int i = 0; i < item.value1.Length; i++)
                {
                    double w = 0;
                    double f1 = 0;
                    double f2 = 0;
                    double f3 = 0;
                    switch (WaveformReq.WaveSelected)
                    {
                        case "Waveform":
                            w =item.comSample[i].Real;
                            break;
                        case "Series1":
                            f1 = item.value1[i];
                            break;
                        case "Series2":
                            f2 = item.value2[i];
                            break;
                        case "Series3":
                            f3 = item.value3[i];
                            break;
                        default:
                            break;
                    }
                    dot00.AddXY(item.tmStamp[i].ToString("HH:mm:ss"), w);
                    dot01.AddY(f1);
                    dot02.AddY(f2);
                    dot03.AddY(f3);
                }
            }
            chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
            chartWaveform.ChartAreas[0].RecalculateAxesScale();

            foreach (var item in sers)
            {
                var dot = item.Points;
                dot.ResumeUpdates();
            }
            plotAsync();
        }

        private void RemoveDotsFromChart(int totalDotsForRemove)
        {
            var sers = chartWaveform.Series;
            for (int i = 0; i < totalDotsForRemove; i++)
            {
                foreach (var item in sers)
                {
                    var dot = item.Points;
                    dot.RemoveAt(0);
                }
            }
        }
        
    }
}
