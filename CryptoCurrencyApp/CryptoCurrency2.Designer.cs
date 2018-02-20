namespace CryptoCurrencyApp
{
    partial class CryptoCurrency2
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.refreshCurrency = new System.Windows.Forms.Button();
            this.cryptoCurrency2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userLowLabel = new System.Windows.Forms.Label();
            this.userHighLabel = new System.Windows.Forms.Label();
            this.setUserLow = new System.Windows.Forms.Button();
            this.getUserLow = new System.Windows.Forms.TextBox();
            this.setUserHigh = new System.Windows.Forms.Button();
            this.getUserHigh = new System.Windows.Forms.TextBox();
            this.graphSlope = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoCurrency2Chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshCurrency
            // 
            this.refreshCurrency.Location = new System.Drawing.Point(1116, 99);
            this.refreshCurrency.Name = "refreshCurrency";
            this.refreshCurrency.Size = new System.Drawing.Size(308, 133);
            this.refreshCurrency.TabIndex = 4;
            this.refreshCurrency.Text = "Start";
            this.refreshCurrency.UseVisualStyleBackColor = true;
            this.refreshCurrency.Click += new System.EventHandler(this.refreshCurrency_Click);
            // 
            // cryptoCurrency2Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.cryptoCurrency2Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cryptoCurrency2Chart.Legends.Add(legend1);
            this.cryptoCurrency2Chart.Location = new System.Drawing.Point(3, 3);
            this.cryptoCurrency2Chart.Name = "cryptoCurrency2Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cryptoCurrency2Chart.Series.Add(series1);
            this.cryptoCurrency2Chart.Size = new System.Drawing.Size(1018, 638);
            this.cryptoCurrency2Chart.TabIndex = 3;
            this.cryptoCurrency2Chart.Text = "chart1";
            // 
            // userLowLabel
            // 
            this.userLowLabel.AutoSize = true;
            this.userLowLabel.Location = new System.Drawing.Point(1042, 398);
            this.userLowLabel.Name = "userLowLabel";
            this.userLowLabel.Size = new System.Drawing.Size(328, 20);
            this.userLowLabel.TabIndex = 15;
            this.userLowLabel.Text = "Alert me when the Cryptocurrency falls below:";
            // 
            // userHighLabel
            // 
            this.userHighLabel.AutoSize = true;
            this.userHighLabel.Location = new System.Drawing.Point(1042, 264);
            this.userHighLabel.Name = "userHighLabel";
            this.userHighLabel.Size = new System.Drawing.Size(335, 20);
            this.userHighLabel.TabIndex = 14;
            this.userHighLabel.Text = "Alert me when the Cryptocurrency rises above:";
            // 
            // setUserLow
            // 
            this.setUserLow.Location = new System.Drawing.Point(1302, 449);
            this.setUserLow.Name = "setUserLow";
            this.setUserLow.Size = new System.Drawing.Size(93, 34);
            this.setUserLow.TabIndex = 13;
            this.setUserLow.Text = "Update";
            this.setUserLow.UseVisualStyleBackColor = true;
            this.setUserLow.Click += new System.EventHandler(this.setUserLow_Click);
            // 
            // getUserLow
            // 
            this.getUserLow.Location = new System.Drawing.Point(1376, 398);
            this.getUserLow.Name = "getUserLow";
            this.getUserLow.Size = new System.Drawing.Size(121, 26);
            this.getUserLow.TabIndex = 12;
            // 
            // setUserHigh
            // 
            this.setUserHigh.Location = new System.Drawing.Point(1302, 308);
            this.setUserHigh.Name = "setUserHigh";
            this.setUserHigh.Size = new System.Drawing.Size(93, 31);
            this.setUserHigh.TabIndex = 11;
            this.setUserHigh.Text = "Update";
            this.setUserHigh.UseVisualStyleBackColor = true;
            this.setUserHigh.Click += new System.EventHandler(this.setUserHigh_Click);
            // 
            // getUserHigh
            // 
            this.getUserHigh.Location = new System.Drawing.Point(1383, 264);
            this.getUserHigh.Name = "getUserHigh";
            this.getUserHigh.Size = new System.Drawing.Size(121, 26);
            this.getUserHigh.TabIndex = 10;
            // 
            // graphSlope
            // 
            this.graphSlope.AutoSize = true;
            this.graphSlope.Location = new System.Drawing.Point(3, 644);
            this.graphSlope.Name = "graphSlope";
            this.graphSlope.Size = new System.Drawing.Size(35, 20);
            this.graphSlope.TabIndex = 16;
            this.graphSlope.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(1129, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 154);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(33, 109);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1211, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Currency";
            // 
            // CryptoCurrency2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graphSlope);
            this.Controls.Add(this.userLowLabel);
            this.Controls.Add(this.userHighLabel);
            this.Controls.Add(this.setUserLow);
            this.Controls.Add(this.getUserLow);
            this.Controls.Add(this.setUserHigh);
            this.Controls.Add(this.getUserHigh);
            this.Controls.Add(this.refreshCurrency);
            this.Controls.Add(this.cryptoCurrency2Chart);
            this.Name = "CryptoCurrency2";
            this.Size = new System.Drawing.Size(1536, 808);
            ((System.ComponentModel.ISupportInitialize)(this.cryptoCurrency2Chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshCurrency;
        private System.Windows.Forms.DataVisualization.Charting.Chart cryptoCurrency2Chart;
        private System.Windows.Forms.Label userLowLabel;
        private System.Windows.Forms.Label userHighLabel;
        private System.Windows.Forms.Button setUserLow;
        private System.Windows.Forms.TextBox getUserLow;
        private System.Windows.Forms.Button setUserHigh;
        private System.Windows.Forms.TextBox getUserHigh;
        private System.Windows.Forms.Label graphSlope;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}
