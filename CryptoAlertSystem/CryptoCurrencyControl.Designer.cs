namespace CryptoAlertSystem
{
    partial class CryptoCurrencyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CryptoCurrencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton = new System.Windows.Forms.Button();
            this.CurrentValueLabel = new System.Windows.Forms.Label();
            this.Trend = new System.Windows.Forms.Label();
            this.CurrencyPicker = new System.Windows.Forms.GroupBox();
            this.PickZec = new System.Windows.Forms.RadioButton();
            this.PickDash = new System.Windows.Forms.RadioButton();
            this.PickLitecoin = new System.Windows.Forms.RadioButton();
            this.PickEthereum = new System.Windows.Forms.RadioButton();
            this.PickBitcoin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserHighTextBox = new System.Windows.Forms.TextBox();
            this.UserLowTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HighLabel = new System.Windows.Forms.Label();
            this.LowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CryptoCurrencyChart)).BeginInit();
            this.CurrencyPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // CryptoCurrencyChart
            // 
            this.CryptoCurrencyChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "CryptoCurrencyChartArea";
            this.CryptoCurrencyChart.ChartAreas.Add(chartArea1);
            this.CryptoCurrencyChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CryptoCurrencyChart.Location = new System.Drawing.Point(0, 0);
            this.CryptoCurrencyChart.Name = "CryptoCurrencyChart";
            series1.ChartArea = "CryptoCurrencyChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "LabelStyle=Top";
            series1.Name = "CurrencySeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.CryptoCurrencyChart.Series.Add(series1);
            this.CryptoCurrencyChart.Size = new System.Drawing.Size(1060, 643);
            this.CryptoCurrencyChart.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(3, 649);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(147, 58);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CurrentValueLabel
            // 
            this.CurrentValueLabel.AutoSize = true;
            this.CurrentValueLabel.Location = new System.Drawing.Point(1174, 93);
            this.CurrentValueLabel.Name = "CurrentValueLabel";
            this.CurrentValueLabel.Size = new System.Drawing.Size(103, 20);
            this.CurrentValueLabel.TabIndex = 3;
            this.CurrentValueLabel.Text = "CurrentValue";
            // 
            // Trend
            // 
            this.Trend.AutoSize = true;
            this.Trend.Location = new System.Drawing.Point(1174, 183);
            this.Trend.Name = "Trend";
            this.Trend.Size = new System.Drawing.Size(50, 20);
            this.Trend.TabIndex = 4;
            this.Trend.Text = "Trend";
            // 
            // CurrencyPicker
            // 
            this.CurrencyPicker.Controls.Add(this.PickZec);
            this.CurrencyPicker.Controls.Add(this.PickDash);
            this.CurrencyPicker.Controls.Add(this.PickLitecoin);
            this.CurrencyPicker.Controls.Add(this.PickEthereum);
            this.CurrencyPicker.Controls.Add(this.PickBitcoin);
            this.CurrencyPicker.Location = new System.Drawing.Point(1123, 534);
            this.CurrencyPicker.Name = "CurrencyPicker";
            this.CurrencyPicker.Size = new System.Drawing.Size(200, 294);
            this.CurrencyPicker.TabIndex = 6;
            this.CurrencyPicker.TabStop = false;
            this.CurrencyPicker.Text = "Pick a Currency";
            // 
            // PickZec
            // 
            this.PickZec.AutoSize = true;
            this.PickZec.Location = new System.Drawing.Point(68, 264);
            this.PickZec.Name = "PickZec";
            this.PickZec.Size = new System.Drawing.Size(61, 24);
            this.PickZec.TabIndex = 4;
            this.PickZec.TabStop = true;
            this.PickZec.Text = "Zec";
            this.PickZec.UseVisualStyleBackColor = true;
            this.PickZec.CheckedChanged += new System.EventHandler(this.PickZec_CheckedChanged);
            // 
            // PickDash
            // 
            this.PickDash.AutoSize = true;
            this.PickDash.Location = new System.Drawing.Point(68, 207);
            this.PickDash.Name = "PickDash";
            this.PickDash.Size = new System.Drawing.Size(72, 24);
            this.PickDash.TabIndex = 3;
            this.PickDash.TabStop = true;
            this.PickDash.Text = "Dash";
            this.PickDash.UseVisualStyleBackColor = true;
            this.PickDash.CheckedChanged += new System.EventHandler(this.PickDash_CheckedChanged);
            // 
            // PickLitecoin
            // 
            this.PickLitecoin.AutoSize = true;
            this.PickLitecoin.Location = new System.Drawing.Point(68, 145);
            this.PickLitecoin.Name = "PickLitecoin";
            this.PickLitecoin.Size = new System.Drawing.Size(89, 24);
            this.PickLitecoin.TabIndex = 2;
            this.PickLitecoin.TabStop = true;
            this.PickLitecoin.Text = "Litecoin";
            this.PickLitecoin.UseVisualStyleBackColor = true;
            this.PickLitecoin.CheckedChanged += new System.EventHandler(this.PickLitecoin_CheckedChanged);
            // 
            // PickEthereum
            // 
            this.PickEthereum.AutoSize = true;
            this.PickEthereum.Location = new System.Drawing.Point(68, 84);
            this.PickEthereum.Name = "PickEthereum";
            this.PickEthereum.Size = new System.Drawing.Size(104, 24);
            this.PickEthereum.TabIndex = 1;
            this.PickEthereum.TabStop = true;
            this.PickEthereum.Text = "Ethereum";
            this.PickEthereum.UseVisualStyleBackColor = true;
            this.PickEthereum.CheckedChanged += new System.EventHandler(this.PickEthereum_CheckedChanged);
            // 
            // PickBitcoin
            // 
            this.PickBitcoin.AutoSize = true;
            this.PickBitcoin.Location = new System.Drawing.Point(68, 25);
            this.PickBitcoin.Name = "PickBitcoin";
            this.PickBitcoin.Size = new System.Drawing.Size(82, 24);
            this.PickBitcoin.TabIndex = 0;
            this.PickBitcoin.TabStop = true;
            this.PickBitcoin.Text = "Bitcoin";
            this.PickBitcoin.UseVisualStyleBackColor = true;
            this.PickBitcoin.CheckedChanged += new System.EventHandler(this.PickBitcoin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alert me when the currency rises above: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 728);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alert me when the currency falls below: $";
            // 
            // UserHighTextBox
            // 
            this.UserHighTextBox.Location = new System.Drawing.Point(859, 649);
            this.UserHighTextBox.Name = "UserHighTextBox";
            this.UserHighTextBox.Size = new System.Drawing.Size(100, 26);
            this.UserHighTextBox.TabIndex = 9;
            this.UserHighTextBox.TextChanged += new System.EventHandler(this.UserHighTextBox_TextChanged);
            // 
            // UserLowTextBox
            // 
            this.UserLowTextBox.Location = new System.Drawing.Point(859, 728);
            this.UserLowTextBox.Name = "UserLowTextBox";
            this.UserLowTextBox.Size = new System.Drawing.Size(100, 26);
            this.UserLowTextBox.TabIndex = 10;
            this.UserLowTextBox.TextChanged += new System.EventHandler(this.UserLowTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1123, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Today\'s High";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1123, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Today\'s Low";
            // 
            // HighLabel
            // 
            this.HighLabel.AutoSize = true;
            this.HighLabel.Location = new System.Drawing.Point(1271, 282);
            this.HighLabel.Name = "HighLabel";
            this.HighLabel.Size = new System.Drawing.Size(18, 20);
            this.HighLabel.TabIndex = 13;
            this.HighLabel.Text = "0";
            // 
            // LowLabel
            // 
            this.LowLabel.AutoSize = true;
            this.LowLabel.Location = new System.Drawing.Point(1270, 365);
            this.LowLabel.Name = "LowLabel";
            this.LowLabel.Size = new System.Drawing.Size(18, 20);
            this.LowLabel.TabIndex = 14;
            this.LowLabel.Text = "0";
            // 
            // CryptoCurrencyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.LowLabel);
            this.Controls.Add(this.HighLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserLowTextBox);
            this.Controls.Add(this.UserHighTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrencyPicker);
            this.Controls.Add(this.Trend);
            this.Controls.Add(this.CurrentValueLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CryptoCurrencyChart);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "CryptoCurrencyControl";
            this.Size = new System.Drawing.Size(1414, 831);
            ((System.ComponentModel.ISupportInitialize)(this.CryptoCurrencyChart)).EndInit();
            this.CurrencyPicker.ResumeLayout(false);
            this.CurrencyPicker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CryptoCurrencyChart;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label CurrentValueLabel;
        private System.Windows.Forms.Label Trend;
        private System.Windows.Forms.GroupBox CurrencyPicker;
        private System.Windows.Forms.RadioButton PickZec;
        private System.Windows.Forms.RadioButton PickDash;
        private System.Windows.Forms.RadioButton PickLitecoin;
        private System.Windows.Forms.RadioButton PickEthereum;
        private System.Windows.Forms.RadioButton PickBitcoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserHighTextBox;
        private System.Windows.Forms.TextBox UserLowTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HighLabel;
        private System.Windows.Forms.Label LowLabel;
    }
}
