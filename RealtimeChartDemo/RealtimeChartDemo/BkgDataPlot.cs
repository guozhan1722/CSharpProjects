using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.ComponentModel;
using System.Numerics;
using System.Diagnostics;
using System.Threading;

namespace RealtimeChartDemo
{
    class BkgDataPlot : BackgroundWorker
    {
        private List<RxDataContainer> rxData;
        private List<RxDataContainer> rxDataBackup;
        private Chart chartWaveform;
        private int count;

        private int maxPlotSize = WaveformReq.SampleRate * 60;
        
        public BkgDataPlot(List<RxDataContainer> rxData, Chart chartWaveform)
        {
            this.rxData = rxData;
            this.chartWaveform = chartWaveform;

            InitChartAreas();

            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;

            this.DoWork += BkgDataPlot_DoWork;
            this.ProgressChanged += BkgDataPlot_ProgressChanged;
            rxDataBackup = new List<RxDataContainer>();

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

        void BkgDataPlot_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int rmSize = (int)e.ProgressPercentage;
            DoPlot(WaveformReq.WaveSelected, true);
        }

        void BkgDataPlot_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (WaveformReq.StopGenerate)
                {
                    break;
                }

                if (rxData.Count <= 0)
                {
                    Thread.Sleep(200);
                    continue;
                }
                this.ReportProgress(1);
            }
        }

        
        private void DoPlot(String serieName, bool show)
        {
            lock (rxData)
            {
                rxDataBackup.Clear();
                rxDataBackup.AddRange(rxData);
                rxData.Clear();
            }
            
            int total =0;
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
            var dot = chartWaveform.Series[0].Points;
            dot.SuspendUpdates();
            foreach (var item in rxDataBackup)
            {

                DateTime timeStamp = item.dateEnd.AddMilliseconds(1000 * (-1));
                double timeSplite = 1000 / WaveformReq.SampleRate;

                for (int i = 0; i < item.value1.Length; i++)
                {
                    DateTime t = timeStamp.AddMilliseconds(timeSplite);
                    Complex samp = new Complex(item.value1[i] + item.value2[i], 0);
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
                        default:
                            break;

                    }
                    dot.AddXY(t.ToString("HH:mm:ss"), w);
                    chartWaveform.Series[1].Points.AddXY(t.ToString("HH:mm:ss"), f1);
                    chartWaveform.Series[3].Points.AddXY(t.ToString("HH:mm:ss"), f3);
                }
                Process proc = Process.GetCurrentProcess();
                Debug.WriteLine("Plot: " + serieName + "--" + count++ + "->" + proc.PrivateMemorySize64);

                chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
                chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
                chartWaveform.ChartAreas[0].RecalculateAxesScale();


            }
            dot.ResumeUpdates();
            
        }



        //private void DoPlot(String serieName,bool show)
        //{
        //    //if (chart1.InvokeRequired)
        //    {
        //        //chart1.Invoke(new Action(DoPlot));
        //        //return;
        //    }
            
        //    List<double> list = null;

        //    switch (serieName)
        //    {
        //        case "Waveform":
        //            list = bufferWaveform;
        //            break;
        //        case "Series1":
        //            list = bufferFreq1;
        //            break;
        //        case "Series2":
        //            list = bufferFreq2;
        //            break;
        //        case "Series3":
        //            list = bufferFreq3;
        //            break;
        //        default:
        //            list = bufferWaveform;
        //            break;
        //    }

        //    int diff = chartWaveform.Series[serieName].Points.Count - WaveformReq.SampleNum + list.Count;

        //    Process proc = Process.GetCurrentProcess();
        //    Debug.WriteLine("Plot: "+serieName+" " + count++ + "--- " + bufferComplex.Count+ "--"+diff+"=="+ proc.PrivateMemorySize64);

        //    if (diff > 0)
        //    {
        //        for (int j = 0; j < diff; j++)
        //        {
        //            chartWaveform.Series[serieName].Points.RemoveAt(0);
        //        }
        //    }

        //    //chart1.Series[serieName].Points.Clear();

        //    chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
        //    chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
        //    chartWaveform.ChartAreas[0].RecalculateAxesScale();
        //    //DateTime timeStamp = plotTimeEnd.AddMilliseconds(1000 * (-1));
        //    //double timeSplite = 1000 / WaveformReq.SampleRate;

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        //DateTime t = timeStamp.AddMilliseconds(timeSplite);
        //        //sample[i] = new Complex(rx.value1[i] + rx.value2[i] + rx.value3[i], 0);
        //        //double var = sample[i].Real;
        //        var t = plotTimeStamp[i];
        //        double sample = 0;
        //        if (show)
        //        {
        //            sample = list[i];
        //        }
        //        chartWaveform.Series[serieName].Points.AddXY(t.ToString("HH:mm:ss"), sample);
        //    }
        //}

        //private void DoPlot()
        //{
        //    if (chartWaveform.InvokeRequired)
        //    {
        //        chartWaveform.Invoke(new Action(DoPlot));
        //        return;
        //    }

        //    chartWaveform.ChartAreas["ChartArea1"].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
        //    chartWaveform.ChartAreas["ChartArea1"].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
        //    chartWaveform.ChartAreas["ChartArea1"].RecalculateAxesScale();

        //    Complex[] sample = new Complex[WaveformReq.SampleRate];

        //    foreach (var rx in rxDataBackup)
        //    {
        //        DateTime timeStamp = rx.dateEnd.AddMilliseconds(1000 * (-1));
        //        double timeSplite = 1000 / WaveformReq.SampleRate;

        //        for (int i = 0; i < WaveformReq.SampleRate; i++)
        //        {
        //            DateTime t = timeStamp.AddMilliseconds(timeSplite);
        //            sample[i] = new Complex(rx.value1[i] + rx.value2[i] + rx.value3[i], 0);
        //            double var = sample[i].Real;

        //            if (!this.checkBoxWaveform.Checked)
        //            {
        //                var = 0;
        //            }
        //            chartWaveform.Series[0].Points.AddXY(t.ToString("HH:mm:ss"), var);
        //        }

        //    }
        //    //int rmSize = chartWaveform.Series[0].Points.Count - WaveformReq.SampleNum;
        //    //if (rmSize > 0)
        //    //{
        //    //    for (int i = 0; i < rmSize; i++)
        //    //    {
        //    //        chartWaveform.Series[0].Points.RemoveAt(0);
        //    //    }
        //    //}

        //    //this.ReportProgress(count);
        //}
    }
}
