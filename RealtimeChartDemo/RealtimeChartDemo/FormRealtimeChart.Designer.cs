namespace RealtimeChartDemo
{
    partial class FormRealtimeChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartWaveform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBarFreq1 = new System.Windows.Forms.TrackBar();
            this.trackBarAmp1 = new System.Windows.Forms.TrackBar();
            this.chartFFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBarPha1 = new System.Windows.Forms.TrackBar();
            this.trackBarFreq2 = new System.Windows.Forms.TrackBar();
            this.trackBarAmp2 = new System.Windows.Forms.TrackBar();
            this.trackBarPha2 = new System.Windows.Forms.TrackBar();
            this.trackBarFreq3 = new System.Windows.Forms.TrackBar();
            this.trackBarAmp3 = new System.Windows.Forms.TrackBar();
            this.trackBarPha3 = new System.Windows.Forms.TrackBar();
            this.trackBarRefresh = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFreq1 = new System.Windows.Forms.Label();
            this.labelAmp1 = new System.Windows.Forms.Label();
            this.labelPha1 = new System.Windows.Forms.Label();
            this.labelFreq2 = new System.Windows.Forms.Label();
            this.labelAmp2 = new System.Windows.Forms.Label();
            this.labelPha2 = new System.Windows.Forms.Label();
            this.labelFreq3 = new System.Windows.Forms.Label();
            this.labelAmp3 = new System.Windows.Forms.Label();
            this.labelPha3 = new System.Windows.Forms.Label();
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // chartWaveform
            // 
            chartArea1.CursorX.Interval = 0.01D;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chartWaveform.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartWaveform.Legends.Add(legend1);
            this.chartWaveform.Location = new System.Drawing.Point(202, 23);
            this.chartWaveform.Name = "chartWaveform";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Waveform";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Series3";
            this.chartWaveform.Series.Add(series1);
            this.chartWaveform.Series.Add(series2);
            this.chartWaveform.Series.Add(series3);
            this.chartWaveform.Series.Add(series4);
            this.chartWaveform.Size = new System.Drawing.Size(827, 167);
            this.chartWaveform.TabIndex = 0;
            this.chartWaveform.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarFreq1
            // 
            this.trackBarFreq1.Location = new System.Drawing.Point(23, 111);
            this.trackBarFreq1.Maximum = 200;
            this.trackBarFreq1.Name = "trackBarFreq1";
            this.trackBarFreq1.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq1.TabIndex = 2;
            this.trackBarFreq1.Value = 60;
            this.trackBarFreq1.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarAmp1
            // 
            this.trackBarAmp1.Location = new System.Drawing.Point(23, 143);
            this.trackBarAmp1.Maximum = 100;
            this.trackBarAmp1.Name = "trackBarAmp1";
            this.trackBarAmp1.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmp1.TabIndex = 2;
            this.trackBarAmp1.Value = 50;
            this.trackBarAmp1.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // chartFFT
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFFT.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFFT.Legends.Add(legend2);
            this.chartFFT.Location = new System.Drawing.Point(202, 232);
            this.chartFFT.Name = "chartFFT";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "FFT";
            this.chartFFT.Series.Add(series5);
            this.chartFFT.Size = new System.Drawing.Size(827, 167);
            this.chartFFT.TabIndex = 0;
            this.chartFFT.Text = "chart1";
            // 
            // trackBarPha1
            // 
            this.trackBarPha1.Location = new System.Drawing.Point(23, 178);
            this.trackBarPha1.Minimum = 7;
            this.trackBarPha1.Name = "trackBarPha1";
            this.trackBarPha1.Size = new System.Drawing.Size(104, 45);
            this.trackBarPha1.TabIndex = 2;
            this.trackBarPha1.Value = 7;
            this.trackBarPha1.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarFreq2
            // 
            this.trackBarFreq2.Location = new System.Drawing.Point(23, 222);
            this.trackBarFreq2.Maximum = 200;
            this.trackBarFreq2.Name = "trackBarFreq2";
            this.trackBarFreq2.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq2.TabIndex = 2;
            this.trackBarFreq2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarAmp2
            // 
            this.trackBarAmp2.Location = new System.Drawing.Point(23, 253);
            this.trackBarAmp2.Maximum = 100;
            this.trackBarAmp2.Name = "trackBarAmp2";
            this.trackBarAmp2.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmp2.TabIndex = 2;
            this.trackBarAmp2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarPha2
            // 
            this.trackBarPha2.Location = new System.Drawing.Point(23, 289);
            this.trackBarPha2.Minimum = 7;
            this.trackBarPha2.Name = "trackBarPha2";
            this.trackBarPha2.Size = new System.Drawing.Size(104, 45);
            this.trackBarPha2.TabIndex = 2;
            this.trackBarPha2.Value = 7;
            this.trackBarPha2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarFreq3
            // 
            this.trackBarFreq3.Location = new System.Drawing.Point(23, 340);
            this.trackBarFreq3.Maximum = 200;
            this.trackBarFreq3.Name = "trackBarFreq3";
            this.trackBarFreq3.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq3.TabIndex = 2;
            this.trackBarFreq3.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarAmp3
            // 
            this.trackBarAmp3.Location = new System.Drawing.Point(23, 371);
            this.trackBarAmp3.Maximum = 100;
            this.trackBarAmp3.Name = "trackBarAmp3";
            this.trackBarAmp3.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmp3.TabIndex = 2;
            this.trackBarAmp3.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarPha3
            // 
            this.trackBarPha3.Location = new System.Drawing.Point(23, 407);
            this.trackBarPha3.Minimum = 7;
            this.trackBarPha3.Name = "trackBarPha3";
            this.trackBarPha3.Size = new System.Drawing.Size(104, 45);
            this.trackBarPha3.TabIndex = 2;
            this.trackBarPha3.Value = 7;
            this.trackBarPha3.SizeChanged += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarRefresh
            // 
            this.trackBarRefresh.Location = new System.Drawing.Point(23, 64);
            this.trackBarRefresh.Maximum = 1000;
            this.trackBarRefresh.Name = "trackBarRefresh";
            this.trackBarRefresh.Size = new System.Drawing.Size(104, 45);
            this.trackBarRefresh.TabIndex = 3;
            this.trackBarRefresh.Value = 500;
            this.trackBarRefresh.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // labelFreq1
            // 
            this.labelFreq1.AutoSize = true;
            this.labelFreq1.Location = new System.Drawing.Point(144, 111);
            this.labelFreq1.Name = "labelFreq1";
            this.labelFreq1.Size = new System.Drawing.Size(35, 13);
            this.labelFreq1.TabIndex = 4;
            this.labelFreq1.Text = "label1";
            // 
            // labelAmp1
            // 
            this.labelAmp1.AutoSize = true;
            this.labelAmp1.Location = new System.Drawing.Point(144, 143);
            this.labelAmp1.Name = "labelAmp1";
            this.labelAmp1.Size = new System.Drawing.Size(35, 13);
            this.labelAmp1.TabIndex = 4;
            this.labelAmp1.Text = "label1";
            // 
            // labelPha1
            // 
            this.labelPha1.AutoSize = true;
            this.labelPha1.Location = new System.Drawing.Point(144, 178);
            this.labelPha1.Name = "labelPha1";
            this.labelPha1.Size = new System.Drawing.Size(35, 13);
            this.labelPha1.TabIndex = 4;
            this.labelPha1.Text = "label1";
            // 
            // labelFreq2
            // 
            this.labelFreq2.AutoSize = true;
            this.labelFreq2.Location = new System.Drawing.Point(144, 222);
            this.labelFreq2.Name = "labelFreq2";
            this.labelFreq2.Size = new System.Drawing.Size(35, 13);
            this.labelFreq2.TabIndex = 4;
            this.labelFreq2.Text = "label1";
            // 
            // labelAmp2
            // 
            this.labelAmp2.AutoSize = true;
            this.labelAmp2.Location = new System.Drawing.Point(144, 254);
            this.labelAmp2.Name = "labelAmp2";
            this.labelAmp2.Size = new System.Drawing.Size(35, 13);
            this.labelAmp2.TabIndex = 4;
            this.labelAmp2.Text = "label1";
            // 
            // labelPha2
            // 
            this.labelPha2.AutoSize = true;
            this.labelPha2.Location = new System.Drawing.Point(144, 289);
            this.labelPha2.Name = "labelPha2";
            this.labelPha2.Size = new System.Drawing.Size(35, 13);
            this.labelPha2.TabIndex = 4;
            this.labelPha2.Text = "label1";
            // 
            // labelFreq3
            // 
            this.labelFreq3.AutoSize = true;
            this.labelFreq3.Location = new System.Drawing.Point(144, 340);
            this.labelFreq3.Name = "labelFreq3";
            this.labelFreq3.Size = new System.Drawing.Size(35, 13);
            this.labelFreq3.TabIndex = 4;
            this.labelFreq3.Text = "label1";
            // 
            // labelAmp3
            // 
            this.labelAmp3.AutoSize = true;
            this.labelAmp3.Location = new System.Drawing.Point(144, 372);
            this.labelAmp3.Name = "labelAmp3";
            this.labelAmp3.Size = new System.Drawing.Size(35, 13);
            this.labelAmp3.TabIndex = 4;
            this.labelAmp3.Text = "label1";
            // 
            // labelPha3
            // 
            this.labelPha3.AutoSize = true;
            this.labelPha3.Location = new System.Drawing.Point(144, 407);
            this.labelPha3.Name = "labelPha3";
            this.labelPha3.Size = new System.Drawing.Size(35, 13);
            this.labelPha3.TabIndex = 4;
            this.labelPha3.Text = "label1";
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // FormRealtimeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 444);
            this.Controls.Add(this.labelPha3);
            this.Controls.Add(this.labelAmp3);
            this.Controls.Add(this.labelPha2);
            this.Controls.Add(this.labelAmp2);
            this.Controls.Add(this.labelFreq3);
            this.Controls.Add(this.labelPha1);
            this.Controls.Add(this.labelFreq2);
            this.Controls.Add(this.labelAmp1);
            this.Controls.Add(this.labelFreq1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarRefresh);
            this.Controls.Add(this.trackBarPha3);
            this.Controls.Add(this.trackBarAmp3);
            this.Controls.Add(this.trackBarPha2);
            this.Controls.Add(this.trackBarAmp2);
            this.Controls.Add(this.trackBarFreq3);
            this.Controls.Add(this.trackBarPha1);
            this.Controls.Add(this.trackBarFreq2);
            this.Controls.Add(this.trackBarAmp1);
            this.Controls.Add(this.trackBarFreq1);
            this.Controls.Add(this.chartFFT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartWaveform);
            this.Name = "FormRealtimeChart";
            this.Text = "Realtime Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaveform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBarFreq1;
        private System.Windows.Forms.TrackBar trackBarAmp1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFFT;
        private System.Windows.Forms.TrackBar trackBarPha1;
        private System.Windows.Forms.TrackBar trackBarFreq2;
        private System.Windows.Forms.TrackBar trackBarAmp2;
        private System.Windows.Forms.TrackBar trackBarPha2;
        private System.Windows.Forms.TrackBar trackBarFreq3;
        private System.Windows.Forms.TrackBar trackBarAmp3;
        private System.Windows.Forms.TrackBar trackBarPha3;
        private System.Windows.Forms.TrackBar trackBarRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFreq1;
        private System.Windows.Forms.Label labelAmp1;
        private System.Windows.Forms.Label labelPha1;
        private System.Windows.Forms.Label labelFreq2;
        private System.Windows.Forms.Label labelAmp2;
        private System.Windows.Forms.Label labelPha2;
        private System.Windows.Forms.Label labelFreq3;
        private System.Windows.Forms.Label labelAmp3;
        private System.Windows.Forms.Label labelPha3;
        private System.Windows.Forms.Timer chartUpdateTimer;
    }
}

