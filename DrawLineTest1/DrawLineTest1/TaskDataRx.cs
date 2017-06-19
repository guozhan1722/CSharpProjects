using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DrawLineTest1
{
    class TaskDataRx
    {
        private List<RxDataContainer> rxData;
        private int sampleRate;
        private int count;

        public TaskDataRx(List<RxDataContainer> rxData, int sampleRate)
        {
            // TODO: Complete member initialization
            this.rxData = rxData;
            this.sampleRate = sampleRate;
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
                    Thread.Sleep(1000);
                    double[] ser1Part = DataGenerator.Sinusoidal(sampleRate, (double)sampleRate, GlobalVar.Freq,GlobalVar.Gain,0);
                    double[] ser2Part = new double[sampleRate];
                    rxData.Add(new RxDataContainer(ser1Part, ser2Part));
                    Debug.WriteLine("TaskRx: " + count++ + "SampleRate = " + sampleRate);
                }
            });
        }




    }
}
