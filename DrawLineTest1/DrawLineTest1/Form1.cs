using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLineTest1
{
    public partial class Form1 : Form
    {
        Graphics serieGraphic = null;
        private double[] data;
        private List<PointF> points;
        Graphics mainGraphic = null;
        Pen myPen = new Pen(Color.Red);
        private List<RxDataContainer> rxData;
        

        public Form1()
        {
            InitializeComponent();
            updateGlobalVar();
            GlobalVar.SampleRate = 60;
            rxData = new List<RxDataContainer>();            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TaskDataRx taskRx = new TaskDataRx(rxData,GlobalVar.SampleRate);
            taskRx.StartRx();
            TaskDataPlot taskPlot = new TaskDataPlot(rxData, plotArea);
            taskPlot.StartPlotAsyn();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var form = sender as Form;
            mainGraphic = form.CreateGraphics();
        }

        void updateGlobalVar()
        {
            GlobalVar.Freq = trackBar1.Value;
            GlobalVar.Gain = trackBar2.Value;
            GlobalVar.Zoom = trackBar3.Value;
            label2.Text = trackBar1.Value.ToString();
            label3.Text = trackBar2.Value.ToString();
            label4.Text = trackBar3.Value.ToString();
        }


        private void trackBar_Scroll(object sender, EventArgs e)
        {
            updateGlobalVar();
        }
        PlotArea plotArea;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var panel = sender as Panel;
            serieGraphic = panel.CreateGraphics();

            plotArea = new PlotArea(panel, serieGraphic);
            plotArea.Width = GlobalVar.Zoom;
            plotArea.AxInterval = plotArea.Width / 5;
            plotArea.CreatArea();

        }


    }
}
