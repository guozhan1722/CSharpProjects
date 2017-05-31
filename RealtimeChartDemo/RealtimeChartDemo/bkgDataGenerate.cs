using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace RealtimeChartDemo
{
    class BkgDataGenerate : BackgroundWorker
    {
        private int SampleRate;
        public bool Stopwork { get; set; }

        public List<InnerReceiverContainer> rxDataList { get; set; }
        
        private int Count;

        public BkgDataGenerate(int SampleNum, int SampleRate)
        {
            this.SampleRate = SampleRate;

            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;

            this.DoWork += BkgDataGenerate_DoWork;
            this.ProgressChanged += BkgDataGenerate_ProgressChanged;
            this.RunWorkerCompleted += BkgDataGenerate_RunWorkerCompleted;
        }

        void BkgDataGenerate_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bkw = sender as BackgroundWorker;
            try
            {
                DateTime oldtime = DateTime.Now;
                while (true)
                {
                    if (Stopwork)
                    {
                        e.Result = "User stopped !";
                        break;
                    }
                    Thread.Sleep(1000);
                    bkw.ReportProgress(Count++);
                }

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        void BkgDataGenerate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int count = (int)e.ProgressPercentage;
            Debug.WriteLine(count + "");
            double[] ser1Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, waveReq.FreqSeriel1, waveReq.AmpSeriel1, waveReq.PhaSeriel1);
            double[] ser2Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, waveReq.FreqSeriel2, waveReq.AmpSeriel2, waveReq.PhaSeriel2);
            double[] ser3Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, waveReq.FreqSeriel3, waveReq.AmpSeriel3, waveReq.PhaSeriel3);

            rxDataList.Add(new InnerReceiverContainer(ser1Part, ser2Part, ser3Part));
        }
        
        void BkgDataGenerate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
        }




        public WaveformReq waveReq { get; set; }
    }
}
