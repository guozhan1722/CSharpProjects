using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace RealtimeChartDemo
{
    class TaskDataRx
    {
        private List<RxDataContainer> rxData;
        private int SampleRate;
        private int count;

        public TaskDataRx(List<RxDataContainer> rxData)
        {
            // TODO: Complete member initialization
            this.rxData = rxData;
            SampleRate = WaveformReq.SampleRate;
        }

        public void StartRx()
        {
            GenerateData();
            
        }

        private async void GenerateData()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    if(WaveformReq.StopGenerate)
                    {
                        break;
                    }
                    Thread.Sleep(1000);
                    double[] ser1Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel1, WaveformReq.AmpSeriel1, WaveformReq.PhaSeriel1);
                    double[] ser2Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel2, WaveformReq.AmpSeriel2, WaveformReq.PhaSeriel2);
                    double[] ser3Part = WaveformGenerator.Sinusoidal(SampleRate, (double)SampleRate, WaveformReq.FreqSeriel3, WaveformReq.AmpSeriel3, WaveformReq.PhaSeriel3);

                    rxData.Add(new RxDataContainer(ser1Part, ser2Part, ser3Part));
                    Debug.WriteLine("TaskRx: " + count++ + "SampleRate = "+ SampleRate);
                }
             });
        }
    }
}
