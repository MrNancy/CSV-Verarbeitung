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
            bool isUsedColumn = false;
            List<KeyValuePair<string, DataGridViewCell[]>> returnList = new List<KeyValuePair<string, DataGridViewCell[]>>();
            List<string> columnList = new List<string>();

            foreach (DataGridViewCell dataGridViewCell in dataGridView.SelectedCells)
            {
                foreach(DataGridViewColumn dataGridViewColumn in dataGridView.SelectedColumns)
                {
                    string headerText = dataGridViewColumn.HeaderText.Replace("●", "");

                    string saveNumeric = headerText + "●" + dataGridViewColumn.Index + "●zahlen";
                    string saveString = headerText + "●" + dataGridViewColumn.Index + "●texte";
                    bool isNumeric = false;

                    if (dataGridViewCell.OwningColumn == dataGridViewColumn && !columnList.Contains(saveString) && !columnList.Contains(saveNumeric))
                    {
                        DialogResult dialogResult = MessageBoxProcessor.Show("► " + dataGridViewColumn.HeaderText.Replace("●", "") + " ◄ " + Environment.NewLine + "Enthält die Spalte Zahlen oder Texte?", "Art wählen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, "IntString");
                        if (dialogResult == DialogResult.Yes)
                        {
                            isUsedColumn = true;
                            isNumeric = true;
                            columnList.Add(saveNumeric);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            isUsedColumn = true;
                            isNumeric = false;
                            columnList.Add(saveString);
                        }
                    }
                    if (isUsedColumn == true && isNumeric == true)
                    {
                        /// check if all cell values are numeric


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
                MessageBoxProcessor.Show("Wählen Sie mindestens eine Spalte", "Spalte wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
