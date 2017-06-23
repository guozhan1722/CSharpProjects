using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawLineTest1
{
    class PlotArea
    {
        public PictureBox panel;
        public System.Drawing.Graphics serieGraphic;
        
        public PlotArea()
        {
        }

        public PlotArea(PictureBox panel, System.Drawing.Graphics serieGraphic)
        {
            // TODO: Complete member initialization
            this.panel = panel;
            this.serieGraphic = serieGraphic;
            serieGraphic.DrawLine(new System.Drawing.Pen(Color.Blue, 1), 0, panel.Height/2, panel.Width, panel.Height/2);
        }

        public int AxInterval { get; set; }

        public int AyInterval { get; set; }

        public int Width { get; set; }

        internal void CreatArea()
        {
            int wi = AxInterval*panel.Width/Width;
            while(panel.Width > wi)
            {
                serieGraphic.DrawLine(new System.Drawing.Pen(Color.Yellow, 1), wi, 0, wi, panel.Height);
                wi += AxInterval * panel.Width / Width;
            }
        }


        public PictureBox firstPanel { get; set; }

        public Graphics firstGraphic { get; set; }

        public Graphics secondGraphic { get; set; }

        public System.Windows.Forms.Panel secondPanel { get; set; }
    }
}
