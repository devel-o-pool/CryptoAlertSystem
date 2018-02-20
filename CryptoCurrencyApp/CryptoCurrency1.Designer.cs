namespace CryptoCurrencyApp
{
    partial class CryptoCurrency1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cryptoCurrency1Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.refreshCurrency = new System.Windows.Forms.Button();
            this.getUserHigh = new System.Windows.Forms.TextBox();
            this.setUserHigh = new System.Windows.Forms.Button();
            this.getUserLow = new System.Windows.Forms.TextBox();
            this.setUserLow = new System.Windows.Forms.Button();
            this.graphSlope = new System.Windows.Forms.Label();
            this.userHighLabel = new System.Windows.Forms.Label();
            this.userLowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoCurrency1Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // cryptoCurrency1Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.cryptoCurrency1Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cryptoCurrency1Chart.Legends.Add(legend2);
            this.cryptoCurrency1Chart.Location = new System.Drawing.Point(3, 3);
            this.cryptoCurrency1Chart.Name = "cryptoCurrency1Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cryptoCurrency1Chart.Series.Add(series2);
            this.cryptoCurrency1Chart.Size = new System.Drawing.Size(1018, 638);
            this.cryptoCurrency1Chart.TabIndex = 1;
            this.cryptoCurrency1Chart.Text = "chart1";
            // 
            // refreshCurrency
            // 
            this.refreshCurrency.Location = new System.Drawing.Point(1027, 48);
            this.refreshCurrency.Name = "refreshCurrency";
            this.refreshCurrency.Size = new System.Drawing.Size(308, 133);
            this.refreshCurrency.TabIndex = 2;
            this.refreshCurrency.Text = "Start";
            this.refreshCurrency.UseVisualStyleBackColor = true;
            this.refreshCurrency.Click += new System.EventHandler(this.refreshCurrency_Click);
            // 
            // getUserHigh
            // 
            this.getUserHigh.Location = new System.Drawing.Point(1368, 265);
            this.getUserHigh.Name = "getUserHigh";
            this.getUserHigh.Size = new System.Drawing.Size(121, 26);
            this.getUserHigh.TabIndex = 3;
            // 
            // setUserHigh
            // 
            this.setUserHigh.Location = new System.Drawing.Point(1287, 309);
            this.setUserHigh.Name = "setUserHigh";
            this.setUserHigh.Size = new System.Drawing.Size(93, 31);
            this.setUserHigh.TabIndex = 4;
            this.setUserHigh.Text = "Update";
            this.setUserHigh.UseVisualStyleBackColor = true;
            this.setUserHigh.Click += new System.EventHandler(this.setUserHigh_Click);
            // 
            // getUserLow
            // 
            this.getUserLow.Location = new System.Drawing.Point(1361, 399);
            this.getUserLow.Name = "getUserLow";
            this.getUserLow.Size = new System.Drawing.Size(121, 26);
            this.getUserLow.TabIndex = 5;
            // 
            // setUserLow
            // 
            this.setUserLow.Location = new System.Drawing.Point(1287, 450);
            this.setUserLow.Name = "setUserLow";
            this.setUserLow.Size = new System.Drawing.Size(93, 34);
            this.setUserLow.TabIndex = 6;
            this.setUserLow.Text = "Update";
            this.setUserLow.UseVisualStyleBackColor = true;
            this.setUserLow.Click += new System.EventHandler(this.setUserLow_Click);
            // 
            // graphSlope
            // 
            this.graphSlope.AutoSize = true;
            this.graphSlope.Location = new System.Drawing.Point(3, 644);
            this.graphSlope.Name = "graphSlope";
            this.graphSlope.Size = new System.Drawing.Size(35, 20);
            this.graphSlope.TabIndex = 7;
            this.graphSlope.Text = "N/A";
            // 
            // userHighLabel
            // 
            this.userHighLabel.AutoSize = true;
            this.userHighLabel.Location = new System.Drawing.Point(1027, 265);
            this.userHighLabel.Name = "userHighLabel";
            this.userHighLabel.Size = new System.Drawing.Size(335, 20);
            this.userHighLabel.TabIndex = 8;
            this.userHighLabel.Text = "Alert me when the Cryptocurrency rises above:";
            // 
            // userLowLabel
            // 
            this.userLowLabel.AutoSize = true;
            this.userLowLabel.Location = new System.Drawing.Point(1027, 399);
            this.userLowLabel.Name = "userLowLabel";
            this.userLowLabel.Size = new System.Drawing.Size(328, 20);
            this.userLowLabel.TabIndex = 9;
            this.userLowLabel.Text = "Alert me when the Cryptocurrency falls below:";
            // 
            // CryptoCurrency1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userLowLabel);
            this.Controls.Add(this.userHighLabel);
            this.Controls.Add(this.graphSlope);
            this.Controls.Add(this.setUserLow);
            this.Controls.Add(this.getUserLow);
            this.Controls.Add(this.setUserHigh);
            this.Controls.Add(this.getUserHigh);
            this.Controls.Add(this.refreshCurrency);
            this.Controls.Add(this.cryptoCurrency1Chart);
            this.Name = "CryptoCurrency1";
            this.Size = new System.Drawing.Size(1549, 885);
            this.Load += new System.EventHandler(this.CryptoCurrency1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cryptoCurrency1Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cryptoCurrency1Chart;
        private System.Windows.Forms.Button refreshCurrency;
        private System.Windows.Forms.TextBox getUserHigh;
        private System.Windows.Forms.Button setUserHigh;
        private System.Windows.Forms.TextBox getUserLow;
        private System.Windows.Forms.Button setUserLow;
        private System.Windows.Forms.Label graphSlope;
        private System.Windows.Forms.Label userHighLabel;
        private System.Windows.Forms.Label userLowLabel;
    }
}
