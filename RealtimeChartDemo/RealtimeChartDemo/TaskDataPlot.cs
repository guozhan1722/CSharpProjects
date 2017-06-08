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
        private Task plotTask;
        private List<RxDataContainer> rxDataBackup;

        private int maxPlotSize = WaveformReq.SampleRate * 60;

        public TaskDataPlot(List<RxDataContainer> rxData, Chart chartWaveform)
        {

            this.rxData = rxData;
            this.chartWaveform = chartWaveform;
            rxDataBackup = new List<RxDataContainer>();
            InitChartAreas();
            Task t = Task.Run(()=>DoPlot(WaveformReq.WaveSelected,true));

            //plotTask = Task.Factory.StartNew(()=>DoPlot(WaveformReq.WaveSelected,true), TaskCreationOptions.LongRunning);
            
        }

        private async Task DoPlot(string serieName, bool show)
        {
            if(chartWaveform.InvokeRequired)
            {
                chartWaveform.Invoke(new Func<string, bool, Task>(DoPlot), new object[] { serieName,show});
                return;
            }
                if (rxData.Count <= 0)
                {
                    Thread.Sleep(500);
                    //continue;
                }

                lock (rxData)
                {
                    rxDataBackup.Clear();
                    rxDataBackup.AddRange(rxData);
                    rxData.Clear();
                }

                int total = 0;
                foreach (var item in rxDataBackup)
                {
                    total += item.value1.Length;
                }

                int diff = chartWaveform.Series[serieName].Points.Count - maxPlotSize + total;
                if (diff > 0)
                {
                    for (int j = 0; j < diff; j++)
                    {
                        chartWaveform.Series[0].Points.RemoveAt(0);
                    }
                }

                await mainPlot(serieName);
                Task t = Task.Run(() => DoPlot(WaveformReq.WaveSelected, true));

//             plotTask = Task.Run(() => DoPlot(WaveformReq.WaveSelected, true),TaskCreationOptions.LongRunning);
        }

        private async Task mainPlot(string serieName)
        {
            foreach (var item in rxDataBackup)
            {

                DateTime timeStamp = item.dateEnd.AddMilliseconds(1000 * (-1));
                double timeSplite = 1000 / WaveformReq.SampleRate;
                for (int i = 0; i < item.value1.Length; i++)
                {
                    DateTime t = timeStamp.AddMilliseconds(timeSplite);
                    Complex samp = new Complex(item.value1[i] + item.value2[i] + item.value3[i], 0);
                    double w = samp.Real;

                    double f1 = 0;
                    double f2 = 0;
                    double f3 = 0;
                    switch (serieName)
                    {
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
                    
                    chartWaveform.Series[0].Points.AddXY(t.ToString("HH:mm:ss"), w);
                    //chartWaveform.Series[2].Points.AddXY(t.ToString("HH:mm:ss"), f2);
                    //chartWaveform.Series[3].Points.AddXY(t.ToString("HH:mm:ss"), f3);
                }

                Process proc = Process.GetCurrentProcess();
                Debug.WriteLine("Plot: " + serieName + "--" + count++ + "->" + proc.PrivateMemorySize64);

                chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
                chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
                chartWaveform.ChartAreas[0].RecalculateAxesScale();

                
            }
            
        }

        private void InitChartAreas()
        {
            chartWaveform.ChartAreas[0].AxisX.MajorGrid.Interval = maxPlotSize / 6;
            chartWaveform.ChartAreas[0].AxisX.MinorGrid.Interval = maxPlotSize / 6;
            chartWaveform.ChartAreas[0].AxisX.Interval = maxPlotSize / 6;

            int totalLength = maxPlotSize / WaveformReq.SampleRate;
            //totalLength = 0;
            DateTime timeStamp = DateTime.Now.AddMilliseconds(1000 * totalLength * (-1));
            double timeSplite = 1000 / WaveformReq.SampleRate;
            for (int i = 0; i < maxPlotSize; i++)
            {
                DateTime t = timeStamp.AddMilliseconds(timeSplite);
                chartWaveform.Series[0].Points.AddXY(t.ToString("HH:mm:ss"), 0);
            }

        }

        internal void Start()
        {
            if (plotTask != null)
            {
                //plotTask.Start();
            }
        }

        public int count { get; set; }
    }
}
