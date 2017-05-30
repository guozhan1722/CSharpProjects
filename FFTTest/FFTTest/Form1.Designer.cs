namespace FFTTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trkFreq1 = new System.Windows.Forms.TrackBar();
            this.trkAmp1 = new System.Windows.Forms.TrackBar();
            this.trkPha1 = new System.Windows.Forms.TrackBar();
            this.labelFreq1 = new System.Windows.Forms.Label();
            this.labelAmp1 = new System.Windows.Forms.Label();
            this.labelPha1 = new System.Windows.Forms.Label();
            this.labelPha2 = new System.Windows.Forms.Label();
            this.labelAmp2 = new System.Windows.Forms.Label();
            this.labelFreq2 = new System.Windows.Forms.Label();
            this.trkPha2 = new System.Windows.Forms.TrackBar();
            this.trkAmp2 = new System.Windows.Forms.TrackBar();
            this.trkFreq2 = new System.Windows.Forms.TrackBar();
            this.checkBoxShowFreq2 = new System.Windows.Forms.CheckBox();
            this.checkBoxShowFreq1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAmp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFFT
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFFT.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFFT.Legends.Add(legend1);
            this.chartFFT.Location = new System.Drawing.Point(25, 331);
            this.chartFFT.Margin = new System.Windows.Forms.Padding(2);
            this.chartFFT.Name = "chartFFT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frequency";
            this.chartFFT.Series.Add(series1);
            this.chartFFT.Size = new System.Drawing.Size(1029, 148);
            this.chartFFT.TabIndex = 0;
            this.chartFFT.Text = "chart1";
            // 
            // chart1
            // 
            chartArea2.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea2.CursorX.AutoScroll = false;
            chartArea2.CursorX.Interval = 0.001D;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(11, 24);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Waveform";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Second";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Fundamental";
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1208, 148);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // trkFreq1
            // 
            this.trkFreq1.Location = new System.Drawing.Point(139, 206);
            this.trkFreq1.Margin = new System.Windows.Forms.Padding(2);
            this.trkFreq1.Maximum = 1000;
            this.trkFreq1.Name = "trkFreq1";
            this.trkFreq1.Size = new System.Drawing.Size(392, 45);
            this.trkFreq1.TabIndex = 3;
            this.trkFreq1.Value = 600;
            this.trkFreq1.Scroll += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // trkAmp1
            // 
            this.trkAmp1.Location = new System.Drawing.Point(570, 206);
            this.trkAmp1.Margin = new System.Windows.Forms.Padding(2);
            this.trkAmp1.Maximum = 100;
            this.trkAmp1.Name = "trkAmp1";
            this.trkAmp1.Size = new System.Drawing.Size(179, 45);
            this.trkAmp1.TabIndex = 3;
            this.trkAmp1.Value = 50;
            this.trkAmp1.Scroll += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // trkPha1
            // 
            this.trkPha1.Location = new System.Drawing.Point(811, 207);
            this.trkPha1.Maximum = 7;
            this.trkPha1.Name = "trkPha1";
            this.trkPha1.Size = new System.Drawing.Size(127, 45);
            this.trkPha1.TabIndex = 4;
            this.trkPha1.Scroll += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // labelFreq1
            // 
            this.labelFreq1.AutoSize = true;
            this.labelFreq1.Location = new System.Drawing.Point(284, 191);
            this.labelFreq1.Name = "labelFreq1";
            this.labelFreq1.Size = new System.Drawing.Size(35, 13);
            this.labelFreq1.TabIndex = 5;
            this.labelFreq1.Text = "label1";
            // 
            // labelAmp1
            // 
            this.labelAmp1.AutoSize = true;
            this.labelAmp1.Location = new System.Drawing.Point(639, 191);
            this.labelAmp1.Name = "labelAmp1";
            this.labelAmp1.Size = new System.Drawing.Size(35, 13);
            this.labelAmp1.TabIndex = 6;
            this.labelAmp1.Text = "label2";
            // 
            // labelPha1
            // 
            this.labelPha1.AutoSize = true;
            this.labelPha1.Location = new System.Drawing.Point(835, 191);
            this.labelPha1.Name = "labelPha1";
            this.labelPha1.Size = new System.Drawing.Size(35, 13);
            this.labelPha1.TabIndex = 7;
            this.labelPha1.Text = "label3";
            // 
            // labelPha2
            // 
            this.labelPha2.AutoSize = true;
            this.labelPha2.Location = new System.Drawing.Point(835, 253);
            this.labelPha2.Name = "labelPha2";
            this.labelPha2.Size = new System.Drawing.Size(35, 13);
            this.labelPha2.TabIndex = 14;
            this.labelPha2.Text = "label3";
            // 
            // labelAmp2
            // 
            this.labelAmp2.AutoSize = true;
            this.labelAmp2.Location = new System.Drawing.Point(639, 253);
            this.labelAmp2.Name = "labelAmp2";
            this.labelAmp2.Size = new System.Drawing.Size(35, 13);
            this.labelAmp2.TabIndex = 13;
            this.labelAmp2.Text = "label2";
            // 
            // labelFreq2
            // 
            this.labelFreq2.AutoSize = true;
            this.labelFreq2.Location = new System.Drawing.Point(284, 253);
            this.labelFreq2.Name = "labelFreq2";
            this.labelFreq2.Size = new System.Drawing.Size(35, 13);
            this.labelFreq2.TabIndex = 12;
            this.labelFreq2.Text = "label1";
            // 
            // trkPha2
            // 
            this.trkPha2.Location = new System.Drawing.Point(811, 269);
            this.trkPha2.Maximum = 7;
            this.trkPha2.Name = "trkPha2";
            this.trkPha2.Size = new System.Drawing.Size(127, 45);
            this.trkPha2.TabIndex = 11;
            this.trkPha2.Scroll += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // trkAmp2
            // 
            this.trkAmp2.Location = new System.Drawing.Point(570, 269);
            this.trkAmp2.Margin = new System.Windows.Forms.Padding(2);
            this.trkAmp2.Maximum = 100;
            this.trkAmp2.Name = "trkAmp2";
            this.trkAmp2.Size = new System.Drawing.Size(179, 45);
            this.trkAmp2.TabIndex = 9;
            this.trkAmp2.Scroll += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // trkFreq2
            // 
            this.trkFreq2.Location = new System.Drawing.Point(139, 269);
            this.trkFreq2.Margin = new System.Windows.Forms.Padding(2);
            this.trkFreq2.Maximum = 1000;
            this.trkFreq2.Name = "trkFreq2";
            this.trkFreq2.Size = new System.Drawing.Size(392, 45);
            this.trkFreq2.TabIndex = 10;
            this.trkFreq2.Scroll += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // checkBoxShowFreq2
            // 
            this.checkBoxShowFreq2.AutoSize = true;
            this.checkBoxShowFreq2.Location = new System.Drawing.Point(45, 269);
            this.checkBoxShowFreq2.Name = "checkBoxShowFreq2";
            this.checkBoxShowFreq2.Size = new System.Drawing.Size(80, 17);
            this.checkBoxShowFreq2.TabIndex = 15;
            this.checkBoxShowFreq2.Text = "ShowFreq2";
            this.checkBoxShowFreq2.UseVisualStyleBackColor = true;
            this.checkBoxShowFreq2.CheckedChanged += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // checkBoxShowFreq1
            // 
            this.checkBoxShowFreq1.AutoSize = true;
            this.checkBoxShowFreq1.Location = new System.Drawing.Point(45, 216);
            this.checkBoxShowFreq1.Name = "checkBoxShowFreq1";
            this.checkBoxShowFreq1.Size = new System.Drawing.Size(83, 17);
            this.checkBoxShowFreq1.TabIndex = 16;
            this.checkBoxShowFreq1.Text = "Show Freq1";
            this.checkBoxShowFreq1.UseVisualStyleBackColor = true;
            this.checkBoxShowFreq1.CheckedChanged += new System.EventHandler(this.trkFreq_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 547);
            this.Controls.Add(this.checkBoxShowFreq1);
            this.Controls.Add(this.checkBoxShowFreq2);
            this.Controls.Add(this.labelPha2);
            this.Controls.Add(this.labelAmp2);
            this.Controls.Add(this.labelFreq2);
            this.Controls.Add(this.trkPha2);
            this.Controls.Add(this.trkAmp2);
            this.Controls.Add(this.trkFreq2);
            this.Controls.Add(this.labelPha1);
            this.Controls.Add(this.labelAmp1);
            this.Controls.Add(this.labelFreq1);
            this.Controls.Add(this.trkPha1);
            this.Controls.Add(this.trkAmp1);
            this.Controls.Add(this.trkFreq1);
            this.Controls.Add(this.chartFFT);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartFFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAmp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPha1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAmp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFreq2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFFT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar trkFreq1;
        private System.Windows.Forms.TrackBar trkAmp1;
        private System.Windows.Forms.TrackBar trkPha1;
        private System.Windows.Forms.Label labelFreq1;
        private System.Windows.Forms.Label labelAmp1;
        private System.Windows.Forms.Label labelPha1;
        private System.Windows.Forms.Label labelPha2;
        private System.Windows.Forms.Label labelAmp2;
        private System.Windows.Forms.Label labelFreq2;
        private System.Windows.Forms.TrackBar trkPha2;
        private System.Windows.Forms.TrackBar trkAmp2;
        private System.Windows.Forms.TrackBar trkFreq2;
        private System.Windows.Forms.CheckBox checkBoxShowFreq2;
        private System.Windows.Forms.CheckBox checkBoxShowFreq1;
    }
}

