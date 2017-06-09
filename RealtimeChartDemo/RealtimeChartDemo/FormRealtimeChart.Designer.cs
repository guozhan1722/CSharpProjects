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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBarFreq1 = new System.Windows.Forms.TrackBar();
            this.trackBarAmp1 = new System.Windows.Forms.TrackBar();
            this.trackBarPha1 = new System.Windows.Forms.TrackBar();
            this.trackBarFreq2 = new System.Windows.Forms.TrackBar();
            this.trackBarAmp2 = new System.Windows.Forms.TrackBar();
            this.trackBarPha2 = new System.Windows.Forms.TrackBar();
            this.trackBarFreq3 = new System.Windows.Forms.TrackBar();
            this.trackBarAmp3 = new System.Windows.Forms.TrackBar();
            this.trackBarPha3 = new System.Windows.Forms.TrackBar();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonWaveform = new System.Windows.Forms.RadioButton();
            this.radioButtonFreq1 = new System.Windows.Forms.RadioButton();
            this.radioButtonFreq2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFreq3 = new System.Windows.Forms.RadioButton();
            this.chartWaveform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarFreq1
            // 
            this.trackBarFreq1.Location = new System.Drawing.Point(95, 80);
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
            this.trackBarAmp1.Location = new System.Drawing.Point(95, 112);
            this.trackBarAmp1.Maximum = 100;
            this.trackBarAmp1.Name = "trackBarAmp1";
            this.trackBarAmp1.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmp1.TabIndex = 2;
            this.trackBarAmp1.Value = 50;
            this.trackBarAmp1.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarPha1
            // 
            this.trackBarPha1.Location = new System.Drawing.Point(95, 147);
            this.trackBarPha1.Minimum = 7;
            this.trackBarPha1.Name = "trackBarPha1";
            this.trackBarPha1.Size = new System.Drawing.Size(104, 45);
            this.trackBarPha1.TabIndex = 2;
            this.trackBarPha1.Value = 7;
            this.trackBarPha1.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarFreq2
            // 
            this.trackBarFreq2.Location = new System.Drawing.Point(95, 191);
            this.trackBarFreq2.Maximum = 200;
            this.trackBarFreq2.Name = "trackBarFreq2";
            this.trackBarFreq2.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq2.TabIndex = 2;
            this.trackBarFreq2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarAmp2
            // 
            this.trackBarAmp2.Location = new System.Drawing.Point(95, 222);
            this.trackBarAmp2.Maximum = 100;
            this.trackBarAmp2.Name = "trackBarAmp2";
            this.trackBarAmp2.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmp2.TabIndex = 2;
            this.trackBarAmp2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarPha2
            // 
            this.trackBarPha2.Location = new System.Drawing.Point(95, 258);
            this.trackBarPha2.Minimum = 7;
            this.trackBarPha2.Name = "trackBarPha2";
            this.trackBarPha2.Size = new System.Drawing.Size(104, 45);
            this.trackBarPha2.TabIndex = 2;
            this.trackBarPha2.Value = 7;
            this.trackBarPha2.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarFreq3
            // 
            this.trackBarFreq3.Location = new System.Drawing.Point(95, 309);
            this.trackBarFreq3.Maximum = 200;
            this.trackBarFreq3.Name = "trackBarFreq3";
            this.trackBarFreq3.Size = new System.Drawing.Size(104, 45);
            this.trackBarFreq3.TabIndex = 2;
            this.trackBarFreq3.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarAmp3
            // 
            this.trackBarAmp3.Location = new System.Drawing.Point(95, 340);
            this.trackBarAmp3.Maximum = 100;
            this.trackBarAmp3.Name = "trackBarAmp3";
            this.trackBarAmp3.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmp3.TabIndex = 2;
            this.trackBarAmp3.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // trackBarPha3
            // 
            this.trackBarPha3.Location = new System.Drawing.Point(95, 376);
            this.trackBarPha3.Minimum = 7;
            this.trackBarPha3.Name = "trackBarPha3";
            this.trackBarPha3.Size = new System.Drawing.Size(104, 45);
            this.trackBarPha3.TabIndex = 2;
            this.trackBarPha3.Value = 7;
            this.trackBarPha3.Scroll += new System.EventHandler(this.trackBarAmp1_Scroll);
            this.trackBarPha3.SizeChanged += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // labelFreq1
            // 
            this.labelFreq1.AutoSize = true;
            this.labelFreq1.Location = new System.Drawing.Point(216, 80);
            this.labelFreq1.Name = "labelFreq1";
            this.labelFreq1.Size = new System.Drawing.Size(35, 13);
            this.labelFreq1.TabIndex = 4;
            this.labelFreq1.Text = "label1";
            // 
            // labelAmp1
            // 
            this.labelAmp1.AutoSize = true;
            this.labelAmp1.Location = new System.Drawing.Point(216, 112);
            this.labelAmp1.Name = "labelAmp1";
            this.labelAmp1.Size = new System.Drawing.Size(35, 13);
            this.labelAmp1.TabIndex = 4;
            this.labelAmp1.Text = "label1";
            // 
            // labelPha1
            // 
            this.labelPha1.AutoSize = true;
            this.labelPha1.Location = new System.Drawing.Point(216, 147);
            this.labelPha1.Name = "labelPha1";
            this.labelPha1.Size = new System.Drawing.Size(35, 13);
            this.labelPha1.TabIndex = 4;
            this.labelPha1.Text = "label1";
            // 
            // labelFreq2
            // 
            this.labelFreq2.AutoSize = true;
            this.labelFreq2.Location = new System.Drawing.Point(216, 191);
            this.labelFreq2.Name = "labelFreq2";
            this.labelFreq2.Size = new System.Drawing.Size(35, 13);
            this.labelFreq2.TabIndex = 4;
            this.labelFreq2.Text = "label1";
            // 
            // labelAmp2
            // 
            this.labelAmp2.AutoSize = true;
            this.labelAmp2.Location = new System.Drawing.Point(216, 223);
            this.labelAmp2.Name = "labelAmp2";
            this.labelAmp2.Size = new System.Drawing.Size(35, 13);
            this.labelAmp2.TabIndex = 4;
            this.labelAmp2.Text = "label1";
            // 
            // labelPha2
            // 
            this.labelPha2.AutoSize = true;
            this.labelPha2.Location = new System.Drawing.Point(216, 258);
            this.labelPha2.Name = "labelPha2";
            this.labelPha2.Size = new System.Drawing.Size(35, 13);
            this.labelPha2.TabIndex = 4;
            this.labelPha2.Text = "label1";
            // 
            // labelFreq3
            // 
            this.labelFreq3.AutoSize = true;
            this.labelFreq3.Location = new System.Drawing.Point(216, 309);
            this.labelFreq3.Name = "labelFreq3";
            this.labelFreq3.Size = new System.Drawing.Size(35, 13);
            this.labelFreq3.TabIndex = 4;
            this.labelFreq3.Text = "label1";
            // 
            // labelAmp3
            // 
            this.labelAmp3.AutoSize = true;
            this.labelAmp3.Location = new System.Drawing.Point(216, 341);
            this.labelAmp3.Name = "labelAmp3";
            this.labelAmp3.Size = new System.Drawing.Size(35, 13);
            this.labelAmp3.TabIndex = 4;
            this.labelAmp3.Text = "label1";
            // 
            // labelPha3
            // 
            this.labelPha3.AutoSize = true;
            this.labelPha3.Location = new System.Drawing.Point(216, 376);
            this.labelPha3.Name = "labelPha3";
            this.labelPha3.Size = new System.Drawing.Size(35, 13);
            this.labelPha3.TabIndex = 4;
            this.labelPha3.Text = "label1";
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Freq";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Freq";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Freq";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Amp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Phase";
            // 
            // radioButtonWaveform
            // 
            this.radioButtonWaveform.AutoSize = true;
            this.radioButtonWaveform.Checked = true;
            this.radioButtonWaveform.Location = new System.Drawing.Point(11, 41);
            this.radioButtonWaveform.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.radioButtonFreq1.Location = new System.Drawing.Point(11, 110);
            this.radioButtonFreq1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.radioButtonFreq2.Location = new System.Drawing.Point(11, 219);
            this.radioButtonFreq2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFreq2.Name = "radioButtonFreq2";
            this.radioButtonFreq2.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFreq2.TabIndex = 12;
            this.radioButtonFreq2.Text = "Freq2";
            this.radioButtonFreq2.UseVisualStyleBackColor = true;
            this.radioButtonFreq2.CheckedChanged += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // radioButtonFreq3
            // 
            this.radioButtonFreq3.AutoSize = true;
            this.radioButtonFreq3.Location = new System.Drawing.Point(4, 337);
            this.radioButtonFreq3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFreq3.Name = "radioButtonFreq3";
            this.radioButtonFreq3.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFreq3.TabIndex = 12;
            this.radioButtonFreq3.Text = "Freq3";
            this.radioButtonFreq3.UseVisualStyleBackColor = true;
            this.radioButtonFreq3.CheckedChanged += new System.EventHandler(this.trackBarAmp1_Scroll);
            // 
            // chartWaveform
            // 
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.Interval = double.NaN;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.PeachPuff;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea2.AxisX.Title = "Waveform";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Blue;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea2.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 61.91277F;
            chartArea2.InnerPlotPosition.Width = 92.22284F;
            chartArea2.InnerPlotPosition.X = 6.66014F;
            chartArea2.InnerPlotPosition.Y = 5.76923F;
            chartArea2.Name = "ChartArea1";
            this.chartWaveform.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartWaveform.Legends.Add(legend2);
            this.chartWaveform.Location = new System.Drawing.Point(298, 28);
            this.chartWaveform.Name = "chartWaveform";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series5.Legend = "Legend1";
            series5.Name = "Waveform";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Legend = "Legend1";
            series7.Name = "Series2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.Name = "Series3";
            this.chartWaveform.Series.Add(series5);
            this.chartWaveform.Series.Add(series6);
            this.chartWaveform.Series.Add(series7);
            this.chartWaveform.Series.Add(series8);
            this.chartWaveform.Size = new System.Drawing.Size(827, 294);
            this.chartWaveform.TabIndex = 0;
            this.chartWaveform.Text = "chart1";
            this.chartWaveform.Click += new System.EventHandler(this.chartWaveform_Click);
            // 
            // FormRealtimeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 465);
            this.Controls.Add(this.radioButtonFreq3);
            this.Controls.Add(this.radioButtonFreq2);
            this.Controls.Add(this.radioButtonFreq1);
            this.Controls.Add(this.radioButtonWaveform);
            this.Controls.Add(this.labelPha3);
            this.Controls.Add(this.labelAmp3);
            this.Controls.Add(this.labelPha2);
            this.Controls.Add(this.labelAmp2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelFreq3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPha1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFreq2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAmp1);
            this.Controls.Add(this.labelFreq1);
            this.Controls.Add(this.trackBarPha3);
            this.Controls.Add(this.trackBarAmp3);
            this.Controls.Add(this.trackBarPha2);
            this.Controls.Add(this.trackBarAmp2);
            this.Controls.Add(this.trackBarFreq3);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPha3)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBarFreq3;
        private System.Windows.Forms.TrackBar trackBarAmp3;
        private System.Windows.Forms.TrackBar trackBarPha3;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonWaveform;
        private System.Windows.Forms.RadioButton radioButtonFreq1;
        private System.Windows.Forms.RadioButton radioButtonFreq2;
        private System.Windows.Forms.RadioButton radioButtonFreq3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaveform;
    }
}

