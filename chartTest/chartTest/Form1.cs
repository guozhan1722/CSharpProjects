using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace chartTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chart chart1 = new Chart();

            ChartArea ca1 = new ChartArea();
            chart1.ChartAreas.Add(ca1);
            ((System.ComponentModel.ISupportInitialize)(chart1)).BeginInit();

            chart1.Show();
        }
    }
}
