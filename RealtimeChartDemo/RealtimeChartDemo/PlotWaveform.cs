using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
using System.Diagnostics;


namespace RealtimeChartDemo
{
    public delegate void FreshChart(object obj);
    
    class PlotWaveform
    {
        private static Mutex mtu = new Mutex();
        private Chart chartWaveform;
        private string seriesName;
        private List<InnerReceiverContainer> rxData;
        private List<InnerReceiverContainer> rxDataBackup = new List<InnerReceiverContainer>();


        public PlotWaveform(Chart chartWaveform, string seriesName, List<InnerReceiverContainer> rxData)
        {
            // TODO: Complete member initialization
            this.chartWaveform = chartWaveform;
            this.seriesName = seriesName;
            this.rxData = rxData;
        }

        public void plot()
        {
            Thread plotThread = new Thread(new ParameterizedThreadStart(DoPlot));
            plotThread.Start(seriesName);
        }

        private void DoPlot(object obj)
        {
                lock (rxData)
                {
                    rxDataBackup.Clear();
                    rxDataBackup.AddRange(rxData);
                    rxData.Clear();
                }
                mtu.WaitOne();
                UpdateChart(obj);
                mtu.ReleaseMutex();
            }

        private void UpdateChart(object obj)
        {
            
            if (chartWaveform.InvokeRequired)
            {
                FreshChart u = new FreshChart(UpdateChart);
                chartWaveform.Invoke(u, new object[] { obj });
            }
            else
            {
                chartWaveform.ChartAreas["ChartArea1"].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
                chartWaveform.ChartAreas["ChartArea1"].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN

                Complex[] sample = new Complex[SampleRate];
                Debug.WriteLine("this is thread for " + (String)obj + "-" + ckboxFreq1.Checked + "-" + ckboxFreq2.Checked + "-" + ckboxFreq3.Checked);
                foreach (var rx in rxDataBackup)
                {
                    DateTime timeStamp = rx.dateEnd.AddMilliseconds(1000 * (-1));
                    double timeSplite = 1000 / SampleRate;

                    for (int i = 0; i < SampleRate; i++)
                    {
                        DateTime t = timeStamp.AddMilliseconds(timeSplite);
                        double var = 0;

                        if ((String)obj == "Series1" && ckboxFreq1.Checked)
                        {
                            var = rx.value1[i];
                        }
                        else if ((String)obj == "Series2" && ckboxFreq2.Checked)
                        {
                            var = rx.value2[i];
                        }
                        else if ((String)obj == "Series3" && ckboxFreq3.Checked)
                        {
                            var = rx.value3[i];
                        }
                        else if ((String)obj == "Waveform" && ckboxWave.Checked)
                        {
                            sample[i] = new Complex(rx.value1[i] + rx.value2[i] + rx.value3[i], 0);
                            var = sample[i].Real;
                        }
                        chartWaveform.Series[(String)obj].Points.AddXY(t.ToString("HH:mm:ss"), var);
                    }
                }
                Debug.WriteLine("this is thread for " + (String)obj + "-" + ckboxFreq1.Checked + "-" + ckboxFreq2.Checked + "-" + ckboxFreq3.Checked);

                if (chartWaveform.Series[(String)obj].Points.Count > SampleNum)
                {
                    int rmSize = chartWaveform.Series[(String)obj].Points.Count - SampleNum;
                    for (int i = 0; i < rmSize; i++)
                    {
                        chartWaveform.Series[(String)obj].Points.RemoveAt(0);
                    }
                }
                chartWaveform.ChartAreas["ChartArea1"].RecalculateAxesScale();
            }
        }

        public int SampleRate { get; set; }

        public int SampleNum { get; set; }

        public CheckBox ckboxWave { get; set; }
        public CheckBox ckboxFreq1 { get; set; }

        public CheckBox ckboxFreq2 { get; set; }
        public CheckBox ckboxFreq3 { get; set; }
    }
}
