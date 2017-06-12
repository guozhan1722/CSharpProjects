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
        private Series listSeries;

        private int maxPlotSize = WaveformReq.SampleRate * 60;
        private int CCC;
        private int totalRxSize;

        private DataPoint wavePoint;

        public TaskDataPlot(List<RxDataContainer> rxData, Chart chartWaveform)
        {
            this.rxData = rxData;
            this.chartWaveform = chartWaveform;
            rxDataBackup = new List<RxDataContainer>();
            listSeries = new Series();

            InitChartAreas();
            InitSeries();
        }

        private void InitChartAreas()
        {
            var area = chartWaveform.ChartAreas[0];
            int interval = maxPlotSize / 6;

            area.AxisX.MajorGrid.Interval = interval;
            area.AxisX.MinorGrid.Interval = interval;
            area.AxisX.Interval = interval;
        }

        private void InitSeries()
        {
            chartWaveform.Series.Clear();
            chartWaveform.Series.SuspendUpdates();

            int totalLength = maxPlotSize / WaveformReq.SampleRate;
            //totalLength = 0;
            DateTime timeStamp = DateTime.Now.AddMilliseconds(1000 * totalLength * (-1));
            double timeSplite = 1000 / WaveformReq.SampleRate;
            for (int i = 0; i < maxPlotSize; i++)
            {
                timeStamp = timeStamp.AddMilliseconds(timeSplite);
                listSeries.Points.AddXY(timeStamp.ToString("HH:mm:ss"),0);
                
            }
            
        }

        public async void StartPlotAsyn()
        {
            while (true)
            {
                await GetRxData();
                await plotAsync();
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

                    totalRxSize = 0;
                    foreach (var item in rxDataBackup)
                    {
                        totalRxSize += item.value1.Length;
                    }
                    Debug.WriteLine("Task Plot First Step: " + CCC);
          
            });
        }

        private async Task plotAsync()
        {
            await Task.Run(()=>
                {
                    //listWave.RemoveRange(0, totalRxSize);
                    ///listTmStamp.RemoveRange(0, totalRxSize);
                    UpdateSeries();

                    Debug.WriteLine("Task Plot: " + CCC++);
                    
                });
        }
        Series wav;
        private void UpdateSeries()
        {
            foreach (var item in rxDataBackup)
            {
                //listWave.AddRange(item.value1);
                //listTmStamp.AddRange(item.tmStamp);
            }
            wav = new Series();
            wav.Points.SuspendUpdates();
            wav.ChartType = SeriesChartType.FastLine;
            
            //for (int i = 0; i < listWave.Count; i++)
            {
                //wav.Points.AddXY(listTmStamp[i], listWave[i]);
            }
            //wav.Points.DataBindXY(listTmStamp,listWave);
        }
        

        private void DrawDotsOnUI()
        {
            //chartWaveform.Series.Clear();

            //chartWaveform.Series.Add(wav);
            //chartWaveform.Series.Add(freq1Series);
            //chartWaveform.Series.Add(freq2Series);
            //chartWaveform.Series.Add(freq3Series);
            chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
            chartWaveform.ChartAreas[0].RecalculateAxesScale();
            //await GetRxData();
            //plotAsync();
        }

        
    }
}
