using Syncfusion.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    class DataGridViewOperations
    {
        public static void RemoveRow(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    try
                    {
                        dataGridView.Rows.Remove(row);
                    }
                    catch { }
                }
            }
            else
            {
                Interface.DesignMessageBox(MessageBoxButtons.OK);
                MessageBoxAdv.Show("Bitte markieren Sie mindestens eine Zeile", "Zeile markieren", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void RemoveColumn(DataGridView dataGridView)
        {
            if (dataGridView.SelectedColumns.Count > 0)
            {
                foreach (DataGridViewColumn column in dataGridView.SelectedColumns)
                {
                    try
                    {
                        dataGridView.Columns.Remove(column);
                    }
                    catch { }
                }
            }
            else
            {
                Interface.DesignMessageBox(MessageBoxButtons.OK);
                MessageBoxAdv.Show("Bitte markieren Sie mindestens eine Spalte", "Spalte markieren", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void PaintRowNumbers(DataGridView dataGridView, object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            using (SolidBrush b = new SolidBrush(dataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        public static void AddNewRow(DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count > 0)
            {
                string row = "";
                foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
                {
                    row += dataGridViewColumn.HeaderText + ";";
                }
                CsvProcessor.PopulateRow(dataGridView, row);
            }
        }
    }
}
