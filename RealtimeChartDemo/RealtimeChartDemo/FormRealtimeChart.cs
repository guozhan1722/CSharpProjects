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
        private List<InnerReceiverContainer> rxData;
        private List<InnerReceiverContainer> rxDataBackup;
        WaveformReq waveReq;

        public static int SampleRate { get; set; }
        public static int SampleNum { get; set; }

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
            
            Button startBtn = sender as Button;
            
            if (startBtn.Text == "Start")
            {
                rxData = new List<InnerReceiverContainer>();
                rxDataBackup = new List<InnerReceiverContainer>();
                waveReq = new WaveformReq();
                
                bkgGetData= new BkgDataGenerate(SampleNum, SampleRate);
                startBtn.Text = "Stop";
                StopChart = false;
                UpdateWaveformReq();
                bkgGetData.waveReq = waveReq;

                bkgGetData.rxDataList = rxData;

                if (!bkgGetData.IsBusy)
                {
                    bkgGetData.RunWorkerAsync();
                }

                chartUpdateTimer.Start();
            }
            else
            {
                StopChart = true;
                startBtn.Text = "Start";
            }

            bkgGetData.Stopwork = StopChart;
        }

        private void UpdateWaveformReq()
        {
            waveReq.FreqSeriel1 = trackBarFreq1.Value;
            waveReq.FreqSeriel2 = trackBarFreq2.Value;
            waveReq.FreqSeriel3 = trackBarFreq3.Value;
            labelFreq1.Text = trackBarFreq1.Value.ToString();
            labelFreq2.Text = trackBarFreq2.Value.ToString();
            labelFreq3.Text = trackBarFreq3.Value.ToString();

            waveReq.AmpSeriel1 = trackBarAmp1.Value;
            waveReq.AmpSeriel2 = trackBarAmp2.Value;
            waveReq.AmpSeriel3 = trackBarAmp3.Value;
            labelAmp1.Text = trackBarAmp1.Value.ToString();
            labelAmp2.Text = trackBarAmp2.Value.ToString();
            labelAmp3.Text = trackBarAmp3.Value.ToString();

            waveReq.PhaSeriel1 = trackBarPha1.Value;
            waveReq.PhaSeriel2 = trackBarPha2.Value;
            waveReq.PhaSeriel3 = trackBarPha3.Value;
            labelPha1.Text = trackBarPha1.Value.ToString();
            labelPha2.Text = trackBarPha2.Value.ToString();
            labelPha3.Text = trackBarPha3.Value.ToString();

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
            lock (rxData)
            {
                rxDataBackup.Clear();
                rxDataBackup.AddRange(rxData);
                rxData.Clear();
            }
            chartWaveform.ChartAreas["ChartArea1"].AxisX.MajorGrid.Interval = SampleNum / 10;
            chartWaveform.ChartAreas["ChartArea1"].AxisX.Interval = SampleNum / 10;
            
            chartWaveform.ChartAreas["ChartArea1"].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            chartWaveform.ChartAreas["ChartArea1"].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
            foreach(var rx in rxDataBackup)
            {
                DateTime timeStamp = rx.dateEnd.AddMilliseconds(1000 * (-1));
                double timeSplite = 1000 / SampleRate;

                sample = new Complex[SampleNum];
                for (int i = 0; i < SampleRate; i++)
                {
                    DateTime t = timeStamp.AddMilliseconds(timeSplite);
                    sample[i] = new Complex(rx.value1[i] + rx.value2[i] + rx.value3[i], 0);

                    chartWaveform.Series["Waveform"].Points.AddXY(t.ToString("HH:mm:ss"), sample[i].Real);

                }

            }

            if (chartWaveform.Series["Waveform"].Points.Count > SampleNum)
            {
                int rmSize = chartWaveform.Series["Waveform"].Points.Count - SampleNum;
                for (int i = 0; i < rmSize; i++)
                {
                    chartWaveform.Series["Waveform"].Points.RemoveAt(0);
                }
            }

            chartWaveform.ChartAreas["ChartArea1"].RecalculateAxesScale();

        }

    }
}
