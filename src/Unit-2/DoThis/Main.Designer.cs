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
            btnPauseResume = new System.Windows.Forms.Button();
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
            sysChart.Margin = new System.Windows.Forms.Padding(4);
            sysChart.Name = "sysChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            sysChart.Series.Add(series1);
            sysChart.Size = new System.Drawing.Size(874, 686);
            sysChart.TabIndex = 0;
            sysChart.Text = "sysChart";
            // 
            // btnDisk
            // 
            btnDisk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDisk.Location = new System.Drawing.Point(731, 570);
            btnDisk.Margin = new System.Windows.Forms.Padding(2);
            btnDisk.Name = "btnDisk";
            btnDisk.Size = new System.Drawing.Size(121, 50);
            btnDisk.TabIndex = 1;
            btnDisk.Text = "DISK (OFF)";
            btnDisk.UseVisualStyleBackColor = true;
            btnDisk.Click += btnDisk_Click;
            // 
            // btnMemory
            // 
            btnMemory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnMemory.Location = new System.Drawing.Point(731, 516);
            btnMemory.Margin = new System.Windows.Forms.Padding(2);
            btnMemory.Name = "btnMemory";
            btnMemory.Size = new System.Drawing.Size(121, 50);
            btnMemory.TabIndex = 2;
            btnMemory.Text = "MEMORY (OFF)";
            btnMemory.UseVisualStyleBackColor = true;
            btnMemory.Click += btnMemory_Click;
            // 
            // btnCpu
            // 
            btnCpu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCpu.Location = new System.Drawing.Point(731, 462);
            btnCpu.Margin = new System.Windows.Forms.Padding(2);
            btnCpu.Name = "btnCpu";
            btnCpu.Size = new System.Drawing.Size(121, 50);
            btnCpu.TabIndex = 3;
            btnCpu.Text = "CPU (ON)";
            btnCpu.UseVisualStyleBackColor = true;
            btnCpu.Click += btnCpu_Click;
            // 
            // btnPauseResume
            // 
            btnPauseResume.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnPauseResume.Location = new System.Drawing.Point(731, 354);
            btnPauseResume.Name = "btnPauseResume";
            btnPauseResume.Size = new System.Drawing.Size(121, 50);
            btnPauseResume.TabIndex = 4;
            btnPauseResume.Text = "PAUSE ||";
            btnPauseResume.UseVisualStyleBackColor = true;
            btnPauseResume.Click += btnPauseResume_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(874, 686);
            Controls.Add(btnPauseResume);
            Controls.Add(btnCpu);
            Controls.Add(btnMemory);
            Controls.Add(btnDisk);
            Controls.Add(sysChart);
            Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnPauseResume;
    }
}

