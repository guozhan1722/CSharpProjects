using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RealtimeChartDemo
{
    public partial class FormRealtimeChart : Form
    {
        private List<RxDataContainer> rxData;
        public bool StopChart { get; set; }

        public FormRealtimeChart()
        {
            InitializeComponent();
            GetSettings();

        }

        private void GetSettings()
        {
            int SampleRate = Convert.ToInt32(AppSettings.ReadSetting("sampleRate"));
            //int PlotLength = Convert.ToInt16(AppSettings.ReadSetting("plotLengthSecond"));
            int PlotLength = 60;

            SampleRate = (SampleRate == 0) ? 2000 : SampleRate;
            PlotLength = (PlotLength == 0) ? 30 : PlotLength;
            int SampleNum = SampleRate * PlotLength;

            WaveformReq.SampleNum = SampleNum;
            WaveformReq.SampleRate = SampleRate;
        }

        BkgDataGenerate bkgGetData;
        //BkgDataPlot bkgPlot1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Button startBtn = sender as Button;
            rxData = new List<RxDataContainer>();
        
            if (startBtn.Text == "Start")
            {
                startBtn.Text = "Stop";
                StopChart = false;
                UpdateWaveformReq();
                //chartUpdateTimer.Interval = 1000;
                //chartUpdateTimer.Start();
            }
            else
            {
                StopChart = true;
                startBtn.Text = "Start";
            }

            WaveformReq.StopGenerate = StopChart;
            if(!StopChart)
            {
                TaskDataRx taskRx = new TaskDataRx(rxData);
                taskRx.StartRx();
                //bkgGetData = new BkgDataGenerate(WaveformReq.SampleRate, rxData);
                //if (!bkgGetData.IsBusy)
                {
                //    bkgGetData.RunWorkerAsync();
                }
                //BkgDataPlot bkg1 = new BkgDataPlot(rxData, chartWaveform);
                //bkg1.RunWorkerAsync();

                TaskDataPlot tp = new TaskDataPlot(rxData, chartWaveform);
                tp.StartPlotAsyn();
            }
            
           // bkgPlot1.Stopwork = StopChart;
        }

 
        private void UpdateWaveformReq()
        {
            WaveformReq.FreqSeriel1 = trackBarFreq1.Value;
            WaveformReq.FreqSeriel2 = trackBarFreq2.Value;
            labelFreq1.Text = trackBarFreq1.Value.ToString();
            labelFreq2.Text = trackBarFreq2.Value.ToString();

            WaveformReq.AmpSeriel1 = trackBarAmp1.Value;
            WaveformReq.AmpSeriel2 = trackBarAmp2.Value;
            labelAmp1.Text = trackBarAmp1.Value.ToString();
            labelAmp2.Text = trackBarAmp2.Value.ToString();

            WaveformReq.PhaSeriel1 = trackBarPha1.Value;
            WaveformReq.PhaSeriel2 = trackBarPha2.Value;
            labelPha1.Text = trackBarPha1.Value.ToString();
            labelPha2.Text = trackBarPha2.Value.ToString();

            if (radioButtonWaveform.Checked)
            {
                WaveformReq.WaveSelected = "Waveform";
            }
            else if(radioButtonFreq1.Checked)
            {
                WaveformReq.WaveSelected = "Series1";
            }
            else if(radioButtonFreq2.Checked)
            {
                WaveformReq.WaveSelected = "Series2";
            }
        }

        private void trackBarAmp1_Scroll(object sender, EventArgs e)
        {
            UpdateWaveformReq();
        }

        private void chartUpdateTimer_Tick(object sender, EventArgs e)
        {
            DrawChart(chartWaveform);
        }

        private void DrawChart(System.Windows.Forms.DataVisualization.Charting.Chart chartWaveform)
        {

        }

        private void chartWaveform_Click(object sender, EventArgs e)
        {

        }


    }
}
