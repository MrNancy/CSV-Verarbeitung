using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart.SvgBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    class ChartProcessor
    {
        private static List<KeyValuePair<string, DataGridViewCell[]>> getSelectedColumnsValues(DataGridView dataGridView)
        {
            bool isUsed = false;
            List<KeyValuePair<string, DataGridViewCell[]>> returnList = new List<KeyValuePair<string, DataGridViewCell[]>>();
            List<string> columnList = new List<string>();

            foreach (DataGridViewCell dataGridViewCell in dataGridView.SelectedCells)
            {
                foreach(DataGridViewColumn dataGridViewColumn in dataGridView.SelectedColumns)
                {
                    string headerText = dataGridViewColumn.HeaderText.Replace("●", "");

                    string saveAsNumber = headerText + "●" + dataGridViewColumn.Index + "●zahlen";
                    string saveAsText = headerText + "●" + dataGridViewColumn.Index + "●texte";

                    if (dataGridViewCell.OwningColumn == dataGridViewColumn && !columnList.Contains(saveAsText) && !columnList.Contains(saveAsNumber))
                    {
                        DialogResult dialogResult = MessageBoxProcessor.Run("► " + dataGridViewColumn.HeaderText.Replace("●", "") + " ◄ " + Environment.NewLine + "Enthält die Spalte Zahlen oder Texte?", "Art wählen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, "IntString");
                        if (dialogResult == DialogResult.Yes)
                        {
                            isUsed = true;
                            columnList.Add(saveAsNumber);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            isUsed = true;
                            columnList.Add(saveAsText);
                        }
                    }
                    // get Values of
                    if (isUsed == true)
                    {
                        MessageBox.Show(dataGridViewCell.Value.ToString());
                    }
                }
            }
            return returnList;
        }
        public static void CreateChart(DataGridView dataGridView, string diagramType)
        {
            if (dataGridView.SelectedColumns.Count > 0)
            {
                List<KeyValuePair<string, DataGridViewCell[]>> getColumnCellsValue = getSelectedColumnsValues(dataGridView);

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
                MessageBoxProcessor.Run("Wählen Sie mindestens eine Spalte", "Spalte wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
