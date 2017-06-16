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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBarFreq1 = new System.Windows.Forms.TrackBar();
            this.trackBarAmp1 = new System.Windows.Forms.TrackBar();
            this.trackBarPha1 = new System.Windows.Forms.TrackBar();
            this.trackBarFreq2 = new System.Windows.Forms.TrackBar();
            this.trackBarAmp2 = new System.Windows.Forms.TrackBar();
            this.trackBarPha2 = new System.Windows.Forms.TrackBar();
            this.labelFreq1 = new System.Windows.Forms.Label();
            this.labelAmp1 = new System.Windows.Forms.Label();
            this.labelPha1 = new System.Windows.Forms.Label();
            this.labelFreq2 = new System.Windows.Forms.Label();
            this.labelAmp2 = new System.Windows.Forms.Label();
            this.labelPha2 = new System.Windows.Forms.Label();
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonWaveform = new System.Windows.Forms.RadioButton();
            this.radioButtonFreq1 = new System.Windows.Forms.RadioButton();
            this.radioButtonFreq2 = new System.Windows.Forms.RadioButton();
            this.chartWaveform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarFreq1
            // 
            this.trackBarFreq1.Location = new System.Drawing.Point(138, 77);
            this.trackBarFreq1.Maximum = 700;
            this.trackBarFreq1.Minimum = 10;
            this.trackBarFreq1.Name = "trackBarFreq1";
            this.trackBarFreq1.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq1.TabIndex = 2;
            this.trackBarFreq1.Value = 100;
            this.trackBarFreq1.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarAmp1
            // 
            this.trackBarAmp1.Location = new System.Drawing.Point(138, 109);
            this.trackBarAmp1.Maximum = 100;
            this.trackBarAmp1.Name = "trackBarAmp1";
            this.trackBarAmp1.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmp1.TabIndex = 2;
            this.trackBarAmp1.Value = 50;
            this.trackBarAmp1.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarPha1
            // 
            this.trackBarPha1.Location = new System.Drawing.Point(138, 144);
            this.trackBarPha1.Minimum = 7;
            this.trackBarPha1.Name = "trackBarPha1";
            this.trackBarPha1.Size = new System.Drawing.Size(104, 45);
            this.trackBarPha1.TabIndex = 2;
            this.trackBarPha1.Value = 7;
            this.trackBarPha1.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarFreq2
            // 
            this.trackBarFreq2.Location = new System.Drawing.Point(138, 188);
            this.trackBarFreq2.Maximum = 200;
            this.trackBarFreq2.Name = "trackBarFreq2";
            this.trackBarFreq2.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq2.TabIndex = 2;
            this.trackBarFreq2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarAmp2
            // 
            this.trackBarAmp2.Location = new System.Drawing.Point(138, 219);
            this.trackBarAmp2.Maximum = 100;
            this.trackBarAmp2.Name = "trackBarAmp2";
            this.trackBarAmp2.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmp2.TabIndex = 2;
            this.trackBarAmp2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarPha2
            // 
            this.trackBarPha2.Location = new System.Drawing.Point(138, 255);
            this.trackBarPha2.Minimum = 7;
            this.trackBarPha2.Name = "trackBarPha2";
            this.trackBarPha2.Size = new System.Drawing.Size(104, 45);
            this.trackBarPha2.TabIndex = 2;
            this.trackBarPha2.Value = 7;
            this.trackBarPha2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // labelFreq1
            // 
            this.labelFreq1.AutoSize = true;
            this.labelFreq1.Location = new System.Drawing.Point(259, 77);
            this.labelFreq1.Name = "labelFreq1";
            this.labelFreq1.Size = new System.Drawing.Size(35, 13);
            this.labelFreq1.TabIndex = 4;
            this.labelFreq1.Text = "label1";
            // 
            // labelAmp1
            // 
            this.labelAmp1.AutoSize = true;
            this.labelAmp1.Location = new System.Drawing.Point(259, 109);
            this.labelAmp1.Name = "labelAmp1";
            this.labelAmp1.Size = new System.Drawing.Size(35, 13);
            this.labelAmp1.TabIndex = 4;
            this.labelAmp1.Text = "label1";
            // 
            // labelPha1
            // 
            this.labelPha1.AutoSize = true;
            this.labelPha1.Location = new System.Drawing.Point(259, 144);
            this.labelPha1.Name = "labelPha1";
            this.labelPha1.Size = new System.Drawing.Size(35, 13);
            this.labelPha1.TabIndex = 4;
            this.labelPha1.Text = "label1";
            // 
            // labelFreq2
            // 
            this.labelFreq2.AutoSize = true;
            this.labelFreq2.Location = new System.Drawing.Point(259, 188);
            this.labelFreq2.Name = "labelFreq2";
            this.labelFreq2.Size = new System.Drawing.Size(35, 13);
            this.labelFreq2.TabIndex = 4;
            this.labelFreq2.Text = "label1";
            // 
            // labelAmp2
            // 
            this.labelAmp2.AutoSize = true;
            this.labelAmp2.Location = new System.Drawing.Point(259, 220);
            this.labelAmp2.Name = "labelAmp2";
            this.labelAmp2.Size = new System.Drawing.Size(35, 13);
            this.labelAmp2.TabIndex = 4;
            this.labelAmp2.Text = "label1";
            // 
            // labelPha2
            // 
            this.labelPha2.AutoSize = true;
            this.labelPha2.Location = new System.Drawing.Point(259, 255);
            this.labelPha2.Name = "labelPha2";
            this.labelPha2.Size = new System.Drawing.Size(35, 13);
            this.labelPha2.TabIndex = 4;
            this.labelPha2.Text = "label1";
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Freq";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Freq";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phase";
            // 
            // radioButtonWaveform
            // 
            this.radioButtonWaveform.AutoSize = true;
            this.radioButtonWaveform.Checked = true;
            this.radioButtonWaveform.Location = new System.Drawing.Point(54, 38);
            this.radioButtonWaveform.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWaveform.Name = "radioButtonWaveform";
            this.radioButtonWaveform.Size = new System.Drawing.Size(53, 17);
            this.radioButtonWaveform.TabIndex = 12;
            this.radioButtonWaveform.TabStop = true;
            this.radioButtonWaveform.Text = "Mixed";
            this.radioButtonWaveform.UseVisualStyleBackColor = true;
            this.radioButtonWaveform.CheckedChanged += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // radioButtonFreq1
            // 
            this.radioButtonFreq1.AutoSize = true;
            this.radioButtonFreq1.Location = new System.Drawing.Point(54, 107);
            this.radioButtonFreq1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFreq1.Name = "radioButtonFreq1";
            this.radioButtonFreq1.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFreq1.TabIndex = 12;
            this.radioButtonFreq1.Text = "Freq1";
            this.radioButtonFreq1.UseVisualStyleBackColor = true;
            this.radioButtonFreq1.CheckedChanged += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // radioButtonFreq2
            // 
            this.radioButtonFreq2.AutoSize = true;
            this.radioButtonFreq2.Location = new System.Drawing.Point(54, 216);
            this.radioButtonFreq2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFreq2.Name = "radioButtonFreq2";
            this.radioButtonFreq2.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFreq2.TabIndex = 12;
            this.radioButtonFreq2.Text = "Freq2";
            this.radioButtonFreq2.UseVisualStyleBackColor = true;
            this.radioButtonFreq2.CheckedChanged += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // chartWaveform
            // 
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = double.NaN;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.PeachPuff;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea1.AxisX.Title = "Waveform";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 61.91277F;
            chartArea1.InnerPlotPosition.Width = 92.22284F;
            chartArea1.InnerPlotPosition.X = 6.66014F;
            chartArea1.InnerPlotPosition.Y = 5.76923F;
            chartArea1.Name = "ChartArea1";
            chartArea2.AxisX.Title = "Freq";
            chartArea2.BackColor = System.Drawing.Color.Teal;
            chartArea2.Name = "ChartArea2";
            this.chartWaveform.ChartAreas.Add(chartArea1);
            this.chartWaveform.ChartAreas.Add(chartArea2);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartWaveform.Legends.Add(legend1);
            this.chartWaveform.Location = new System.Drawing.Point(361, 38);
            this.chartWaveform.Name = "chartWaveform";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series1.Legend = "Legend1";
            series1.Name = "Waveform";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartWaveform.Series.Add(series1);
            this.chartWaveform.Series.Add(series2);
            this.chartWaveform.Size = new System.Drawing.Size(710, 377);
            this.chartWaveform.TabIndex = 0;
            this.chartWaveform.Text = "chart1";
            this.chartWaveform.Click += new System.EventHandler(this.chartWaveform_Click);
            // 
            // FormRealtimeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 465);
            this.Controls.Add(this.radioButtonFreq2);
            this.Controls.Add(this.radioButtonFreq1);
            this.Controls.Add(this.radioButtonWaveform);
            this.Controls.Add(this.labelPha2);
            this.Controls.Add(this.labelAmp2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPha1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFreq2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAmp1);
            this.Controls.Add(this.labelFreq1);
            this.Controls.Add(this.trackBarPha2);
            this.Controls.Add(this.trackBarAmp2);
            this.Controls.Add(this.trackBarPha1);
            this.Controls.Add(this.trackBarFreq2);
            this.Controls.Add(this.trackBarAmp1);
            this.Controls.Add(this.trackBarFreq1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartWaveform);
            this.Name = "FormRealtimeChart";
            this.Text = "Realtime Chart";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBarFreq1;
        private System.Windows.Forms.TrackBar trackBarAmp1;
        private System.Windows.Forms.TrackBar trackBarPha1;
        private System.Windows.Forms.TrackBar trackBarFreq2;
        private System.Windows.Forms.TrackBar trackBarAmp2;
        private System.Windows.Forms.TrackBar trackBarPha2;
        private System.Windows.Forms.Label labelFreq1;
        private System.Windows.Forms.Label labelAmp1;
        private System.Windows.Forms.Label labelPha1;
        private System.Windows.Forms.Label labelFreq2;
        private System.Windows.Forms.Label labelAmp2;
        private System.Windows.Forms.Label labelPha2;
        private System.Windows.Forms.Timer chartUpdateTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonWaveform;
        private System.Windows.Forms.RadioButton radioButtonFreq1;
        private System.Windows.Forms.RadioButton radioButtonFreq2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaveform;
    }
}

