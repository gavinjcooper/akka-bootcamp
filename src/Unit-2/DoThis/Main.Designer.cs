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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnDisk = new System.Windows.Forms.Button();
            btnMemory = new System.Windows.Forms.Button();
            btnCpu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)sysChart).BeginInit();
            SuspendLayout();
            // 
            // sysChart
            // 
            chartArea1.Name = "ChartArea1";
            sysChart.ChartAreas.Add(chartArea1);
            sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            sysChart.Legends.Add(legend1);
            sysChart.Location = new System.Drawing.Point(0, 0);
            sysChart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            sysChart.Name = "sysChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            sysChart.Series.Add(series1);
            sysChart.Size = new System.Drawing.Size(1440, 1098);
            sysChart.TabIndex = 0;
            sysChart.Text = "sysChart";
            // 
            // btnDisk
            // 
            btnDisk.Location = new System.Drawing.Point(1188, 946);
            btnDisk.Name = "btnDisk";
            btnDisk.Size = new System.Drawing.Size(197, 46);
            btnDisk.TabIndex = 1;
            btnDisk.Text = "DISK (OFF)";
            btnDisk.UseVisualStyleBackColor = true;
            btnDisk.Click += btnDisk_Click;
            // 
            // btnMemory
            // 
            btnMemory.Location = new System.Drawing.Point(1188, 894);
            btnMemory.Name = "btnMemory";
            btnMemory.Size = new System.Drawing.Size(197, 46);
            btnMemory.TabIndex = 2;
            btnMemory.Text = "MEMORY (OFF)";
            btnMemory.UseVisualStyleBackColor = true;
            btnMemory.Click += btnMemory_Click;
            // 
            // btnCpu
            // 
            btnCpu.Location = new System.Drawing.Point(1188, 842);
            btnCpu.Name = "btnCpu";
            btnCpu.Size = new System.Drawing.Size(197, 46);
            btnCpu.TabIndex = 3;
            btnCpu.Text = "CPU (ON)";
            btnCpu.UseVisualStyleBackColor = true;
            btnCpu.Click += btnCpu_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1440, 1098);
            Controls.Add(btnCpu);
            Controls.Add(btnMemory);
            Controls.Add(btnDisk);
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
        private System.Windows.Forms.Button btnDisk;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnCpu;
    }
}

