using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    class ChartProcessor
    {
        private static List<string> CheckColumn(DataGridView dataGridView)
        {
            List<string> tempList = new List<string>();
            List<string> returnList = new List<string>();
            foreach (DataGridViewCell dataGridViewCell in dataGridView.SelectedCells)
            {
                foreach(DataGridViewColumn dataGridViewColumn in dataGridView.SelectedColumns)
                {
                    if (dataGridViewCell.OwningColumn == dataGridViewColumn && !tempList.Contains(dataGridViewColumn.HeaderText))
                    {
                        tempList.Add(dataGridViewColumn.HeaderText);
                    }
                }
            }
            foreach (string listItem in tempList)
            {
                if (string.IsNullOrWhiteSpace(listItem) == false)
                {
                    Interface.DesignMessageBox(MessageBoxButtons.YesNoCancel, "IntString");
                    DialogResult dialogResult = MessageBoxAdv.Show("►" + listItem + "◄ " + Environment.NewLine + "Enthält die Spalte Zahlen oder Texte?", "Art wählen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        returnList.Add(listItem + "●zahlen");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        returnList.Add(listItem + "●texte");
                    }
                }
            }
            return returnList;
        }
        public static void CreateChart(DataGridView dataGridView, string diagramType)
        {
            if (dataGridView.SelectedColumns.Count > 1)
            {
                if (diagramType == "tortendiagramm")
                {
                    // Tortendiagramm
                    List<string> columns = CheckColumn(dataGridView);
                    foreach (string column in columns)
                    {
                        string columnText = column.Split('●')[0];
                        string columnType = column.Split('●')[1];
                        MessageBox.Show(columnText, columnType);
                    }
                }
                else
                {
                    // Balkendiagramm
                    List<string> columns = CheckColumn(dataGridView);
                    foreach(string column in columns)
                    {
                        string columnText = column.Split('●')[0];
                        string columnType = column.Split('●')[1];
                        MessageBox.Show(columnText, columnType);
                    }
                }
            }
            else
            {
                Interface.DesignMessageBox(MessageBoxButtons.OK);
                MessageBoxAdv.Show("Wählen Sie mehr als eine Spalte", "Spalte wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
