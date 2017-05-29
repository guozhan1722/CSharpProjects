using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestChart
{
    enum RxDataStatus { Unknown,Start,Working, OnProgress,Completed,Error};
    class RxDataBackground: BackgroundWorker
    {
        private FormChart formChart;
        private int bufferSize;
        public RxDataStatus DataRxStatus { get; set; }
        public bool PausePlot { get; set; }

        public int Counter { get; set; }

        public double[] rxData { get; set; }

        public RxDataBackground(FormChart formChart, int bufferSize)
        {
            // TODO: Complete member initialization
            this.formChart = formChart;
            this.bufferSize = bufferSize;
            this.WorkerReportsProgress = true;
            this.DoWork += DataAcqBackground_DoWork;
            this.ProgressChanged += DataAcqBackground_ProgressChanged;
            this.RunWorkerCompleted += DataAcqBackground_RunWorkerCompleted;
            DataRxStatus = RxDataStatus.Start; 
       }

        void DataAcqBackground_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DataRxStatus = RxDataStatus.Working;
            while (true)
            {
                if (PausePlot)
                {
                    break;
                }
                Thread.Sleep(1000);
                worker.ReportProgress(Counter++);
            }
            e.Result = "Rx data paused !\n";
        }

        void DataAcqBackground_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataRxStatus = RxDataStatus.Completed;
        }

        void DataAcqBackground_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int count = e.ProgressPercentage;
            formChart.FillRxData();
            DataRxStatus = RxDataStatus.OnProgress;
            
        }

        private void FillRxData()
        {
            rxData = new double[bufferSize];
            for (int i = 0; i < bufferSize; i++)
            {
                double degree = Math.Sin(Math.PI * (i % 4) / 2);
                rxData[i] = degree;
            }
        }


    }
}
