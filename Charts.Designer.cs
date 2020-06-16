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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo2 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            this.DecimalChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.StringChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecimalChart
            // 
            this.DecimalChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.DecimalChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.DecimalChart.ChartArea.CursorReDraw = false;
            this.DecimalChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.DecimalChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(144)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(190)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(66)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.DecimalChart.DataSourceName = "[none]";
            this.DecimalChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecimalChart.IsWindowLess = false;
            // 
            // 
            // 
            this.DecimalChart.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.DecimalChart.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.DecimalChart.Legend.Location = new System.Drawing.Point(291, 75);
            this.DecimalChart.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.DecimalChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.DecimalChart.Localize = null;
            this.DecimalChart.Location = new System.Drawing.Point(0, 0);
            this.DecimalChart.Name = "DecimalChart";
            this.DecimalChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.DecimalChart.PrimaryXAxis.Margin = true;
            this.DecimalChart.PrimaryXAxis.TickLabelsDrawingMode = Syncfusion.Windows.Forms.Chart.ChartAxisTickLabelDrawingMode.BothUserAndAutomaticMode;
            this.DecimalChart.PrimaryXAxis.Title = "X-Achse";
            this.DecimalChart.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.DecimalChart.PrimaryXAxis.ValueType = Syncfusion.Windows.Forms.Chart.ChartValueType.Custom;
            this.DecimalChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.DecimalChart.PrimaryYAxis.Margin = true;
            this.DecimalChart.PrimaryYAxis.Title = "Y-Achse";
            this.DecimalChart.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Series1";
            chartSeries1.Points.Add(0D, ((double)(0D)));
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.DisplayText = true;
            chartSeries1.Style.DrawTextShape = false;
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Series1";
            this.DecimalChart.Series.Add(chartSeries1);
            this.DecimalChart.Size = new System.Drawing.Size(843, 494);
            this.DecimalChart.TabIndex = 0;
            // 
            // 
            // 
            this.DecimalChart.Title.Name = "Default";
            this.DecimalChart.ToolBar.Border.ForeColor = System.Drawing.Color.White;
            this.DecimalChart.ToolBar.Border.Width = 0F;
            this.DecimalChart.VisualTheme = "";
            // 
            // StringChart
            // 
            this.StringChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.StringChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.StringChart.ChartArea.CursorReDraw = false;
            this.StringChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.StringChart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(144)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(190)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(66)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.StringChart.DataSourceName = "[none]";
            this.StringChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StringChart.IsWindowLess = false;
            // 
            // 
            // 
            this.StringChart.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.StringChart.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.StringChart.Legend.Location = new System.Drawing.Point(291, 75);
            this.StringChart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.StringChart.Localize = null;
            this.StringChart.Location = new System.Drawing.Point(0, 0);
            this.StringChart.Name = "StringChart";
            this.StringChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.StringChart.PrimaryXAxis.Margin = true;
            this.StringChart.PrimaryXAxis.TickLabelsDrawingMode = Syncfusion.Windows.Forms.Chart.ChartAxisTickLabelDrawingMode.BothUserAndAutomaticMode;
            this.StringChart.PrimaryXAxis.Title = "X-Achse";
            this.StringChart.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.StringChart.PrimaryXAxis.ValueType = Syncfusion.Windows.Forms.Chart.ChartValueType.Custom;
            this.StringChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.StringChart.PrimaryYAxis.Margin = true;
            this.StringChart.PrimaryYAxis.Title = "Y-Achse";
            this.StringChart.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Series1";
            chartSeries2.Points.Add(0D, ((double)(0D)));
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.DisplayText = true;
            chartSeries2.Style.DrawTextShape = false;
            chartLineInfo2.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo2.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo2.DashPattern = null;
            chartLineInfo2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo2.Width = 1F;
            chartCustomShapeInfo2.Border = chartLineInfo2;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Series1";
            this.StringChart.Series.Add(chartSeries2);
            this.StringChart.ShowToolbar = true;
            this.StringChart.Size = new System.Drawing.Size(846, 471);
            this.StringChart.TabIndex = 1;
            // 
            // 
            // 
            this.StringChart.Title.Name = "Default";
            this.StringChart.ToolBar.Border.ForeColor = System.Drawing.Color.White;
            this.StringChart.ToolBar.Border.Width = 0F;
            this.StringChart.ToolBar.Visible = true;
            this.StringChart.VisualTheme = "";
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
            this.tabPageAdv1.Controls.Add(this.StringChart);
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
            this.tabPageAdv2.Controls.Add(this.DecimalChart);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(3, 2);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(843, 494);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "DECIMAL";
            this.tabPageAdv2.ThemesEnabled = true;
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 500);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl DecimalChart;
        private Syncfusion.Windows.Forms.Chart.ChartControl StringChart;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
    }
}