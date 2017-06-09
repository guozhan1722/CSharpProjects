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
        private Series waveSeries;
        private Series freq1Series;
        private Series freq2Series;
        private Series freq3Series;
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
            waveSeries = new Series();
            waveSeries.ChartType = SeriesChartType.FastLine;
            waveSeries.Points.SuspendUpdates();


            freq1Series = new Series();
            freq1Series.ChartType = SeriesChartType.FastLine;
            freq1Series.Points.SuspendUpdates();

            freq2Series = new Series();
            freq2Series.ChartType = SeriesChartType.FastLine;
            freq2Series.Points.SuspendUpdates();

            freq3Series = new Series();
            freq3Series.ChartType = SeriesChartType.FastLine;
            freq3Series.Points.SuspendUpdates();

            chartWaveform.Series.Clear();
            chartWaveform.Series.SuspendUpdates();

            int totalLength = maxPlotSize / WaveformReq.SampleRate;
            //totalLength = 0;
            DateTime timeStamp = DateTime.Now.AddMilliseconds(1000 * totalLength * (-1));
            double timeSplite = 1000 / WaveformReq.SampleRate;
            for (int i = 0; i < maxPlotSize; i++)
            {
                timeStamp = timeStamp.AddMilliseconds(timeSplite);
                waveSeries.Points.AddXY(timeStamp.ToString("HH:mm:ss"), 0);
                freq1Series.Points.AddXY(timeStamp.ToString("HH:mm:ss"), 0);
                freq2Series.Points.AddXY(timeStamp.ToString("HH:mm:ss"), 0);
                freq3Series.Points.AddXY(timeStamp.ToString("HH:mm:ss"), 0);
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
                    RemoveOldPoints();
                    UpdateSeries();

                    Debug.WriteLine("Task Plot: " + CCC++);
                    
                });
            DrawDotsOnUI();
        }

        private void UpdateSeries()
        {
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
                            w = item.comSample[i].Real;
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
                    waveSeries.Points.AddXY(item.tmStamp[i].ToString("HH:mm:ss"), w);
                    freq1Series.Points.AddY(f1);
                    freq2Series.Points.AddY(f2);
                    freq3Series.Points.AddY(f3);
                }
            }
        }
        
        private void RemoveOldPoints()
        {
            int total = 0;
            var dots = waveSeries.Points;
            foreach (var item in rxDataBackup)
            {
                total += item.value1.Length;
            }

            totalDotsForRemove = dots.Count - maxPlotSize + total;

            if(totalDotsForRemove >=0)
            {
                for (int i = 0; i < totalDotsForRemove; i++)
                {
                    waveSeries.Points.RemoveAt(0);
                    freq1Series.Points.RemoveAt(0);
                    freq1Series.Points.RemoveAt(0);
                    freq1Series.Points.RemoveAt(0);
                }

            }
        }

        private void DrawDotsOnUI()
        {
            chartWaveform.Series.Clear();
            chartWaveform.Series.Add(waveSeries);
            chartWaveform.Series.Add(freq1Series);
            chartWaveform.Series.Add(freq2Series);
            chartWaveform.Series.Add(freq3Series);
            chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
            chartWaveform.ChartAreas[0].RecalculateAxesScale();
            plotAsync();
        }

        
    }
}
