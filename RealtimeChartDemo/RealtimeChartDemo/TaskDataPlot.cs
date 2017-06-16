using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

        private int maxPlotSize = WaveformReq.SampleRate * 60;

        private int CCC;
        private int totalRxSize;
        private ChartArea chartArea0;
        private ChartArea chartArea1;
        private SeriesCollection series;


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
            chartArea0 = chartWaveform.ChartAreas[0];
            int interval = maxPlotSize / 6;

            chartArea0.AxisX.MajorGrid.Interval = interval;
            chartArea0.AxisX.MinorGrid.Interval = interval;
            chartArea0.AxisX.Interval = interval;

            chartArea1 = chartWaveform.ChartAreas[1];
            chartArea1.AxisX.MajorGrid.Interval = interval;
            chartArea1.AxisX.MinorGrid.Interval = interval;
            chartArea1.AxisX.Interval = interval;

        }

        private void InitSeries()
        {
            series = chartWaveform.Series;
            series.SuspendUpdates();

            int totalLength = maxPlotSize / WaveformReq.SampleRate;
            //totalLength = 0;
            DateTime timeStamp = DateTime.Now.AddMilliseconds(1000 * totalLength * (-1));
            double timeSplite = 1000 / WaveformReq.SampleRate;
            for (int i = 0; i < maxPlotSize; i++)
            {
                timeStamp = timeStamp.AddMilliseconds(timeSplite);
                foreach (var serie in series)
                {
                    serie.Points.AddXY(timeStamp.ToString("HH:mm:ss"), 0);
                }
            }
            
        }

        public async void StartPlotAsyn()
        {
            while (true)
            {
                await GetRxData();
                DrawDotsOnUI();
                Debug.WriteLine("Task Plot: " + CCC++);
            }
        }

        private async Task GetRxData()
        {
            await Task.Run(()=>{

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

            });
        }

        private void DrawDotsOnUI()
        {
            var fp = series[1].Points;
            try
            {
                foreach (var rdata in rxDataBackup)
                {
                    for (int i = 0; i < rdata.value1.Length; i++)
                    {
                        series[0].Points.RemoveAt(0);
                        series[0].Points.AddXY(rdata.tmStamp[i], rdata.comValue[i]);

                        fp.RemoveAt(0);
                        //series[2].Points.RemoveAt(0);
                        
                        double val = rdata.value1[i];
                        Color cl = Color.Red;
                        if (WaveformReq.WaveSelected == "Series2")
                        {
                            cl = Color.Yellow;
                            val = rdata.value2[i];
                        }
                        series[1].Points.AddXY(rdata.tmStamp[i], val);
                        fp[fp.Count - 1].Color = cl;
                    }

                }

                chartArea0.AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
                chartArea0.AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
                chartArea0.RecalculateAxesScale();
                chartArea1.AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
                chartArea1.AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
                chartArea1.RecalculateAxesScale();
                chartWaveform.Invalidate();
            }
            catch (Exception e)
            {
                
                Debug.WriteLine(e.Message);
            }
        }

        
    }
}
