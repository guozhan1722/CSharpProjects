using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace RealtimeChartDemo
{
    class BkgDataGenerate : BackgroundWorker
    {
        private int SampleNum;
        private int SampleRate;
        public bool Stopwork { get; set; }
        //private static int SampleSize = SampleNum;

        public double[] ser1; 
        public double[] ser2;
        public double[] ser3;
        private int Count;


        public BkgDataGenerate(int SampleNum, int SampleRate)
        {
            // TODO: Complete member initialization
            this.SampleNum = SampleNum;
            this.SampleRate = SampleRate;

            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;

            this.DoWork += BkgDataGenerate_DoWork;
            this.ProgressChanged += BkgDataGenerate_ProgressChanged;
            this.RunWorkerCompleted += BkgDataGenerate_RunWorkerCompleted;
        }

        void BkgDataGenerate_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime oldtime = DateTime.Now;
            
            while(true)
            {
                if(Stopwork)
                {
                    this.CancelAsync();
                    e.Result = "User stopped !";
                    break;
                }
                DateTime newtime = DateTime.Now;

                if (newtime.Second - oldtime.Second >= 1)
                {
                    oldtime = DateTime.Now;

                    double[] ser1Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel1, WaveformReq.AmpSeriel1, WaveformReq.PhaSeriel1);
                    double[] ser2Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel2, WaveformReq.AmpSeriel2, WaveformReq.PhaSeriel2);
                    double[] ser3Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel3, WaveformReq.AmpSeriel3, WaveformReq.PhaSeriel3);

                    DateTime[] timePart = new DateTime[SampleRate];
                    DateTime nextTime = DateTime.Now;
                    for (int i = 0; i < SampleRate;i++ )
                    {
                        timePart[i] = nextTime;
                        nextTime = nextTime.AddMilliseconds(0.5);
                    }

                    ShiftData(ser1Part, ser1);
                    ShiftData(ser2Part, ser2);
                    ShiftData(ser3Part, ser3);
                    ShiftData(timePart, time1);
                    this.ReportProgress(Count++,ser1Part);
                }
            }
        }

        private void ShiftData(DateTime[] source, DateTime[] dest)
        {
            Array.Copy(dest, SampleRate, dest, 0, SampleNum - SampleRate);
            Array.Copy(source, 0, dest, SampleNum - SampleRate, source.Length);
        }

        private void ShiftData(double[] source, double[] dest)
        {
            Array.Copy(dest, SampleRate, dest, 0, SampleNum - SampleRate);
            Array.Copy(source, 0, dest, SampleNum - SampleRate, source.Length);
        }

        void BkgDataGenerate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int count = e.ProgressPercentage;
            double[] ser = (double[])e.UserState;
            Debug.WriteLine("{0}--{1}--{2}", count.ToString(), ser[0].ToString(), ser[1].ToString());
        }
        void BkgDataGenerate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
        }


        public DateTime[] time1 { get; set; }
    }
}
