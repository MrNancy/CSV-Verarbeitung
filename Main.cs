using CSV_Verarbeitung.Operations;
using CSV_Verarbeitung.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CSV_Verarbeitung
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            workspaceDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            workspaceDataGridView.DefaultCellStyle.BackColor = Color.White;
            workspaceDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            workspaceDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;

            SetStyle(ControlStyles.ResizeRedraw, true);

            #region datagridview test

            workspaceDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            workspaceDataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            workspaceDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            workspaceDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            workspaceDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            workspaceDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            #endregion

        }

        #region ui buttons
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // SHUDOWN APPLICATION
            Interface.Shutdown(workspaceDataGridView);
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            CsvProcessor.OpenFile(pathLabel, loadingGif, loadingLabel, workspaceDataGridView);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void CheckPath_Tick(object sender, EventArgs e)
        {
            // Überprüfe ob eine .csv datei gewählt wurde
            if (CsvProcessor.filePath != "" && File.Exists(CsvProcessor.filePath))
            {
                // Datei gewählt!
                // Menüband anzeigen
                uploadButton.Visible = false;
                uploadButton.Enabled = false;

                saveButton.Enabled = true;
                saveButton.Visible = true;

                // datagridviewcontainer zeigen
                container.Enabled = true;
                container.Visible = true;
            }
            else
            {
                // Zeige nur den Lade Bildschirm
                uploadButton.Enabled = true;
                uploadButton.Visible = true;

                uploadButton.BackgroundImage = FadeUI.SetImageOpacity(Resources.Opened_Folder_48px, FadeUI.DoFadePictureBox());
                FadeUI.DoFadeLabel();
                label1.ForeColor = Color.FromArgb(FadeUI.DoFadeLabel()[0], FadeUI.DoFadeLabel()[1], FadeUI.DoFadeLabel()[2]);
            }

            // Ladeanimation schließen, sobald die Datei geladen wurde
            if (CsvProcessor.isDone == true)
            {
                loadingGif.Visible = false;
                loadingLabel.Visible = false;
            }

            // Chart Option verstecken, wenn 2 oder weniger Zeilen existieren
            if (workspaceDataGridView.Rows.Count > 2)
            {
                chartButton.Visible = true;
            }
            else
            {
                chartButton.Visible = false;
            }

            // Wenn Spalte hinzufügen Textbox nicht leer ist, submit button zeigen oder verstecken
            if (AddColumnHeaderText.Text != "")
            {
                hinzufügenToolStripMenuItem.Visible = true;
            }
            else
            {
                hinzufügenToolStripMenuItem.Visible = false;
            }
        }

        private void WorkspaceDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewProcessor.PaintRowNumbers(workspaceDataGridView, sender, e);
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            Interface.ChartMode(
                true,
                workspaceDataGridView,
                ChartOptionsContextMenuStrip,
                EditDataGridViewContextMenuStrip,
                spalteWählenToolStripMenuItem,
                new Panel[] { menuBand });
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CsvProcessor.SaveCsv(workspaceDataGridView);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            About info = new About();
            info.Show();
        }

        private void ZeileEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewProcessor.RemoveRow(workspaceDataGridView);
        }

        private void SpalteEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewProcessor.RemoveColumn(workspaceDataGridView);
        }

        private void ZeileHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewProcessor.AddNewRow(workspaceDataGridView);
        }

        private void HinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                workspaceDataGridView.Columns.Add(toolStripTextBox1.Text, toolStripTextBox1.Text);
                hinzufügenToolStripMenuItem1.Text = "";

                MessageBoxProcessor.Show("Spalte erfolgreich hinzugefügt", "Spalte hinzugefügt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WorkspaceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void DiagrammModusBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interface.ChartMode(
                false,
                workspaceDataGridView,
                ChartOptionsContextMenuStrip,
                EditDataGridViewContextMenuStrip,
                spalteWählenToolStripMenuItem,
                new Panel[] { menuBand });
        }

        private void KreisdiagrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartProcessor.ShowChart(workspaceDataGridView, "balkendiagramm");
        }

        private void TortendiagrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartProcessor.ShowChart(workspaceDataGridView, "tortendiagramm");
        }
    }
}
