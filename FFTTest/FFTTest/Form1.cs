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
        static int numSamples = 1000;

        static double sampleRate = 2000;

        static int magSecond;
        static int PHSecond;
        static int PhThird;

        Complex[] samples = new Complex[numSamples];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PlotWaveform(0,0,0,0);
        }


        private void PlotWaveform(int secondHarm, int thirdHarm, int secondPH, int thirdPH)
        {
            chart1.Series["Waveform"].Points.Clear();
            chart1.Series["Second Harmonic"].Points.Clear();
            chart1.Series["Third Harmonic"].Points.Clear();

            double[] fundamental =Sinusoidal(numSamples, sampleRate, 60, 10, 0);
            double[] second = Generate.Sinusoidal(numSamples, sampleRate, 120, secondHarm, 0.0, secondPH);
            double[] third = Generate.Sinusoidal(numSamples, sampleRate, 180, thirdHarm, 0.0, thirdPH);

            for (int i = 0; i < numSamples; i++)
            {
                samples[i] = new Complex(fundamental[i] + second[i] + third[i], 0);
            }

            for (int i = 0; i < samples.Length ; i++)
            {
                double time =  i / sampleRate;
                
                chart1.Series["Waveform"].ChartType = SeriesChartType.Line;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Seconds";

                chart1.Series["Waveform"].Points.AddXY(time, samples[i].Real);

                if (checkBox1.Checked)
                {
                    chart1.Series["Second Harmonic"].Points.AddXY(time, second[i]);
                }
                if (checkBox2.Checked)
                {
                    chart1.Series["Third Harmonic"].Points.AddXY(time, third[i]);
                }

                
            }
        }

        private double[] Sinusoidal(int numSamples, double sampleRate, int freq, int amplitude, int phase)
        {
            double[] result = new double[numSamples];
            
            int samplePerCycle = (int)sampleRate / freq;
            int freqNum = numSamples / samplePerCycle;
            int count = 0;

            for (int i = 0; i < freqNum; i++)
            {
                //generate one cycle of sinwave
                for(int j=0; j<samplePerCycle;j++)
                {
                    double degree = 2 * Math.PI * j / samplePerCycle +phase;
                    result[count++] = amplitude * Math.Sin(degree);
                }
            }
            return result;
        }

        private void btnFFT_Click(object sender, EventArgs e)
        {
            PlotFFT();
        }

        private void PlotFFT()
        {
            chart2.Series["Frequency"].Points.Clear();
            Fourier.Forward(samples,FourierOptions.NoScaling);

            for(int i=0;i<samples.Length/10;i++)
            {
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
                chart2.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = true;

                //get the magnitude of each FFT sample:
                // = abs[Sqrt(r^2 + i2)];
                double mag = (2.0 / numSamples) * Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) +
                    Math.Pow(samples[i].Imaginary, 2)));

                double hzPerSample = sampleRate / numSamples;

                chart2.Series["Frequency"].Points.AddXY(hzPerSample*i,mag);

            }
        }

    }
}
