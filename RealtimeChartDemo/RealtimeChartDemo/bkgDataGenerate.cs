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

        private int Count;
        private List<RxDataContainer> rxData;
        public bool Stopwork { get; set; }

        public BkgDataGenerate(int SampleRate, List<RxDataContainer> rxData)
        {

            this.SampleRate = SampleRate;
            this.rxData = rxData;

            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;

            this.DoWork += BkgDataGenerate_DoWork;
            this.ProgressChanged += BkgDataGenerate_ProgressChanged;
            this.RunWorkerCompleted += BkgDataGenerate_RunWorkerCompleted;
        }


        void BkgDataGenerate_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    if (this.Stopwork)
                    {
                        e.Result = "User stopped !";
                        break;
                    }
                    Thread.Sleep(1000);

                    double[] ser1Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel1, WaveformReq.AmpSeriel1, WaveformReq.PhaSeriel1);
                    double[] ser2Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel2, WaveformReq.AmpSeriel2, WaveformReq.PhaSeriel2);
                    double[] ser3Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel3, WaveformReq.AmpSeriel3, WaveformReq.PhaSeriel3);

                    rxData.Add(new RxDataContainer(ser1Part, ser2Part, ser3Part));

                    this.ReportProgress(Count++);
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
            Debug.WriteLine(count + " " + this.Stopwork);
        }
        
        void BkgDataGenerate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
        }


        
    }
}
