using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart.SvgBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    class ChartProcessor
    {
        private static List<string> getSelectedColumns(DataGridView dataGridView)
        {
            bool isUsed = false;
            List<string> returnList = new List<string>();
            foreach (DataGridViewCell dataGridViewCell in dataGridView.SelectedCells)
            {
                foreach(DataGridViewColumn dataGridViewColumn in dataGridView.SelectedColumns)
                {
                    string headerText = dataGridViewColumn.HeaderText.Replace("●", "");

                    string saveAsNumber = headerText + "●" + dataGridViewColumn.Index + "●zahlen";
                    string saveAsText = headerText + "●" + dataGridViewColumn.Index + "●texte";

                    if (dataGridViewCell.OwningColumn == dataGridViewColumn && !returnList.Contains(saveAsText) && !returnList.Contains(saveAsNumber))
                    {
                        MessageBoxProcessor.DesignMessageBox(MessageBoxButtons.YesNo, "IntString");
                        DialogResult dialogResult = MessageBoxAdv.Show("► " + dataGridViewColumn.HeaderText.Replace("●", "") + " ◄ " + Environment.NewLine + "Enthält die Spalte Zahlen oder Texte?", "Art wählen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            isUsed = true;
                            returnList.Add(saveAsNumber);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            isUsed = true;
                            returnList.Add(saveAsText);
                        }
                    }
                    if (isUsed == true)
                    {
                        MessageBox.Show(dataGridViewCell.Value.ToString());
                    }
                }
            }
            return returnList;
        }
        public static List<KeyValuePair<string, DataGridViewCell[]>> getSelectedColumnsValues(List<string> selectedColumns)
        {
            List<KeyValuePair<string, DataGridViewCell[]>> selectedColumnsValues = new List<KeyValuePair<string, DataGridViewCell[]>>();
            foreach (string column in selectedColumns)
            {
//                selectedColumnsValues.Add(column, )
            }
            return selectedColumnsValues;
        }
        public static void CreateChart(DataGridView dataGridView, string diagramType)
        {
            if (dataGridView.SelectedColumns.Count > 0)
            {
                List<string> selectedColumns = getSelectedColumns(dataGridView);
                List<KeyValuePair<string, DataGridViewCell[]>> getColumnCellsValue = getSelectedColumnsValues(selectedColumns);

                if (diagramType == "tortendiagramm")
                {
                    // Tortendiagramm
                }
                else
                {
                    // Balkendiagramm
                }
            }
            else
            {
                MessageBoxProcessor.DesignMessageBox(MessageBoxButtons.OK);
                MessageBoxAdv.Show("Wählen Sie mindestens eine Spalte", "Spalte wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
