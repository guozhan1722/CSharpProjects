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
        private Chart chartWaveform;
        private String serieName;
        private CheckBox checkBoxShow;
        public bool Stopwork { get; set; }
        private List<RxDataContainer> rxDataBackup = new List<RxDataContainer>();
        //public int count { get; set; }
        private List<double> plotBuffer = new List<double>();
        private List<DateTime> plotTimeStamp = new List<DateTime>();
        private double[] data;
        public int count { get; set; }
        private List<Complex> sample = new List<Complex>();

        public BkgDataPlot(List<RxDataContainer> rxData, Chart chartWaveform, CheckBox checkBoxShow, String serieName)
        {
            // TODO: Complete member initialization
            this.rxData = rxData;
            this.chartWaveform = chartWaveform;
            this.checkBoxShow = checkBoxShow;
            this.serieName = serieName;

            chartWaveform.ChartAreas[0].AxisX.MajorGrid.Interval = WaveformReq.SampleNum / 6;
            chartWaveform.ChartAreas[0].AxisX.Interval = WaveformReq.SampleNum / 6;
            
            DateTime timeStamp = DateTime.Now.AddMilliseconds(1000 * (-1));
            double timeSplite = 1000 / WaveformReq.SampleRate;
            for (int i = 0; i < WaveformReq.SampleNum; i++)
            {
                DateTime t = timeStamp.AddMilliseconds(timeSplite);
                plotBuffer.Add(0);
                plotTimeStamp.Add(t);
                sample.Add(new Complex());
            }

            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;

            this.DoWork += BkgDataPlot_DoWork;
            this.ProgressChanged += BkgDataPlot_ProgressChanged;
        }

        void BkgDataPlot_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int rmSize = (int)e.ProgressPercentage;
            //DoPlot();
        }

        void BkgDataPlot_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (this.Stopwork)
                {
                    break;
                }

                if(rxData.Count <= 0)
                {
                    Thread.Sleep(100);
                    continue;
                }

                MakePlotBuffer(serieName);

                DoPlot();

                //this.ReportProgress(1);
            }
        }

        
        private void MakePlotBuffer(string serieName)
        {
            lock (rxData)
            {
                rxDataBackup.Clear();
                rxDataBackup.AddRange(rxData);
                rxData.Clear();
            }

            
            foreach (var rx in rxDataBackup)
            {
                double[] waveformdata = CombineWave(rx.value1, rx.value2, rx.value3) ;
                switch (serieName)
                {
                    case "Waveform":
                        data = waveformdata;
                        break;
                    case "Series1":
                        data = rx.value1;
                        break;
                    case "Series2":
                        data = rx.value2;
                        break;
                    case "Series3":
                        data = rx.value3;
                        break;
                    default:
                        break;
                }

                this.plotBuffer.AddRange(data);

                DateTime timeStamp = rx.dateEnd.AddMilliseconds(1000 * (-1));
                double timeSplite = 1000 / WaveformReq.SampleRate;
                for (int i = 0; i < data.Length; i++)
                {
                    DateTime t = timeStamp.AddMilliseconds(timeSplite);
                    plotTimeStamp.Add(t);
                }
            }

            int diff = this.plotBuffer.Count - WaveformReq.SampleNum;
            if (diff >= 0)
            {
                for (int i = 0; i < diff; i++)
                {
                    this.plotBuffer.RemoveAt(0);
                    this.plotTimeStamp.RemoveAt(0);
                    this.sample.RemoveAt(0);
                }
            }
            else
            {
                int count = diff * (-1);
                for (int i = 0; i < count; i++)
                {
                    this.plotBuffer.Insert(0, 0);
                    this.plotTimeStamp.Insert(0, DateTime.Now);
                    this.sample.Insert(0, new Complex());
                }
            }

        }

        private double[] CombineWave(double[] p1, double[] p2, double[] p3)
        {
            double[] combinedata = new double[p1.Length];

            for (int i = 0; i < p1.Length; i++)
			{
                Complex var = new Complex(p1[i] + p1[i] + p3[i], 0);
                combinedata[i] = var.Real;
                sample.Add(var);
			}
            return combinedata;
        }

        private void DoPlot()
        {
            if (chartWaveform.InvokeRequired)
            {
                chartWaveform.Invoke(new Action(DoPlot));
                return;
            }
            
            chartWaveform.Series[serieName].Points.Clear();

            if (checkBoxShow.Checked)
            {
                chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
                chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
                chartWaveform.ChartAreas[0].RecalculateAxesScale();
            }
            else
            {
                chartWaveform.ChartAreas[0].AxisY.Maximum = 0.5; // sets the Maximum to NaN
                chartWaveform.ChartAreas[0].AxisY.Minimum = -0.5; // sets the Minimum to NaN
            }
            //DateTime timeStamp = plotTimeEnd.AddMilliseconds(1000 * (-1));
            //double timeSplite = 1000 / WaveformReq.SampleRate;

            for (int i = 0; i < plotBuffer.Count; i++)
            {
                //DateTime t = timeStamp.AddMilliseconds(timeSplite);
                //sample[i] = new Complex(rx.value1[i] + rx.value2[i] + rx.value3[i], 0);
                //double var = sample[i].Real;
                double var= plotBuffer[i];
                DateTime t = plotTimeStamp[i];
                if (!checkBoxShow.Checked)
                {
                    var = 0;
                }
                chartWaveform.Series[serieName].Points.AddXY(t.ToString("HH:mm:ss"), var);
            }

        }

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
