namespace CryptoCurrencyApp
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dashboardChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cryptoCurrency21 = new CryptoCurrencyApp.CryptoCurrency2();
            this.cryptoCurrency11 = new CryptoCurrencyApp.CryptoCurrency1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 644);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 460);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(308, 146);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 146);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 146);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 146);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.dashboardChart);
            this.panel2.Controls.Add(this.cryptoCurrency11);
            this.panel2.Controls.Add(this.cryptoCurrency21);
            this.panel2.Location = new System.Drawing.Point(323, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1511, 743);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1027, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(308, 146);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dashboardChart
            // 
            chartArea2.Name = "ChartArea1";
            this.dashboardChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dashboardChart.Legends.Add(legend2);
            this.dashboardChart.Location = new System.Drawing.Point(3, 6);
            this.dashboardChart.Name = "dashboardChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.dashboardChart.Series.Add(series3);
            this.dashboardChart.Series.Add(series4);
            this.dashboardChart.Size = new System.Drawing.Size(1018, 638);
            this.dashboardChart.TabIndex = 0;
            this.dashboardChart.Text = "chart1";
            // 
            // cryptoCurrency21
            // 
            this.cryptoCurrency21.Location = new System.Drawing.Point(-3, 0);
            this.cryptoCurrency21.Name = "cryptoCurrency21";
            this.cryptoCurrency21.Size = new System.Drawing.Size(1554, 748);
            this.cryptoCurrency21.TabIndex = 5;
            // 
            // cryptoCurrency11
            // 
            this.cryptoCurrency11.Location = new System.Drawing.Point(0, 0);
            this.cryptoCurrency11.Name = "cryptoCurrency11";
            this.cryptoCurrency11.Size = new System.Drawing.Size(1511, 766);
            this.cryptoCurrency11.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 791);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart dashboardChart;
        private CryptoCurrency1 cryptoCurrency11;
        private CryptoCurrency2 cryptoCurrency21;
        private System.Windows.Forms.Button button5;
    }
}

