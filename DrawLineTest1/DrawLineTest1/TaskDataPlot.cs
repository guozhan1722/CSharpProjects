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
        private bool flipPanel;
        private int TotalPanelWidth;
        

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
            TotalPanelWidth = plotArea.panel.Width ;
            plotArea.firstPanel.Width = 0;

            plotArea.firstPanel.Height = plotArea.panel.Height;

            plotArea.firstPanel.Location = new Point(plotArea.panel.Location.X + TotalPanelWidth, plotArea.panel.Location.Y+200);

            
        }

        private void InitSeries()
        {

            totalPoints = GlobalVar.Zoom * GlobalVar.SampleRate;
            linePen = new Pen(Color.Green, 2);
            AxStep = (float)TotalPanelWidth / (float)totalPoints;
            BaseY = plotArea.panel.Height / 2;

            List<PointF> initPoint = new List<PointF>();
            float xStep = 0;
            for (int i = 0; i < totalPoints; i++)
            {
                initPoint.Add(new PointF(xStep, BaseY));
                xStep += AxStep;
            }
            plotArea.serieGraphic.DrawLines(linePen, initPoint.ToArray<PointF>());
            flipPanel = true;
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

            float nAxStep = (float)TotalPanelWidth / (float)(GlobalVar.Zoom * GlobalVar.SampleRate);
            foreach (var rx in rxDataBackup)
	        {
                movePanels(flipPanel);
                for (int i = 0; i < rx.value1.Length; i++)
                {
                    float Yval = (float)(BaseY + rx.value1[i] * (BaseY / 3));
                    PointF p = new PointF(lastPointX, Yval);
                    lastPointX += nAxStep;
                    newline.Add(p);
                }

                DrawLineFromPoints(newline);
            }
        }

        private void movePanels(bool flipP)
        {
            PictureBox pBox;
            if(flipP)
            {
                pBox = plotArea.firstPanel;
            }
            else{
                pBox = plotArea.panel;
            }

            int movePanelStep = TotalPanelWidth / GlobalVar.Zoom;
            var curLocation = pBox.Location;

            curLocation.X -= movePanelStep;
            if(curLocation.X < 0)
            {
                if(pBox.Name == "panelFirst")
                {
                    pBox = plotArea.panel;
                }
                else
                {
                    pBox = plotArea.firstPanel;
                }
                
                flipPanel = !flipPanel;

                curLocation.X = TotalPanelWidth - movePanelStep;
                lastPointX = 0;
                pBox.Refresh();
            }
            //pBox.Width = pBox.Location.X - curLocation.X;
            pBox.Width = TotalPanelWidth;
            pBox.Location = curLocation;
        }

        private void DrawLineFromPoints(List<PointF> points)
        {

            
            plotArea.panel.SuspendLayout();
            plotArea.firstPanel.SuspendLayout();
            //if (flipPanel)
            {
               plotArea.firstGraphic.DrawLines(linePen, points.ToArray<PointF>());
            }
            //else
            {
                //plotArea.serieGraphic.DrawLines(linePen, points.ToArray<PointF>());
            }
            //plotArea.serieGraphic.DrawLines(linePen, backpoints.ToArray<PointF>());
            plotArea.panel.ResumeLayout();
            plotArea.firstPanel.ResumeLayout();
            Debug.WriteLine("isp1:{0} p1-->{1}:{2}, p2-->{3}:{4} line-->{5}:{7}:{6} zoom-->{8}"
                , flipPanel,
                plotArea.firstPanel.Location.X, plotArea.firstPanel.Width,
                plotArea.panel.Location.X, plotArea.panel.Width,
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
