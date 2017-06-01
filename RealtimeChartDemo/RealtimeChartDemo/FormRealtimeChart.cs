﻿using System;
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
            int SampleRate = Convert.ToInt16(AppSettings.ReadSetting("sampleRate"));
            //int PlotLength = Convert.ToInt16(AppSettings.ReadSetting("plotLengthSecond"));
            int PlotLength = this.trackPlotLength.Value;

            SampleRate = (SampleRate == 0) ? 2000 : SampleRate;
            PlotLength = (PlotLength == 0) ? 30 : PlotLength;
            int SampleNum = SampleRate * PlotLength;

            WaveformReq.SampleNum = SampleNum;
            WaveformReq.SampleRate = SampleRate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Button startBtn = sender as Button;
            rxData = new List<RxDataContainer>();
        
            //BkgDataPlot bkgPlot = new BkgDataPlot(rxData, chartWaveform, checkBoxWaveform,"Waveform");
            BkgDataGenerate bkgGetData = new BkgDataGenerate(WaveformReq.SampleRate, rxData);
            BkgDataPlot bkgPlot1 = new BkgDataPlot(rxData, chartWaveform, checkBoxFreq1, "Series1");

            if (startBtn.Text == "Start")
            {
                startBtn.Text = "Stop";
                StopChart = false;
                bkgGetData.Stopwork = false;
                rxData.Clear();
                

                UpdateWaveformReq();

                if (!bkgGetData.IsBusy)
                {
                    bkgGetData.RunWorkerAsync();
                }
                
                //if( !bkgPlot.IsBusy )
                {
                  //  bkgPlot.RunWorkerAsync();
                }

                if (!bkgPlot1.IsBusy)
                {
                    bkgPlot1.RunWorkerAsync();
                }

                //chartUpdateTimer.Interval = 1000;
                //chartUpdateTimer.Start();

            }
            else
            {
                StopChart = true;
                startBtn.Text = "Start";
                bkgGetData.Stopwork = true;
            }

            bkgGetData.Stopwork = StopChart;
            bkgPlot1.Stopwork = StopChart;
        }

 
        private void UpdateWaveformReq()
        {
            WaveformReq.FreqSeriel1 = trackBarFreq1.Value;
            WaveformReq.FreqSeriel2 = trackBarFreq2.Value;
            WaveformReq.FreqSeriel3 = trackBarFreq3.Value;
            labelFreq1.Text = trackBarFreq1.Value.ToString();
            labelFreq2.Text = trackBarFreq2.Value.ToString();
            labelFreq3.Text = trackBarFreq3.Value.ToString();

            WaveformReq.AmpSeriel1 = trackBarAmp1.Value;
            WaveformReq.AmpSeriel2 = trackBarAmp2.Value;
            WaveformReq.AmpSeriel3 = trackBarAmp3.Value;
            labelAmp1.Text = trackBarAmp1.Value.ToString();
            labelAmp2.Text = trackBarAmp2.Value.ToString();
            labelAmp3.Text = trackBarAmp3.Value.ToString();

            WaveformReq.PhaSeriel1 = trackBarPha1.Value;
            WaveformReq.PhaSeriel2 = trackBarPha2.Value;
            WaveformReq.PhaSeriel3 = trackBarPha3.Value;
            labelPha1.Text = trackBarPha1.Value.ToString();
            labelPha2.Text = trackBarPha2.Value.ToString();
            labelPha3.Text = trackBarPha3.Value.ToString();
            WaveformReq.PlotLength = trackPlotLength.Value;
            labelPlotLength.Text = trackPlotLength.Value.ToString();
            WaveformReq.SampleNum = trackPlotLength.Value * WaveformReq.SampleRate;

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

    }
}
