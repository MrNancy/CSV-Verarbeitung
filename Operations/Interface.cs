﻿///
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
                DesignMessageBox(MessageBoxButtons.OKCancel);
                DialogResult dialogResult = MessageBoxAdv.Show("Sie haben den Diagramm Modus erfolgriech aktiviert!" +
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


        #region MessageBoxDesigner & Localizer
        public static void DesignMessageBox(MessageBoxButtons messageBoxButtons)
        {
            if(messageBoxButtons == MessageBoxButtons.YesNo)
            {
                LocalizationProvider.Provider = new YesNoLocalizer();
            }
            else if(messageBoxButtons == MessageBoxButtons.OK)
            {
                LocalizationProvider.Provider = new OKLocalizer();
            }
            else if(messageBoxButtons == MessageBoxButtons.OKCancel)
            {
                LocalizationProvider.Provider = new OKCancelLocalizer();
            }
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
            MessageBoxAdv.ApplyAeroTheme = true;

        }
        class YesNoLocalizer : ILocalizationProvider
        {
            //https://help.syncfusion.com/windowsforms/messagebox/button-parameters
            public string GetLocalizedString(CultureInfo culture, string name, object obj)
            {

                switch (name)
                {
                    case ResourceIdentifiers.Yes:
                        return "Ja";
                    case ResourceIdentifiers.No:
                        return "Nein";
                    case ResourceIdentifiers.Cancel:
                        return "test";
                    default:
                        return string.Empty;

                }

            }

        }
        class OKCancelLocalizer : ILocalizationProvider
        {
            //https://help.syncfusion.com/windowsforms/messagebox/button-parameters
            public string GetLocalizedString(CultureInfo culture, string name, object obj)
            {

                switch (name)
                {
                    case ResourceIdentifiers.OK:
                        return "Okay";
                    case ResourceIdentifiers.Cancel:
                        return "Abbrechen";
                    default:
                        return string.Empty;

                }

            }

        }
        class OKLocalizer : ILocalizationProvider
        {
            //https://help.syncfusion.com/windowsforms/messagebox/button-parameters
            public string GetLocalizedString(CultureInfo culture, string name, object obj)
            {

                switch (name)
                {
                    case ResourceIdentifiers.OK:
                        return "Okay";
                    default:
                        return string.Empty;

                }

            }

        }
        #endregion
    }
}
