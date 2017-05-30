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
        public static int SampleRate { get; set; }
        public static int SampleNum { get; set; }

        public double[] serie1;
        public double[] serie2;
        public double[] serie3; 
        public DateTime[] timeStamps;
        public Complex[] sample;

        BkgDataGenerate bkgGetData;

        public bool StopChart { get; set; }

        public FormRealtimeChart()
        {
            InitializeComponent();
            GetSettings();
        }

        private void GetSettings()
        {
            SampleRate = Convert.ToInt16(AppSettings.ReadSetting("sampleRate"));
            SampleNum = Convert.ToInt16(AppSettings.ReadSetting("sampleNum"));

            SampleRate = (SampleRate == 0) ? 2000 : SampleRate;
            SampleNum = (SampleNum == 0) ? 4000 : SampleNum;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.button1.Text == "Start")
            {
                this.button1.Text = "Stop";
                StopChart = false;
                UpdateWaveformReq();
                bkgGetData = new BkgDataGenerate(SampleNum,SampleRate);
                serie1 = new double[SampleNum];
                serie2 = new double[SampleNum];
                serie3 = new double[SampleNum];
                timeStamps = new DateTime[SampleNum];
                bkgGetData.ser1 = serie1;
                bkgGetData.ser2 = serie2;
                bkgGetData.ser3 = serie3;
                bkgGetData.time1 = timeStamps;

                bkgGetData.Stopwork = StopChart;
                if (!bkgGetData.IsBusy)
                {
                    bkgGetData.RunWorkerAsync();
                }
                UpdateWaveformReq();
                chartUpdateTimer.Start();
            }
            else
            {
                StopChart = true;
                bkgGetData.Stopwork = StopChart;
                this.button1.Text = "Start";
            }
           
        }

        private void UpdateWaveformReq()
        {
            WaveformReq.FreqSeriel1 = trackBarFreq1.Value;
            WaveformReq.FreqSeriel2 = trackBarFreq2.Value;
            WaveformReq.FreqSeriel3 = trackBarFreq3.Value;

            WaveformReq.AmpSeriel1 = trackBarAmp1.Value;
            WaveformReq.AmpSeriel2 = trackBarAmp2.Value;
            WaveformReq.AmpSeriel3 = trackBarAmp3.Value;

            WaveformReq.PhaSeriel1 = trackBarPha1.Value;
            WaveformReq.PhaSeriel2 = trackBarPha2.Value;
            WaveformReq.PhaSeriel3 = trackBarPha3.Value;

            chartUpdateTimer.Interval = (int)trackBarRefresh.Value;
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
            //chartWaveform.Series["Waveform"].Points.Clear();
            //chartWaveform.Series["Series1"].Points.Clear();
            //chartWaveform.Series["Series2"].Points.Clear();
            //chartWaveform.Series["Series3"].Points.Clear();
            //sample = new Complex[SampleNum];
            for(int i=0;i<SampleNum;i++)
            {
                sample[i] = new Complex(serie1[i] + serie2[i] + serie3[i], 0);

                chartWaveform.Series["Waveform"].Points.AddXY(timeStamps[i].ToString("ss:ff"), sample[i].Real);
            }
        }

    }
}
