using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestChart
{
    public partial class FormChart : Form
    {
        private bool pausePlot = true;
        private List<RxDataContainer> rxDataBuf;
        private List<RxDataContainer> rxDataBufBackup;
        private const int bufferSize = 2000;
        private double[] rxData;
        private DataPointCollection points;
        private const int maxChartX = 2000;
        private int counter;

        public FormChart()
        {
            InitializeComponent();
            rxDataBuf = new List<RxDataContainer>();
            rxDataBufBackup = new List<RxDataContainer>();
            
        }

        private void backgroundWorkerRxData_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while(true)
            {
                if(pausePlot)
                {
                    break;
                }
                Thread.Sleep(1000);
                worker.ReportProgress(counter++);
            }
            e.Result = "Rx data paused !\n";
        }


        private void backgroundWorkerRxData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int count = e.ProgressPercentage;
            FillRxData();
            textBoxStatus.AppendText(count.ToString() +"------\n");
        }

        private void backgroundWorkerRxData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBoxStatus.AppendText((String)e.Result);
        }

        private void backgroundWorkerPlotData_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    if (pausePlot)
                    {
                        break;
                    }

                    while (rxDataBuf.Count <= 0)
                    {
                        Thread.Sleep(100);
                    }
                    backgroundWorkerPlotData.ReportProgress(1);
                }
            }
            catch 
            {
                
                
            }
        }

        private void backgroundWorkerPlotData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            updateChart();
        }

        private void backgroundWorkerPlotData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            if (button1.Text == "Start")
            {
                pausePlot = false;
                button1.Text = "Pause";
                RxDataBackground dataAcqBackground = new RxDataBackground(this, bufferSize);
                backgroundWorkerPlotData.RunWorkerAsync();
                backgroundWorkerRxData.RunWorkerAsync();
            }
            else
            {
                pausePlot = true;
                button1.Text = "Start";
            }

        }

        
        public void FillRxData()
        {
            rxData = new double[bufferSize];
            for (int i = 0; i < bufferSize; i++)
            {
                double degree = Math.Sin(Math.PI*(i%4)/2);
                rxData[i] = degree;
            }

            //added data in the container
            rxDataBuf.Add(new RxDataContainer(rxData));
        }

        private void updateChart()
        {
            //backup the data and release buf
            rxDataBufBackup.Clear();
            rxDataBufBackup.AddRange(rxDataBuf);
            rxDataBuf.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 10 * bufferSize;
            Series serie = chart1.Series[0];
            points = serie.Points;
            
            foreach(RxDataContainer rc in rxDataBufBackup)
            {
                int dataLen = rc.value.Length;
                double timeSpan = 1000; //-ms
                DateTime time = rc.dateEnd.AddMilliseconds(timeSpan * (-1));
                double timeSplitSize = timeSpan / (dataLen + 1);

                for (int i = 0; i < dataLen; i++)
                {
                    double v = rc.value[i];
                    DateTime t = time.AddMilliseconds(1);
                    //points.AddXY(counter * i,v);
                    points.AddXY(t.ToString("ms.fff"),v);
                }
            }
            if (points.Count > 10 * bufferSize)
            {
                int removeSize = points.Count - 10 * bufferSize;
                for (int i = 0; i < removeSize; i++)
                {
                    points.RemoveAt(0);
                }
            }

        }

    }
}
