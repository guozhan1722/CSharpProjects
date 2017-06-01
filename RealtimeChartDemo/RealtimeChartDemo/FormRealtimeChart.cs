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
        WaveformReq waveReq = new WaveformReq();
        private List<InnerReceiverContainer> rxDataBackup = new List<InnerReceiverContainer>();
        public static int SampleRate { get; set; }
        public static int SampleNum { get; set; }

        public Complex[] sample;

        BkgDataGenerate bkgGetData;
        //waveReq = new WaveformReq();

        public bool StopChart { get; set; }

        public FormRealtimeChart()
        {
            InitializeComponent();
            GetSettings();
            ChartInit(chartWaveform);

            rxData = new List<InnerReceiverContainer>();

            bkgGetData = new BkgDataGenerate(SampleNum, SampleRate);

        }

        private void GetSettings()
        {
            SampleRate = Convert.ToInt16(AppSettings.ReadSetting("sampleRate"));
            int PlotLength = Convert.ToInt16(AppSettings.ReadSetting("plotLengthSecond"));

            SampleRate = (SampleRate == 0) ? 2000 : SampleRate;
            PlotLength = (PlotLength == 0) ? 30 : PlotLength;
            SampleNum = SampleRate * PlotLength;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Button startBtn = sender as Button;
            
            if (startBtn.Text == "Start")
            {
                startBtn.Text = "Stop";
                StopChart = false;
                rxData.Clear();
                

                UpdateWaveformReq();
                bkgGetData.waveReq = waveReq;

                bkgGetData.rxDataList = rxData;

                if (!bkgGetData.IsBusy)
                {
                    bkgGetData.RunWorkerAsync();
                }
                
                chartUpdateTimer.Interval = 1000;
                chartUpdateTimer.Start();
            }
            else
            {
                StopChart = true;
                startBtn.Text = "Start";
            }

            bkgGetData.Stopwork = StopChart;
        }

        private void ChartInit(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Interval = SampleNum / 6;
            chart.ChartAreas["ChartArea1"].AxisX.Interval = SampleNum / 6;
            DateTime timeStamp = DateTime.Now.AddMilliseconds(1000 * (-1));
            double timeSplite = 1000 / SampleRate;

            for (int i = 0; i < SampleNum; i++)
            {
                DateTime t = timeStamp.AddMilliseconds(timeSplite);

                chartWaveform.Series["Waveform"].Points.AddXY(t.ToString("HH:mm:ss"), 0);
                //chartWaveform.Series["Series1"].Points.AddXY(t.ToString("HH:mm:ss"), 0);
                //chartWaveform.Series["Series2"].Points.AddXY(t.ToString("HH:mm:ss"), 0);
                //chartWaveform.Series["Series3"].Points.AddXY(t.ToString("HH:mm:ss"), 0);
            }

        }


        private void UpdateWaveformReq()
        {
            waveReq.FreqSeriel1 = this.trackBarFreq1.Value;
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

            chartWaveform.ChartAreas["ChartArea1"].AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
            chartWaveform.ChartAreas["ChartArea1"].AxisY.Minimum = Double.NaN; // sets the Minimum to NaN

            sample = new Complex[SampleRate];

            foreach (var rx in rxDataBackup)
            {
                DateTime timeStamp = rx.dateEnd.AddMilliseconds(1000 * (-1));
                double timeSplite = 1000 / SampleRate;

                for (int i = 0; i < SampleRate; i++)
                {
                    DateTime t = timeStamp.AddMilliseconds(timeSplite);
                    sample[i] = new Complex(rx.value1[i] + rx.value2[i] + rx.value3[i], 0);
                    double var = sample[i].Real;

                    if (!this.checkBoxWaveform.Checked)
                    {
                        var = 0;
                    }
                    chartWaveform.Series["Waveform"].Points.AddXY(t.ToString("HH:mm:ss"), var);
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
