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
        private int CCC;
        private float AxStep;
        private float BaseY;
        private List<PointF> newline;
        private Pen linePen;
        private PointF lastPf;
        private Point panel1Location;
        private Point panel2Location;
        private int movePanelStep;
        private bool DrawSection1;
        private int sectionCount;
        private int totalPoints;
        

        public TaskDataPlot(List<RxDataContainer> rxData, PlotArea plotArea)
        {
            // TODO: Complete member initialization
            this.rxData = rxData;
            this.plotArea = plotArea;
            rxDataBackup = new List<RxDataContainer>();
            newline = new List<PointF>();
            InitPlotArea();
            InitSeries();
        }

        private void InitPlotArea()
        {
            plotArea.firstPanel.Width = plotArea.panel.Width;
            plotArea.secondPanel.Width = plotArea.panel.Width;

            plotArea.firstPanel.Height = plotArea.panel.Height;
            plotArea.secondPanel.Height = plotArea.panel.Height;

            panel1Location = new Point(0, 0);
            panel2Location = new Point(plotArea.panel.Width, 0);

            plotArea.firstPanel.Location = panel1Location;
            plotArea.secondPanel.Location = panel2Location;

            movePanelStep = plotArea.panel.Width / GlobalVar.Zoom;
        }

        private void InitSeries()
        {

            totalPoints = GlobalVar.Zoom * GlobalVar.SampleRate;
            linePen = new Pen(Color.Green, 2);
            AxStep = (float)plotArea.panel.Width / (float)totalPoints;
            BaseY = plotArea.panel.Height / 2;
            sectionCount = 0;
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
            foreach (var rx in rxDataBackup)
	        {
                sectionCount += rx.value1.Length;
                
                if (sectionCount > totalPoints)
                {
                    DrawSection1 = !DrawSection1;
                    sectionCount = 0;
                    lastPf = new PointF(0, BaseY);
                    if(DrawSection1)
                    {
                        plotArea.firstPanel.Refresh();
                    }
                    else
                    {
                        plotArea.secondPanel.Refresh();
                    }
                }

                for (int i = 0; i < rx.value1.Length; i++)
                {
                    float Yval = (float)(BaseY + rx.value1[i] * (BaseY / 3));
                    PointF p = new PointF(lastPf.X+i*AxStep, Yval);
                    newline.Add(p);
                }

                DrawLineFromPoints(newline, DrawSection1);
                newline.Clear();
                
            }

            
        }

        private void DrawLineFromPoints(List<PointF> newline, bool DrawSection1)
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
            
            plotArea.firstPanel.SuspendLayout();
            plotArea.secondPanel.SuspendLayout();
            movePanels();
            
            ser.DrawLines(linePen, newline.ToArray<PointF>());
            
            plotArea.firstPanel.ResumeLayout();
            plotArea.secondPanel.ResumeLayout();
            lastPf = newline[newline.Count - 1];
            //var oldl = plotArea.panel.Location;
            //plotArea.panel.Location = new Point(oldl.X -100, oldl.Y);
            Debug.WriteLine("isp1:{0} p1-->{1}:{2}, p2-->{3}:{4} line-->{5}:{6} "
                ,DrawSection1,
                plotArea.firstPanel.Location.X, plotArea.firstPanel.Width,
                plotArea.secondPanel.Location.X,  plotArea.secondPanel.Width,
                newline[0].X, newline.Count);
        }

        private void movePanels()
        {
            panel1Location.X -= movePanelStep;
            panel2Location.X -= movePanelStep;

            if ((panel1Location.X * -1) > plotArea.panel.Width)
            {
                panel1Location.X = plotArea.panel.Width - movePanelStep;
            }
            if ((panel2Location.X * -1) > plotArea.panel.Width)
            {
                panel2Location.X = plotArea.panel.Width - movePanelStep;
            }

            plotArea.firstPanel.Location = panel1Location;
            plotArea.secondPanel.Location = panel2Location;
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
