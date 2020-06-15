namespace CSV_Verarbeitung
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.loadingLabel = new System.Windows.Forms.PictureBox();
            this.loadingGif = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.workspaceDataGridView = new System.Windows.Forms.DataGridView();
            this.EditDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spalteHinzufugenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.hinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spalteEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zeileHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeileEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.grafischeDarstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBand = new System.Windows.Forms.Panel();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.chartButton = new System.Windows.Forms.Button();
            this.reUploadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.AddColumnHeaderText = new System.Windows.Forms.ToolStripTextBox();
            this.ChartOptionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spalteWählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagrammErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balkendiagrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tortendiagrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.diagrammModusBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceDataGridView)).BeginInit();
            this.EditDataGridViewContextMenuStrip.SuspendLayout();
            this.menuBand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uploadButton.SuspendLayout();
            this.ChartOptionsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.container);
            this.panel1.Controls.Add(this.uploadButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 500);
            this.panel1.TabIndex = 0;
            // 
            // container
            // 
            this.container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.container.Controls.Add(this.loadingLabel);
            this.container.Controls.Add(this.loadingGif);
            this.container.Controls.Add(this.panel4);
            this.container.Controls.Add(this.menuBand);
            this.container.Cursor = System.Windows.Forms.Cursors.Hand;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Enabled = false;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(850, 500);
            this.container.TabIndex = 2;
            this.container.Visible = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingLabel.BackColor = System.Drawing.Color.White;
            this.loadingLabel.Image = global::CSV_Verarbeitung.Properties.Resources.lade;
            this.loadingLabel.Location = new System.Drawing.Point(297, 289);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(211, 84);
            this.loadingLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loadingLabel.TabIndex = 5;
            this.loadingLabel.TabStop = false;
            // 
            // loadingGif
            // 
            this.loadingGif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingGif.BackColor = System.Drawing.Color.White;
            this.loadingGif.Image = global::CSV_Verarbeitung.Properties.Resources.loader;
            this.loadingGif.Location = new System.Drawing.Point(331, 143);
            this.loadingGif.Name = "loadingGif";
            this.loadingGif.Size = new System.Drawing.Size(150, 150);
            this.loadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingGif.TabIndex = 1;
            this.loadingGif.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.workspaceDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 463);
            this.panel4.TabIndex = 4;
            // 
            // workspaceDataGridView
            // 
            this.workspaceDataGridView.AllowDrop = true;
            this.workspaceDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.workspaceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.workspaceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.workspaceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.workspaceDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.workspaceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workspaceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.workspaceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workspaceDataGridView.ContextMenuStrip = this.EditDataGridViewContextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workspaceDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.workspaceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.workspaceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.workspaceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.workspaceDataGridView.Name = "workspaceDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workspaceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.workspaceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.workspaceDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.workspaceDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.workspaceDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.workspaceDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.workspaceDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.workspaceDataGridView.RowTemplate.Height = 28;
            this.workspaceDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workspaceDataGridView.Size = new System.Drawing.Size(850, 463);
            this.workspaceDataGridView.TabIndex = 0;
            this.workspaceDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.WorkspaceDataGridView_RowPostPaint);
            this.workspaceDataGridView.SelectionChanged += new System.EventHandler(this.WorkspaceDataGridView_SelectionChanged);
            // 
            // EditDataGridViewContextMenuStrip
            // 
            this.EditDataGridViewContextMenuStrip.BackColor = System.Drawing.Color.White;
            this.EditDataGridViewContextMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditDataGridViewContextMenuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spalteHinzufugenToolStripMenuItem,
            this.spalteEntfernenToolStripMenuItem,
            this.toolStripSeparator1,
            this.zeileHinzufügenToolStripMenuItem,
            this.zeileEntfernenToolStripMenuItem,
            this.toolStripSeparator3,
            this.grafischeDarstellungToolStripMenuItem,
            this.dateiÖffnenToolStripMenuItem,
            this.dateiSpeichernToolStripMenuItem});
            this.EditDataGridViewContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.EditDataGridViewContextMenuStrip.Name = "contextMenuStrip1";
            this.EditDataGridViewContextMenuStrip.Size = new System.Drawing.Size(204, 192);
            // 
            // spalteHinzufugenToolStripMenuItem
            // 
            this.spalteHinzufugenToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.spalteHinzufugenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.hinzufügenToolStripMenuItem1});
            this.spalteHinzufugenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Plus_48px;
            this.spalteHinzufugenToolStripMenuItem.Name = "spalteHinzufugenToolStripMenuItem";
            this.spalteHinzufugenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.spalteHinzufugenToolStripMenuItem.Text = "Spalte hinzufügen";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.White;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 22);
            // 
            // hinzufügenToolStripMenuItem1
            // 
            this.hinzufügenToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.hinzufügenToolStripMenuItem1.Image = global::CSV_Verarbeitung.Properties.Resources.Checked_48px;
            this.hinzufügenToolStripMenuItem1.Name = "hinzufügenToolStripMenuItem1";
            this.hinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.hinzufügenToolStripMenuItem1.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem1.Click += new System.EventHandler(this.HinzufügenToolStripMenuItem1_Click);
            // 
            // spalteEntfernenToolStripMenuItem
            // 
            this.spalteEntfernenToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.spalteEntfernenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Minus_48px;
            this.spalteEntfernenToolStripMenuItem.Name = "spalteEntfernenToolStripMenuItem";
            this.spalteEntfernenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.spalteEntfernenToolStripMenuItem.Text = "Spalte entfernen";
            this.spalteEntfernenToolStripMenuItem.Visible = false;
            this.spalteEntfernenToolStripMenuItem.Click += new System.EventHandler(this.SpalteEntfernenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // zeileHinzufügenToolStripMenuItem
            // 
            this.zeileHinzufügenToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.zeileHinzufügenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Plus_48px;
            this.zeileHinzufügenToolStripMenuItem.Name = "zeileHinzufügenToolStripMenuItem";
            this.zeileHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.zeileHinzufügenToolStripMenuItem.Text = "Zeile hinzufügen";
            this.zeileHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.ZeileHinzufügenToolStripMenuItem_Click);
            // 
            // zeileEntfernenToolStripMenuItem
            // 
            this.zeileEntfernenToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.zeileEntfernenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Minus_48px;
            this.zeileEntfernenToolStripMenuItem.Name = "zeileEntfernenToolStripMenuItem";
            this.zeileEntfernenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.zeileEntfernenToolStripMenuItem.Text = "Zeile entfernen";
            this.zeileEntfernenToolStripMenuItem.Click += new System.EventHandler(this.ZeileEntfernenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // grafischeDarstellungToolStripMenuItem
            // 
            this.grafischeDarstellungToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.grafischeDarstellungToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Combo_Chart_48px;
            this.grafischeDarstellungToolStripMenuItem.Name = "grafischeDarstellungToolStripMenuItem";
            this.grafischeDarstellungToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.grafischeDarstellungToolStripMenuItem.Text = "Grafische Darstellung";
            this.grafischeDarstellungToolStripMenuItem.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // dateiÖffnenToolStripMenuItem
            // 
            this.dateiÖffnenToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.dateiÖffnenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Opened_Folder_48px;
            this.dateiÖffnenToolStripMenuItem.Name = "dateiÖffnenToolStripMenuItem";
            this.dateiÖffnenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.dateiÖffnenToolStripMenuItem.Text = "Datei Öffnen";
            this.dateiÖffnenToolStripMenuItem.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // dateiSpeichernToolStripMenuItem
            // 
            this.dateiSpeichernToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.dateiSpeichernToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Save_48px;
            this.dateiSpeichernToolStripMenuItem.Name = "dateiSpeichernToolStripMenuItem";
            this.dateiSpeichernToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.dateiSpeichernToolStripMenuItem.Text = "Datei Speichern";
            this.dateiSpeichernToolStripMenuItem.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // menuBand
            // 
            this.menuBand.BackColor = System.Drawing.Color.Gainsboro;
            this.menuBand.Controls.Add(this.pathLabel);
            this.menuBand.Controls.Add(this.pictureBox1);
            this.menuBand.Controls.Add(this.infoButton);
            this.menuBand.Controls.Add(this.chartButton);
            this.menuBand.Controls.Add(this.reUploadButton);
            this.menuBand.Controls.Add(this.saveButton);
            this.menuBand.Controls.Add(this.addButton);
            this.menuBand.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBand.Location = new System.Drawing.Point(0, 0);
            this.menuBand.Name = "menuBand";
            this.menuBand.Padding = new System.Windows.Forms.Padding(5);
            this.menuBand.Size = new System.Drawing.Size(850, 37);
            this.menuBand.TabIndex = 3;
            // 
            // pathLabel
            // 
            this.pathLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.pathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathLabel.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.pathLabel.ForeColor = System.Drawing.Color.Black;
            this.pathLabel.Location = new System.Drawing.Point(133, 5);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(690, 27);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "test";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CSV_Verarbeitung.Properties.Resources.HDD_48px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(823, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 27);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Gainsboro;
            this.infoButton.BackgroundImage = global::CSV_Verarbeitung.Properties.Resources.Help_48px;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Location = new System.Drawing.Point(101, 5);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(32, 27);
            this.infoButton.TabIndex = 10;
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // chartButton
            // 
            this.chartButton.BackColor = System.Drawing.Color.Gainsboro;
            this.chartButton.BackgroundImage = global::CSV_Verarbeitung.Properties.Resources.Combo_Chart_48px;
            this.chartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.chartButton.FlatAppearance.BorderSize = 0;
            this.chartButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.chartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.chartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.chartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartButton.ForeColor = System.Drawing.Color.White;
            this.chartButton.Location = new System.Drawing.Point(77, 5);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(24, 27);
            this.chartButton.TabIndex = 8;
            this.chartButton.UseVisualStyleBackColor = false;
            this.chartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // reUploadButton
            // 
            this.reUploadButton.BackColor = System.Drawing.Color.Gainsboro;
            this.reUploadButton.BackgroundImage = global::CSV_Verarbeitung.Properties.Resources.Opened_Folder_48px;
            this.reUploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reUploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reUploadButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.reUploadButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.reUploadButton.FlatAppearance.BorderSize = 0;
            this.reUploadButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.reUploadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.reUploadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.reUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reUploadButton.ForeColor = System.Drawing.Color.White;
            this.reUploadButton.Location = new System.Drawing.Point(53, 5);
            this.reUploadButton.Name = "reUploadButton";
            this.reUploadButton.Size = new System.Drawing.Size(24, 27);
            this.reUploadButton.TabIndex = 7;
            this.reUploadButton.UseVisualStyleBackColor = false;
            this.reUploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.BackgroundImage = global::CSV_Verarbeitung.Properties.Resources.Save_48px;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(29, 5);
            this.saveButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(24, 27);
            this.saveButton.TabIndex = 6;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addButton.BackgroundImage = global::CSV_Verarbeitung.Properties.Resources.Plus_48px;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(5, 5);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(24, 27);
            this.addButton.TabIndex = 11;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            // 
            // uploadButton
            // 
            this.uploadButton.BackgroundImage = global::CSV_Verarbeitung.Properties.Resources.Opened_Folder_48px;
            this.uploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uploadButton.Controls.Add(this.label1);
            this.uploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadButton.ForeColor = System.Drawing.Color.Black;
            this.uploadButton.Location = new System.Drawing.Point(0, 0);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(850, 500);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(301, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = ".csv Datei wählen";
            this.label1.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.CheckPath_Tick);
            // 
            // AddColumnHeaderText
            // 
            this.AddColumnHeaderText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddColumnHeaderText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddColumnHeaderText.Name = "AddColumnHeaderText";
            this.AddColumnHeaderText.Size = new System.Drawing.Size(100, 22);
            // 
            // ChartOptionsContextMenuStrip
            // 
            this.ChartOptionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spalteWählenToolStripMenuItem,
            this.diagrammErstellenToolStripMenuItem,
            this.toolStripSeparator4,
            this.diagrammModusBeendenToolStripMenuItem});
            this.ChartOptionsContextMenuStrip.Name = "ChartOptionsContextMenuStrip";
            this.ChartOptionsContextMenuStrip.Size = new System.Drawing.Size(220, 76);
            // 
            // spalteWählenToolStripMenuItem
            // 
            this.spalteWählenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Select_Row_48px;
            this.spalteWählenToolStripMenuItem.Name = "spalteWählenToolStripMenuItem";
            this.spalteWählenToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.spalteWählenToolStripMenuItem.Text = "Spalte wählen";
            this.spalteWählenToolStripMenuItem.Visible = false;
            // 
            // diagrammErstellenToolStripMenuItem
            // 
            this.diagrammErstellenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balkendiagrammToolStripMenuItem,
            this.tortendiagrammToolStripMenuItem});
            this.diagrammErstellenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Checked_48px;
            this.diagrammErstellenToolStripMenuItem.Name = "diagrammErstellenToolStripMenuItem";
            this.diagrammErstellenToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.diagrammErstellenToolStripMenuItem.Text = "Diagramm erstellen";
            // 
            // balkendiagrammToolStripMenuItem
            // 
            this.balkendiagrammToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Bar_Chart_48px;
            this.balkendiagrammToolStripMenuItem.Name = "balkendiagrammToolStripMenuItem";
            this.balkendiagrammToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.balkendiagrammToolStripMenuItem.Text = "Balkendiagramm";
            this.balkendiagrammToolStripMenuItem.Click += new System.EventHandler(this.KreisdiagrammToolStripMenuItem_Click);
            // 
            // tortendiagrammToolStripMenuItem
            // 
            this.tortendiagrammToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Chart_48px;
            this.tortendiagrammToolStripMenuItem.Name = "tortendiagrammToolStripMenuItem";
            this.tortendiagrammToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tortendiagrammToolStripMenuItem.Text = "Tortendiagramm";
            this.tortendiagrammToolStripMenuItem.Click += new System.EventHandler(this.TortendiagrammToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(216, 6);
            // 
            // diagrammModusBeendenToolStripMenuItem
            // 
            this.diagrammModusBeendenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Cancel_48px;
            this.diagrammModusBeendenToolStripMenuItem.Name = "diagrammModusBeendenToolStripMenuItem";
            this.diagrammModusBeendenToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.diagrammModusBeendenToolStripMenuItem.Text = "Diagramm Modus beenden";
            this.diagrammModusBeendenToolStripMenuItem.Click += new System.EventHandler(this.DiagrammModusBeendenToolStripMenuItem_Click);
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Image = global::CSV_Verarbeitung.Properties.Resources.Checked_48px;
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(866, 539);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Verarbeitung";
            this.panel1.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workspaceDataGridView)).EndInit();
            this.EditDataGridViewContextMenuStrip.ResumeLayout(false);
            this.menuBand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uploadButton.ResumeLayout(false);
            this.uploadButton.PerformLayout();
            this.ChartOptionsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel uploadButton;
        private System.Windows.Forms.Panel container;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox loadingGif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Panel menuBand;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button reUploadButton;
        private System.Windows.Forms.PictureBox loadingLabel;
        private System.Windows.Forms.DataGridView workspaceDataGridView;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ContextMenuStrip EditDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem spalteHinzufugenToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox AddColumnHeaderText;
        private System.Windows.Forms.ToolStripMenuItem spalteEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zeileHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeileEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafischeDarstellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip ChartOptionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem diagrammErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balkendiagrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tortendiagrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem diagrammModusBeendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spalteWählenToolStripMenuItem;
    }
}

