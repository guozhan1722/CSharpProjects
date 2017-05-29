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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFFT = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.trkSecond = new System.Windows.Forms.TrackBar();
            this.trkThird = new System.Windows.Forms.TrackBar();
            this.trkPHSecond = new System.Windows.Forms.TrackBar();
            this.trkPHThird = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHThird)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(32, 26);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Waveform";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Second Harmonic";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Third Harmonic";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(780, 161);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(32, 230);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Frequency";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(780, 161);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            // 
            // btnFFT
            // 
            this.btnFFT.Location = new System.Drawing.Point(231, 404);
            this.btnFFT.Name = "btnFFT";
            this.btnFFT.Size = new System.Drawing.Size(75, 28);
            this.btnFFT.TabIndex = 1;
            this.btnFFT.Text = "FFT";
            this.btnFFT.UseVisualStyleBackColor = true;
            this.btnFFT.Click += new System.EventHandler(this.btnFFT_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(886, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 28);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(877, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(943, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // trkSecond
            // 
            this.trkSecond.Location = new System.Drawing.Point(877, 130);
            this.trkSecond.Name = "trkSecond";
            this.trkSecond.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkSecond.Size = new System.Drawing.Size(56, 104);
            this.trkSecond.TabIndex = 3;
            // 
            // trkThird
            // 
            this.trkThird.Location = new System.Drawing.Point(943, 130);
            this.trkThird.Name = "trkThird";
            this.trkThird.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThird.Size = new System.Drawing.Size(56, 104);
            this.trkThird.TabIndex = 3;
            // 
            // trkPHSecond
            // 
            this.trkPHSecond.Location = new System.Drawing.Point(877, 287);
            this.trkPHSecond.Name = "trkPHSecond";
            this.trkPHSecond.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPHSecond.Size = new System.Drawing.Size(56, 104);
            this.trkPHSecond.TabIndex = 3;
            // 
            // trkPHThird
            // 
            this.trkPHThird.Location = new System.Drawing.Point(939, 287);
            this.trkPHThird.Name = "trkPHThird";
            this.trkPHThird.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPHThird.Size = new System.Drawing.Size(56, 104);
            this.trkPHThird.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 444);
            this.Controls.Add(this.trkPHThird);
            this.Controls.Add(this.trkThird);
            this.Controls.Add(this.trkPHSecond);
            this.Controls.Add(this.trkSecond);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnFFT);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHThird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnFFT;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TrackBar trkSecond;
        private System.Windows.Forms.TrackBar trkThird;
        private System.Windows.Forms.TrackBar trkPHSecond;
        private System.Windows.Forms.TrackBar trkPHThird;
    }
}

