///
/// Interface Funktionen
///

using Syncfusion.Windows.Forms;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    class Interface
    {
        private static Panel[] reEnablePanelsChartMode;
        public static bool isChartModeEnabled = false;

        public static void ChartMode(
            bool enabled,
            DataGridView dataGridView,
            ContextMenuStrip newContextMenuStrip,
            ContextMenuStrip regularContextMenuStrip,
            ToolStripMenuItem toolStripMenuItem,
            Panel[] panels)
        {
            // Alle angegebenen Controls deaktivieren und unsichtbar machen
            if (enabled == true)
            {
                DialogResult dialogResult = MessageBoxProcessor.Run("Sie haben den Diagramm Modus erfolgriech aktiviert!" +
                    Environment.NewLine +
                    "Wählen Sie nun eine oder mehrere Spalten zur Darstellung in einem Diagramm."+
                    Environment.NewLine+
                    Environment.NewLine+
                    "Zur bestätigung Ihrer Erstellung, nutzen Sie bitte das Kontextmenü",
                    "Diagramm Modus aktiviert",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                if(dialogResult == DialogResult.OK)
                {
                    isChartModeEnabled = true;
                    reEnablePanelsChartMode = panels;
                    foreach (Panel panel in panels)
                    {
                        panel.Visible = false;
                        panel.Visible = false;
                    }
                    foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
                    {
                        dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                        dataGridView.ReadOnly = true;
                        if (dataGridViewColumn.HeaderCell.Value != null)
                        {
                            ToolStripMenuItem newToolStripMenuItem = new ToolStripMenuItem
                            {
                                CheckOnClick = true,
                                Text = dataGridViewColumn.HeaderCell.Value.ToString()
                            };
                            toolStripMenuItem.DropDownItems.Add(newToolStripMenuItem);
                        }
                    }
                    dataGridView.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

                    dataGridView.ContextMenuStrip = newContextMenuStrip;
                }
            }
            else
            {
                isChartModeEnabled = false;
                foreach (Panel panel in reEnablePanelsChartMode)
                {
                    panel.Visible = true;
                    panel.Visible = true;
                }
                dataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
                {
                    dataGridViewColumn.SortMode = DataGridViewColumnSortMode.Automatic;
                    dataGridView.ReadOnly = false;
                }
                reEnablePanelsChartMode = null;

                dataGridView.ContextMenuStrip = regularContextMenuStrip;
            }
        }

        public static void Shutdown(DataGridView dataGridView)
        {
            if (dataGridView is null)
            {
                throw new System.ArgumentNullException(nameof(dataGridView));
            }

            Application.Exit();
        }
    }
}
