namespace CSV_Verarbeitung
{
    partial class Charts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.stringBarChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.stringPieChart = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Century Gothic", 9F);
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(850, 500);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.HotTrack = true;
            this.tabControlAdv1.ImageAlignmentR = Syncfusion.Windows.Forms.Tools.RelativeImageAlignment.AboveText;
            this.tabControlAdv1.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Multiline = true;
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(850, 500);
            this.tabControlAdv1.TabIndex = 2;
            this.tabControlAdv1.TabPrimitivesHost.Alignment = Syncfusion.Windows.Forms.Tools.TabPrimitiveHostAlignment.Far;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            this.tabControlAdv1.ThemeName = "TabRendererOffice2016White";
            this.tabControlAdv1.ThemesEnabled = true;
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv1.Controls.Add(this.stringBarChart);
            this.tabPageAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(2, 27);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(846, 471);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Balkendiagramm";
            this.tabPageAdv1.ThemesEnabled = true;
            // 
            // stringBarChart
            // 
            this.stringBarChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.stringBarChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stringBarChart.Location = new System.Drawing.Point(10, 10);
            this.stringBarChart.Name = "stringBarChart";
            this.stringBarChart.Size = new System.Drawing.Size(826, 451);
            this.stringBarChart.TabIndex = 1;
            this.stringBarChart.Text = "cartesianChart1";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv2.Controls.Add(this.stringPieChart);
            this.tabPageAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(2, 27);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(846, 471);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Tortendiagramm";
            this.tabPageAdv2.ThemesEnabled = true;
            // 
            // stringPieChart
            // 
            this.stringPieChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.stringPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stringPieChart.Location = new System.Drawing.Point(10, 10);
            this.stringPieChart.Name = "stringPieChart";
            this.stringPieChart.Size = new System.Drawing.Size(826, 451);
            this.stringPieChart.TabIndex = 4;
            this.stringPieChart.Text = "pieChart1";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.tabControlAdv1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(866, 539);
            this.Name = "Charts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Verarbeitung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Charts_FormClosing);
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private LiveCharts.WinForms.CartesianChart stringBarChart;
        private LiveCharts.WinForms.PieChart stringPieChart;
    }
}