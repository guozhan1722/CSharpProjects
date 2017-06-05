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
        private List<Complex> bufferComplex;
        private List<double> bufferFreq1;
        private List<double> bufferFreq2;
        private List<double> bufferFreq3;
        private List<DateTime> plotTimeStamp;
        private Chart chartWaveform;
        private int count;
        private List<double> bufferWaveform;

        public BkgDataPlot(List<RxDataContainer> rxData, Chart chartWaveform)
        {
            // TODO: Complete member initialization
            this.rxData = rxData;
            this.chartWaveform = chartWaveform;

            InitChartAreas();
            InitBuffers();

            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;

            this.DoWork += BkgDataPlot_DoWork;
            this.ProgressChanged += BkgDataPlot_ProgressChanged;

        }

        private void InitBuffers()
        {
            rxDataBackup = new List<RxDataContainer>();
            plotTimeStamp = new List<DateTime>();
            bufferComplex = new List<Complex>();
            bufferFreq1 = new List<double>();
            bufferFreq2 = new List<double>();
            bufferFreq3 = new List<double>();
            bufferWaveform = new List<double>();
        }

        private void InitChartAreas()
        {
            chartWaveform.ChartAreas[0].AxisX.MajorGrid.Interval = WaveformReq.SampleNum / 6;
            chartWaveform.ChartAreas[0].AxisX.Interval = WaveformReq.SampleNum / 6;

            //chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            //chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
            //chartWaveform.ChartAreas[0].RecalculateAxesScale();

            int totalLength = WaveformReq.SampleNum / WaveformReq.SampleRate;
            totalLength = 0;
            DateTime timeStamp = DateTime.Now.AddMilliseconds(1000 * totalLength * (-1));
            double timeSplite = 1000 / WaveformReq.SampleRate;
            for (int i = 0; i < WaveformReq.SampleNum; i++)
            {
                DateTime t = timeStamp.AddMilliseconds(timeSplite);
                chartWaveform.Series[0].Points.AddXY(t.ToString("HH:mm:ss"), 0);
                chartWaveform.Series[1].Points.AddY( 0);
                chartWaveform.Series[2].Points.AddY( 0);
                chartWaveform.Series[3].Points.AddY( 0);
            }
        }

        void BkgDataPlot_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int rmSize = (int)e.ProgressPercentage;
            
            
            //DoPlot("Waveform",true);
            DoPlot(WaveformReq.WaveSelected, true);
            //DoPlot("Series1",true);

            CleanupBuffer();
            //DoPlot();
        }

        private void CleanupBuffer()
        {
            bufferFreq1.Clear();
            bufferFreq2.Clear();
            bufferFreq3.Clear();
            bufferWaveform.Clear();
            plotTimeStamp.Clear();
            bufferComplex.Clear();
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
                    Thread.Sleep(500);
                    continue;
                }
                MakePlotBuffer();
                //DoPlot();
                this.ReportProgress(1);
            }
        }

        private void MakePlotBuffer()
        {
            lock (rxData)
            {
                rxDataBackup.Clear();
                rxDataBackup.AddRange(rxData);
                rxData.Clear();
            }

            foreach (var rx in rxDataBackup)
            {
                bufferFreq1.AddRange(rx.value1);
                bufferFreq2.AddRange(rx.value2);
                bufferFreq3.AddRange(rx.value3);
                bufferComplex.AddRange(ConvToComplex(rx.value1, rx.value2, rx.value3));
                bufferWaveform.AddRange(ConvComplexToDouble(bufferComplex));

                DateTime timeStamp = rx.dateEnd.AddMilliseconds(1000 * (-1));
                double timeSplite = 1000 / WaveformReq.SampleRate;
                for (int i = 0; i < rx.value1.Length; i++)
                {
                    DateTime t = timeStamp.AddMilliseconds(timeSplite);
                    plotTimeStamp.Add(t);
                }
            }
        }

        List<double> ConvComplexToDouble(List<Complex> bufferComplex)
        {
            List<double> tmp = new List<double>();
            foreach (var com in bufferComplex)
            {
                tmp.Add(com.Real);
            }
            return tmp;
        }

        private List<Complex> ConvToComplex(double[] p1, double[] p2, double[] p3)
        {
            List<Complex> sample = new List<Complex>();

            for (int i = 0; i < p1.Length; i++)
            {
                Complex var = new Complex(p1[i] + p2[i] + p3[i], 0);
                sample.Add(var);
            }
            return sample;
        }


        private void DoPlot(String serieName, bool show)
        {
            //if (chart1.InvokeRequired)
            {
                //chart1.Invoke(new Action(DoPlot));
                //return;
            }

            int diff = chartWaveform.Series[serieName].Points.Count - WaveformReq.SampleNum + bufferWaveform.Count;

            Process proc = Process.GetCurrentProcess();
            Debug.WriteLine("Plot: " + serieName + " " + count++ + "--- " + bufferComplex.Count + "--" + diff + "==" + proc.PrivateMemorySize64);

            if (diff > 0)
            {
                for (int j = 0; j < diff; j++)
                {
                    chartWaveform.Series[0].Points.RemoveAt(0);
                    chartWaveform.Series[1].Points.RemoveAt(0);
                    chartWaveform.Series[2].Points.RemoveAt(0);
                    chartWaveform.Series[3].Points.RemoveAt(0);
                }
            }

            //chart1.Series[serieName].Points.Clear();

            chartWaveform.ChartAreas[0].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            chartWaveform.ChartAreas[0].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
            chartWaveform.ChartAreas[0].RecalculateAxesScale();
            //DateTime timeStamp = plotTimeEnd.AddMilliseconds(1000 * (-1));
            //double timeSplite = 1000 / WaveformReq.SampleRate;

            for (int i = 0; i < bufferWaveform.Count; i++)
            {
                //DateTime t = timeStamp.AddMilliseconds(timeSplite);
                //sample[i] = new Complex(rx.value1[i] + rx.value2[i] + rx.value3[i], 0);
                //double var = sample[i].Real;
                var t = plotTimeStamp[i];

                double w = 0;
                double f1 = 0;
                double f2 = 0;
                double f3 = 0;
                switch (serieName)
                {
                    case "Waveform":
                        w = bufferWaveform[i];
                        break;
                    case "Series1":
                        f1 = bufferFreq1[i];
                        break;
                    case "Series2":
                        f2 = bufferFreq2[i];
                        break;
                    case "Series3":
                        f3 = bufferFreq3[i];
                        break;
                    default:
                        break;

                }
                chartWaveform.Series[0].Points.AddXY(t.ToString("HH:mm:ss"), w);
                chartWaveform.Series[1].Points.AddXY(t.ToString("HH:mm:ss"), f1);
                chartWaveform.Series[2].Points.AddXY(t.ToString("HH:mm:ss"), f2);
                chartWaveform.Series[3].Points.AddXY(t.ToString("HH:mm:ss"), f3);
            }
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
