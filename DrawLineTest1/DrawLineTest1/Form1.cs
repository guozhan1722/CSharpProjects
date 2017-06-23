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
        Graphics mainGraphic = null;
        Pen myPen = new Pen(Color.Red);
        private List<RxDataContainer> rxData;
        PlotArea plotArea;


        public Form1()
        {
            plotArea = new PlotArea();
            InitializeComponent();
            updateGlobalVar();
            GlobalVar.SampleRate = 200;
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
        
        private void panelBase_Paint(object sender, PaintEventArgs e)
        {
            var panel = sender as PictureBox;

            if(panel.Name == "panelFirst")
            {

                plotArea.firstPanel = panel;
                plotArea.firstGraphic = panel.CreateGraphics();
            }

            else if (panel.Name == "panelBase")
            {

                plotArea.panel = panel;
                plotArea.serieGraphic = panel.CreateGraphics();
                plotArea.Width = GlobalVar.Zoom;
                plotArea.AxInterval = GlobalVar.Zoom / 10;
                //plotArea.CreatArea();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelFirst.Width = panelBase.Width;
        }


    }
}
