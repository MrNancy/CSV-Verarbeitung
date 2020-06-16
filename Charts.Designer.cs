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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.StringChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DecimalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StringChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecimalChart)).BeginInit();
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
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControlAdv1.TabPrimitivesHost.Alignment = Syncfusion.Windows.Forms.Tools.TabPrimitiveHostAlignment.Far;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            this.tabControlAdv1.ThemeName = "TabRendererOffice2016White";
            this.tabControlAdv1.ThemesEnabled = true;
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv1.Controls.Add(this.StringChart);
            this.tabPageAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(2, 27);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(846, 471);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "STRING";
            this.tabPageAdv1.ThemesEnabled = true;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv2.Controls.Add(this.DecimalChart);
            this.tabPageAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(2, 27);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(846, 471);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "DECIMAL";
            this.tabPageAdv2.ThemesEnabled = true;
            // 
            // StringChart
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.StringChart.ChartAreas.Add(chartArea1);
            this.StringChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StringChart.IsSoftShadows = false;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.StringChart.Legends.Add(legend1);
            this.StringChart.Location = new System.Drawing.Point(0, 0);
            this.StringChart.Name = "StringChart";
            this.StringChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.StringChart.Series.Add(series1);
            this.StringChart.Size = new System.Drawing.Size(846, 471);
            this.StringChart.SuppressExceptions = true;
            this.StringChart.TabIndex = 1;
            this.StringChart.Text = "chart1";
            this.StringChart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StringChart_MouseDoubleClick);
            // 
            // DecimalChart
            // 
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.DecimalChart.ChartAreas.Add(chartArea2);
            this.DecimalChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.DecimalChart.Legends.Add(legend2);
            this.DecimalChart.Location = new System.Drawing.Point(0, 0);
            this.DecimalChart.Name = "DecimalChart";
            this.DecimalChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.DecimalChart.Series.Add(series2);
            this.DecimalChart.Size = new System.Drawing.Size(846, 471);
            this.DecimalChart.TabIndex = 2;
            this.DecimalChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::CSV_Verarbeitung.Properties.Resources.Bar_Chart_48px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(825, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlAdv1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(866, 539);
            this.Name = "Charts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Verarbeitung";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StringChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecimalChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private System.Windows.Forms.DataVisualization.Charting.Chart StringChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DecimalChart;
        private System.Windows.Forms.Button button1;
    }
}