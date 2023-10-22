namespace ChartApp
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)sysChart).BeginInit();
            SuspendLayout();
            // 
            // sysChart
            // 
            chartArea2.Name = "ChartArea1";
            sysChart.ChartAreas.Add(chartArea2);
            sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            sysChart.Legends.Add(legend2);
            sysChart.Location = new System.Drawing.Point(0, 0);
            sysChart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            sysChart.Name = "sysChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            sysChart.Series.Add(series2);
            sysChart.Size = new System.Drawing.Size(1440, 1098);
            sysChart.TabIndex = 0;
            sysChart.Text = "sysChart";
            sysChart.Click += sysChart_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(1235, 946);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1440, 1098);
            Controls.Add(button1);
            Controls.Add(sysChart);
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "Main";
            Text = "System Metrics";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)sysChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button button1;
    }
}

