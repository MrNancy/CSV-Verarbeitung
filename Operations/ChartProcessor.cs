using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    class ChartProcessor
    {
        private static List<KeyValuePair<string, List<string>>> GetSelectedColumnsValues(DataGridView dataGridView)
        {
            List<string> columnList = new List<string>();
            List<string> cellList = new List<string>();

            foreach (DataGridViewCell dataGridViewCell in dataGridView.SelectedCells)
            {
                bool isInColumn = false;
                foreach (DataGridViewColumn dataGridViewColumn in dataGridView.SelectedColumns)
                {
                    string headerText = dataGridViewColumn.HeaderText.Replace("●", "");

                    string saveNumeric = headerText + "●" + dataGridViewColumn.Index + "●zahlen";
                    string saveString = headerText + "●" + dataGridViewColumn.Index + "●texte";

                    if (dataGridViewCell.OwningColumn == dataGridViewColumn && !columnList.Contains(saveString) && !columnList.Contains(saveNumeric))
                    {

                        StringBuilder messageBoxMessage = new StringBuilder();
                        messageBoxMessage.AppendLine("► " + dataGridViewColumn.HeaderText.Replace("●", "") + " ◄ ");
                        messageBoxMessage.AppendLine("Enthält die gewählte Spalte Zahlen oder Texte?");
                        messageBoxMessage.AppendLine("");
                        messageBoxMessage.AppendLine("Zahl: Summiert alle einträge");
                        messageBoxMessage.AppendLine("Text: Gruppiert und Zählt alle Einträge");

                        DialogResult dialogResult = MessageBoxProcessor.Show(messageBoxMessage.ToString(),"Art wählen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, "IntString");
                        if (dialogResult == DialogResult.Yes)
                        {
                            columnList.Add(saveNumeric);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            columnList.Add(saveString);
                        }
                    }
                    else if(dataGridViewCell.OwningColumn == dataGridViewColumn)
                    {
                        isInColumn = true;
                    }
                }
                if (isInColumn == true)
                {
                    if (dataGridViewCell.Value != null && !string.IsNullOrEmpty(dataGridViewCell.Value.ToString()))
                    {
                        cellList.Add(dataGridViewCell.Value.ToString());
                    }
                }
            }

            List<KeyValuePair<string, List<string>>> returnList = new List<KeyValuePair<string, List<string>>>();
            foreach (string column in columnList)
            {
                KeyValuePair<string, List<string>> keyValuePair = new KeyValuePair<string, List<string>>(column, cellList);
                returnList.Add(keyValuePair);
            }
            return returnList;
        }
        public static void CreateChart(DataGridView dataGridView, string diagramType)
        {
            if (dataGridView.SelectedColumns.Count > 0)
            {
                List<KeyValuePair<string, List<string>>> getColumnCellsValue = GetSelectedColumnsValues(dataGridView);
                foreach (KeyValuePair<string, List<string>> kvp in getColumnCellsValue)
                {
                    foreach(string dataGridViewCellValue in kvp.Value)
                    {
                        MessageBox.Show(dataGridViewCellValue, kvp.Key);
                    }
                }
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
