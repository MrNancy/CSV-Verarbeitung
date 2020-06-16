using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSV_Verarbeitung.Operations
{
    class ChartProcessor
    {
        public static List<KeyValuePair<string, int>> stringListValuePairs = new List<KeyValuePair<string, int>>();
        public static List<KeyValuePair<string, List<decimal>>> decimalListValuePairs = new List<KeyValuePair<string, List<decimal>>>();
        public static string diagramType;

        private static void GetSelectedColumnsProcessedValues(DataGridView dataGridView, List<KeyValuePair<string, int>> stringListValuePairs, List<KeyValuePair<string, List<decimal>>> decimalListValuePairs)
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

            bool hasStringAsInt = false;
            foreach (string column in columnList)
            {
                if (hasStringAsInt == true)
                {
                    break;
                }

                string columnType = column.Split('●')[2];
                string columnName = column.Split('●')[0];

                if (columnType == "zahlen")
                {
                    List<decimal> decimalValueList = new List<decimal>();
                    foreach(string cell in cellList)
                    {
                        try
                        {
                            decimalValueList.Add(decimal.Parse(cell.Replace(".", "").Replace(",",".")));
                        }
                        catch
                        {
                            MessageBoxProcessor.Show(columnName + " ("+cell+") enthält nicht nur Daten vom Typ Zahlen!", "Erstellung abgebrochen", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            hasStringAsInt = true;
                            break;
                        }
                    }
                    KeyValuePair<string, List<decimal>> keyValuePair = new KeyValuePair<string, List<decimal>>(column, decimalValueList);
                    decimalListValuePairs.Add(keyValuePair);
                }
                else if(columnType == "texte")
                {
                    foreach (var cellValueOccurrences in cellList.GroupBy(i => i))
                    {
                        KeyValuePair<string, int> keyValuePair = new KeyValuePair<string, int>(cellValueOccurrences.Key, cellValueOccurrences.Count());
                        stringListValuePairs.Add(keyValuePair);
                    }
                }
            }
        }

        public static void PopulateChart(TabPageAdv stringChartTabPage, TabPageAdv decimalChartTabPage, Chart stringChart, Chart decimalChart, List<KeyValuePair<string, int>> stringKeyValuePairs, List<KeyValuePair<string, List<decimal>>> decimalKeyValuePairs)
        {
            Random rnd = new Random();
            decimalChart.Series.Clear();
            stringChart.Series.Clear();
            if (stringKeyValuePairs.Any())
            {
                stringChartTabPage.Visible = true;
                int i = 0;
                foreach(KeyValuePair<string, int> keyValuePair in stringKeyValuePairs)
                {
                    i++;
                    string seriesname = keyValuePair.Key + i.ToString();
                    stringChart.Series.Add(seriesname);
                    stringChart.Series[seriesname].ToolTip = keyValuePair.Key;
                    stringChart.Series[seriesname].LabelToolTip = keyValuePair.Key;
                    stringChart.Series[seriesname].ChartType = SeriesChartType.Bar;
                    stringChart.Series[seriesname].LegendText = keyValuePair.Key;
                    stringChart.Series[seriesname].XValueType = ChartValueType.String;
                    stringChart.Series[seriesname].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                    stringChart.Series[seriesname].Color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                }
            }
            if (decimalKeyValuePairs.Any())
            {
                decimalChartTabPage.Visible = true;

                decimalChart.Refresh();
            }
        }
        public static void CreateChart(DataGridView dataGridView, string type)
        {
            if (dataGridView.SelectedColumns.Count > 0)
            {
                GetSelectedColumnsProcessedValues(dataGridView, stringListValuePairs, decimalListValuePairs);
                diagramType = type;
                if (stringListValuePairs.Any() || decimalListValuePairs.Any())
                {
                    Charts chart = new Charts();
                    chart.Show();
                }
                else
                {
                    MessageBoxProcessor.Show("Es ist ein Fehler aufgetreten!"+Environment.NewLine+"Bitte versuchen Sie es erneut.", "Erstellung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxProcessor.Show("Wählen Sie mindestens eine Spalte", "Spalte wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
