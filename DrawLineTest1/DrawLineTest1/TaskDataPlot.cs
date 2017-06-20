using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLineTest1
{
    class TaskDataPlot
    {
        private List<RxDataContainer> rxData;
        private List<RxDataContainer> rxDataBackup;
        private PlotArea plotArea;
        private int CCC;
        private float AxStep;
        private float BaseY;
        
        private Pen linePen;
        private float lastPointX;
        
        private bool DrawSection1;
        private int totalPoints;
        

        public TaskDataPlot(List<RxDataContainer> rxData, PlotArea plotArea)
        {
            this.rxData = rxData;
            this.plotArea = plotArea;
            rxDataBackup = new List<RxDataContainer>();
            InitPlotArea();
            InitSeries();
        }

        private void InitPlotArea()
        {
            plotArea.firstPanel.Width = plotArea.panel.Width;
            plotArea.secondPanel.Width = plotArea.panel.Width;

            plotArea.firstPanel.Height = plotArea.panel.Height;
            plotArea.secondPanel.Height = plotArea.panel.Height;

            plotArea.firstPanel.Location = new Point(0, 0);
            plotArea.secondPanel.Location = new Point(plotArea.panel.Width, 0);

            
        }

        private void InitSeries()
        {

            totalPoints = GlobalVar.Zoom * GlobalVar.SampleRate;
            linePen = new Pen(Color.Green, 2);
            AxStep = (float)plotArea.panel.Width / (float)totalPoints;
            BaseY = plotArea.panel.Height / 2;
            DrawSection1 = false;

            List<PointF> initPoint = new List<PointF>();
            float xStep = 0;
            for (int i = 0; i < totalPoints; i++)
            {
                initPoint.Add(new PointF(xStep, BaseY));
                xStep += AxStep;
            }
            plotArea.firstGraphic.DrawLines(linePen, initPoint.ToArray<PointF>());

        }

        public async void StartPlotAsyn()
        {
            while (true)
            {
                await GetRxData();
                DrawDotsOnUI();
                
            }
        }

        private void DrawDotsOnUI()
        {
            List<PointF> newline = new List<PointF>();
            float nAxStep = (float)plotArea.panel.Width / (float)(GlobalVar.Zoom * GlobalVar.SampleRate);

            plotArea.firstPanel.SuspendLayout();
            plotArea.secondPanel.SuspendLayout();
       
            foreach (var rx in rxDataBackup)
	        {
                movePanels(plotArea.firstPanel);
                movePanels(plotArea.secondPanel);
                for (int i = 0; i < rx.value1.Length; i++)
                {
                    float Yval = (float)(BaseY + rx.value1[i] * (BaseY / 3));
                    PointF p = new PointF(lastPointX, Yval);
                    lastPointX += nAxStep;
                    newline.Add(p);
                }

                DrawLineFromPoints(newline, DrawSection1);
            }
        }

        private void movePanels(Panel panel)
        {
            int movePanelStep = plotArea.panel.Width / GlobalVar.Zoom;
            var curLocation = panel.Location;

            curLocation.X -= movePanelStep;
            if((curLocation.X * -1) > plotArea.panel.Width)
            {
                curLocation.X = plotArea.panel.Width - movePanelStep;
                lastPointX = 0;
                panel.Refresh();
                if (panel.Name == "panelFirst")
                {
                    DrawSection1 = true;
                }
                else
                {
                    DrawSection1 = false;
                }

            }
            
            panel.Location = curLocation;

        }

        private void DrawLineFromPoints(List<PointF> points, bool DrawSection1)
        {
            Graphics ser;
            
            
            if (DrawSection1)
            {
                ser = plotArea.firstGraphic;
            }
            else
            {
                ser = plotArea.secondGraphic;
               
            }
            
            ser.DrawLines(linePen, points.ToArray<PointF>());
            
            plotArea.firstPanel.ResumeLayout();
            plotArea.secondPanel.ResumeLayout();
            Debug.WriteLine("isp1:{0} p1-->{1}:{2}, p2-->{3}:{4} line-->{5}:{7}:{6} zoom-->{8}"
                , DrawSection1,
                plotArea.firstPanel.Location.X, plotArea.firstPanel.Width,
                plotArea.secondPanel.Location.X,  plotArea.secondPanel.Width,
                points[0].X, points.Count, lastPointX,GlobalVar.Zoom);
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
