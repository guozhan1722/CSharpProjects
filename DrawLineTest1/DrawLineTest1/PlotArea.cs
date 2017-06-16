using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DrawLineTest1
{
    class PlotArea
    {
        public System.Windows.Forms.Panel panel;
        public System.Drawing.Graphics serieGraphic;


        public PlotArea(System.Windows.Forms.Panel panel, System.Drawing.Graphics serieGraphic)
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

    }
}
