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
        private Pen linePen;
        private PointF lastPf;
        private int oriPanelWidth;
        

        public TaskDataPlot(List<RxDataContainer> rxData, PlotArea plotArea)
        {
            // TODO: Complete member initialization
            this.rxData = rxData;
            this.plotArea = plotArea;
            rxDataBackup = new List<RxDataContainer>();
            oriPanelWidth = plotArea.panel.Width;
            points = new List<PointF>();
            newline = new List<PointF>();
            InitSeries();
        }

        private void InitSeries()
        {
            int totalPoints = GlobalVar.Zoom * GlobalVar.SampleRate;
            linePen = new Pen(Color.Green, 1);

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
            
            //PointF startp = points[0];
            plotArea.panel.SuspendLayout();

            //plotArea.panel.Refresh();
            //for (int i = 1; i < points.Count; i++)
            {
                //plotArea.serieGraphic.DrawLine(new Pen(Color.Green,1),startp,points[i]);
                //startp = points[i];
            }

            plotArea.serieGraphic.DrawLines(linePen, points.ToArray<PointF>());
            plotArea.panel.ResumeLayout();
            lastPf = points[points.Count - 1];
            //var oldl = plotArea.panel.Location;
            //plotArea.panel.Location = new Point(oldl.X -100, oldl.Y);
        }

        public async void StartPlotAsyn()
        {
            while (true)
            {
                await GetRxData();
                DrawDotsOnUI();
                MovePanel();
                Debug.WriteLine("Task Plot: " + CCC++);
            }
        }

        private void MovePanel()
        {
            var movedWidth = oriPanelWidth / GlobalVar.Zoom;
            var curLocation = plotArea.panel.Location;
            var newLocation = new Point(curLocation.X - movedWidth, curLocation.Y);
            plotArea.panel.Location = newLocation;
            //plotArea.panel.Width += movedWidth;
            
        }

        private void DrawDotsOnUI()
        {

            foreach (var rx in rxDataBackup)
	        {
                for (int i = 0; i < rx.value1.Length; i++)
                {
                    float Yval = (float)(BaseY + rx.value1[i] * (BaseY / 3));
                    PointF p = new PointF(lastPf.X+i*AxStep, Yval);
                    newline.Add(p);
                }
	        }

            DrawLineFromPoints(newline);
            newline.Clear();
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
