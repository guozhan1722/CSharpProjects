using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DrawLineTest1
{
    class TaskDataPlot
    {
        private List<RxDataContainer> rxData;
        private List<RxDataContainer> rxDataBackup;
        private PlotArea plotArea;
        private List<PointF> points;
        private int CCC;
        private float AxStep;
        private float BaseY;
        private List<PointF> newline;
        

        public TaskDataPlot(List<RxDataContainer> rxData, PlotArea plotArea)
        {
            // TODO: Complete member initialization
            this.rxData = rxData;
            this.plotArea = plotArea;
            rxDataBackup = new List<RxDataContainer>();
            points = new List<PointF>();
            newline = new List<PointF>();
            InitSeries();
        }

        private void InitSeries()
        {
            int totalPoints = GlobalVar.Zoom * GlobalVar.SampleRate;

            AxStep = (float)plotArea.panel.Width / (float)totalPoints;
            BaseY = plotArea.panel.Height / 2;
            PointF startPF = new PointF(0, BaseY);
            float xStep = 0;
            
            for (int i = 0; i < totalPoints; i++)
            {
                points.Add(new PointF(startPF.X+xStep, startPF.Y));
                xStep += AxStep;
            }

            DrawLineFromPoints(points);
        }

        private void DrawLineFromPoints(List<PointF> points)
        {
            plotArea.panel.Refresh();
            plotArea.serieGraphic.DrawLines(new Pen(Color.Green,1),points.ToArray<PointF>());

        }

        public async void StartPlotAsyn()
        {
            while (true)
            {
                await GetRxData();
                DrawDotsOnUI();
                Debug.WriteLine("Task Plot: " + CCC++);
            }
        }

        private void DrawDotsOnUI()
        {
            
            
            foreach (var rx in rxDataBackup)
	        {
                int i;
                for (i = 0; i < points.Count-rx.value1.Length; i++)
                {
                    PointF p = new PointF(points[i].X, points[i + rx.value1.Length].Y);
                    newline.Add(p);
                }

                for (int j = 0; j < rx.value1.Length; j++)
                {
                    PointF p = new PointF(points[i++].X, (float)0.8*(BaseY+(float)rx.value1[j]*BaseY/(float)GlobalVar.Gain));
                    newline.Add(p);
                }
	        }
            DrawLineFromPoints(newline);
            lock(points)
            {
                points.Clear();
                points.AddRange(newline);
                newline.Clear();
            }

        }

        private async Task GetRxData()
        {
            await Task.Run(() =>
            {

                while (rxData.Count <= 0)
                {
                    Thread.Sleep(100);
                }

                lock (rxData)
                {
                    rxDataBackup.Clear();
                    rxDataBackup.AddRange(rxData);
                    rxData.Clear();
                }

            });
        }


    }
}
