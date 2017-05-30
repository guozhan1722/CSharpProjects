using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace FFTTest
{
    public partial class Form1 : Form
    {
        static int numSamples = 9000;

        static double sampleRate = 3000;

        Complex[] samples = new Complex[numSamples];

        public Form1()
        {
            InitializeComponent();
            updateChart();
        }

        public void updateChart()
        {
            PlotWaveform(this.trkFreq1.Value, this.trkAmp1.Value, this.trkPha1.Value, this.trkFreq2.Value, this.trkAmp2.Value, this.trkPha2.Value);
            this.labelFreq1.Text = this.trkFreq1.Value + " Hz";
            this.labelAmp1.Text = this.trkAmp1.Value.ToString();
            this.labelPha1.Text = this.trkPha1.Value.ToString();
            this.labelFreq2.Text = this.trkFreq2.Value + " Hz";
            this.labelAmp2.Text = this.trkAmp2.Value.ToString();
            this.labelPha2.Text = this.trkPha2.Value.ToString();
            PlotFFT();
        }

        private void PlotWaveform(int freq1, int amp1, int pha1, int freq2, int amp2, int pha2)
        {
            chart1.Series["Waveform"].Points.Clear();
            chart1.Series["Second"].Points.Clear();
            chart1.Series["Fundamental"].Points.Clear();

            double[] fundamental = Waveform.Sinusoidal(numSamples, sampleRate, freq1, amp1,pha1);
            double[] second = Waveform.Sinusoidal(numSamples, sampleRate, freq2, amp2, pha2);

            for (int i = 0; i < numSamples; i++)
            {
                double time = Math.Round(i / sampleRate,4);
                samples[i] = new Complex(fundamental[i] + second[i], 0);

                chart1.Series["Waveform"].Points.AddXY(time, samples[i].Real);
                if (checkBoxShowFreq1.Checked)
                {
                    chart1.Series["Fundamental"].Points.AddXY(time, fundamental[i]);
                }
                if (checkBoxShowFreq2.Checked)
                {
                    chart1.Series["Second"].Points.AddXY(time, second[i]);
                }
            }
        }


        private void PlotFFT()
        {
            Complex[] fftSamples = new Complex[numSamples];
            Array.Copy(samples, fftSamples, numSamples);
            chartFFT.Series["Frequency"].Points.Clear();
            Fourier.Forward(fftSamples,FourierOptions.NoScaling);

            for(int i=0;i<samples.Length/3;i++)
            {
                chartFFT.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
                chartFFT.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = true;

                //get the magnitude of each FFT sample:
                // = abs[Sqrt(r^2 + i2)];
                double mag = (2.0 / numSamples) * Math.Abs(Math.Sqrt(Math.Pow(fftSamples[i].Real, 2) +
                    Math.Pow(fftSamples[i].Imaginary, 2)));

                double hzPerSample = sampleRate / numSamples;

                chartFFT.Series["Frequency"].Points.AddXY(hzPerSample*i,mag);
            }
        }

        private void trkFreq_Scroll(object sender, EventArgs e)
        {
            updateChart();
        }
    }
}
