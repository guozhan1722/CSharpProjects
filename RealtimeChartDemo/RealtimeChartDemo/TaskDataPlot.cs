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

        private int maxPlotSize = WaveformReq.SampleRate * 60;

        private int CCC;
        private int totalRxSize;
        private ChartArea chartArea;
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
            chartArea = chartWaveform.ChartAreas[0];
            int interval = maxPlotSize / 6;

            chartArea.AxisX.MajorGrid.Interval = interval;
            chartArea.AxisX.MinorGrid.Interval = interval;
            chartArea.AxisX.Interval = interval;
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
                    serie.Points.AddXY(timeStamp.ToString("HH:mm:ss"),0);
                }
            }
            
        }

        public async void StartPlotAsyn()
        {
            while (true)
            {
                await GetRxData();
                DrawDotsOnUI();
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

            foreach (var rdata in rxDataBackup)
            {
                for (int i = 0; i < rdata.value1.Length; i++)
                {
                    series[0].Points.RemoveAt(0);
                    series[0].Points.AddXY(rdata.tmStamp[i],rdata.comValue[i]);
                    
                }
                
            }
            chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
            chartWaveform.ChartAreas[0].RecalculateAxesScale();
        }

        
    }
}
