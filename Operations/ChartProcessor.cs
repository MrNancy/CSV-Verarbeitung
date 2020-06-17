using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveCharts.Wpf;

namespace CSV_Verarbeitung.Operations
{
    class ChartProcessor
    {
        public static List<KeyValuePair<string, int>> stringListValuePairs = new List<KeyValuePair<string, int>>();
        public static List<KeyValuePair<string, List<decimal>>> decimalListValuePairs = new List<KeyValuePair<string, List<decimal>>>();
        public static string diagramType;
        public static void ShowChart(DataGridView dataGridView, string type)
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
                    MessageBoxProcessor.Show("Es ist ein Fehler aufgetreten!" + Environment.NewLine + "Bitte versuchen Sie es erneut.", "Erstellung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxProcessor.Show("Wählen Sie mindestens eine Spalte", "Spalte wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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

                        DialogResult dialogResult = MessageBoxProcessor.Show(messageBoxMessage.ToString(), "Art wählen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, "IntString");
                        if (dialogResult == DialogResult.Yes)
                        {
                            columnList.Add(saveNumeric);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            columnList.Add(saveString);
                        }
                    }
                    else if (dataGridViewCell.OwningColumn == dataGridViewColumn)
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
                    else
                    {
                        cellList.Add("");
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
                    foreach (string cell in cellList)
                    {
                        if (!string.IsNullOrWhiteSpace(cell))
                        {
                            try
                            {
                                decimalValueList.Add(decimal.Parse(cell.Replace(".", ",")));
                            }
                            catch
                            {
                                MessageBoxProcessor.Show(columnName + " (" + cell + ") enthält nicht nur Daten vom Typ Zahlen!", "Erstellung abgebrochen", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                hasStringAsInt = true;
                                break;
                            }
                        }
                    }
                    KeyValuePair<string, List<decimal>> keyValuePair = new KeyValuePair<string, List<decimal>>(column, decimalValueList);
                    decimalListValuePairs.Add(keyValuePair);
                }
                else if (columnType == "texte")
                {
                    foreach (var cellValueOccurrences in cellList.GroupBy(i => i))
                    {
                        KeyValuePair<string, int> keyValuePair = new KeyValuePair<string, int>(cellValueOccurrences.Key, cellValueOccurrences.Count());
                        stringListValuePairs.Add(keyValuePair);
                    }
                }
            }
        }
        private static void ClearChart(LiveCharts.WinForms.CartesianChart barChart, LiveCharts.WinForms.PieChart pieChart)
        {
            pieChart.Series.Clear();
            pieChart.AxisY.Clear();
            pieChart.AxisX.Clear();
            pieChart.Refresh();

            barChart.Series.Clear();
            barChart.AxisY.Clear();
            barChart.AxisX.Clear();
            barChart.Refresh();
        }
        public static void BindChartData(LiveCharts.WinForms.CartesianChart stringBarChart, LiveCharts.WinForms.CartesianChart decimalBarChart, LiveCharts.WinForms.PieChart stringPieChart, LiveCharts.WinForms.PieChart decimalPieChart)
        {
            ClearChart(stringBarChart, stringPieChart);
            ClearChart(decimalBarChart, decimalPieChart);

            if (diagramType == "balkendiagramm")
            {
                stringBarChart.Visible = true;
                decimalBarChart.Visible = true;

                stringPieChart.Visible = false;
                decimalPieChart.Visible = false;
            }
            else
            {
                stringPieChart.Visible = true;
                decimalPieChart.Visible = true;

                stringBarChart.Visible = false;
                decimalBarChart.Visible = false;
            }

            if (stringListValuePairs.Any())
            {
                ChartValues<int> occurrences = new ChartValues<int>();
                List<string> yAxisValues = new List<string>();
                int i = 0;
                foreach (KeyValuePair<string, int> keyValuePair in stringListValuePairs)
                {
                    if (!string.IsNullOrWhiteSpace(keyValuePair.Key))
                    {
                        occurrences.Add(keyValuePair.Value);
                        yAxisValues.Add(keyValuePair.Key);
                    }
                    i++;
                }
                if (i > 100 && diagramType == "balkendiagramm")
                {
                    MessageBoxProcessor.Show("Bei mehr als 100 Einträgen müssen Sie heranzoomen um die einzelnen Einträge richtig anzuzigen." + Environment.NewLine + "Nutzen Sie hierzu das Scrollrad", "Viele Einträge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                #region stringBarChart
                if (diagramType == "balkendiagramm")
                {
                    var tooltip = new DefaultTooltip
                    {
                        SelectionMode = TooltipSelectionMode.SharedYValues
                    };

                    stringBarChart.Series.Add(new RowSeries
                    {
                        Title = "Anzahl",
                        Values = occurrences,
                        StrokeThickness = 10,
                        Width = 20
                    });

                    stringBarChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Labels = yAxisValues
                    });

                    stringBarChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        LabelFormatter = value => value.ToString()
                    });

                    stringBarChart.DataTooltip = tooltip;
                    stringBarChart.Zoom = ZoomingOptions.Xy;
                    stringBarChart.ScrollMode = ScrollMode.XY;
                }
                #endregion

                #region stringPieChart
                if (diagramType == "tortendiagramm")
                {
                    Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                    SeriesCollection seriesCollection = new SeriesCollection();

                    foreach (KeyValuePair<string, int> keyValuePair in stringListValuePairs)
                    {
                        if (!string.IsNullOrWhiteSpace(keyValuePair.Key))
                        {
                            PieSeries pieSeries = new PieSeries
                            {
                                Title = keyValuePair.Key.ToString(),
                                Values = new ChartValues<double> { keyValuePair.Value },
                                DataLabels = true,
                                LabelPoint = labelPoint
                            };
                            seriesCollection.Add(pieSeries);
                        }
                    }
                    stringPieChart.LegendLocation = LegendLocation.Bottom;
                    stringPieChart.Series = seriesCollection;
                    stringPieChart.Zoom = ZoomingOptions.Xy;
                }
                #endregion
            }
            if (decimalListValuePairs.Any())
            {
                ChartValues<decimal> occurrences = new ChartValues<decimal>();
                List<string> yAxisValues = new List<string>();
                int i = 0;
                foreach (KeyValuePair<string, List<decimal>> keyValuePair in decimalListValuePairs)
                {
                    if (!string.IsNullOrWhiteSpace(keyValuePair.Key))
                    {
                        decimal total = 0;
                        foreach(decimal entry in keyValuePair.Value)
                        {
                            total += entry;
                        }
                        occurrences.Add(total);
                        yAxisValues.Add(keyValuePair.Key);
                    }
                    i++;
                }
                if (i > 100 && diagramType == "balkendiagramm")
                {
                    MessageBoxProcessor.Show("Bei mehr als 100 Einträgen müssen Sie heranzoomen um die einzelnen Einträge richtig anzuzigen." + Environment.NewLine + "Nutzen Sie hierzu das Scrollrad", "Viele Einträge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                #region stringBarChart
                if (diagramType == "balkendiagramm")
                {
                    var tooltip = new DefaultTooltip
                    {
                        SelectionMode = TooltipSelectionMode.SharedYValues
                    };

                    decimalBarChart.Series.Add(new RowSeries
                    {
                        Title = "Anzahl",
                        Values = occurrences,
                        StrokeThickness = 10,
                        Width = 20
                    });

                    decimalBarChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Labels = yAxisValues
                    });

                    decimalBarChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        LabelFormatter = value => value.ToString()
                    });

                    decimalBarChart.DataTooltip = tooltip;
                    decimalBarChart.Zoom = ZoomingOptions.Xy;
                    decimalBarChart.ScrollMode = ScrollMode.XY;
                }
                #endregion

                #region stringPieChart
                if (diagramType == "tortendiagramm")
                {
                    Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                    SeriesCollection seriesCollection = new SeriesCollection();

                    foreach (KeyValuePair<string, int> keyValuePair in stringListValuePairs)
                    {
                        if (!string.IsNullOrWhiteSpace(keyValuePair.Key))
                        {
                            PieSeries pieSeries = new PieSeries
                            {
                                Title = keyValuePair.Key.ToString(),
                                Values = new ChartValues<double> { keyValuePair.Value },
                                DataLabels = true,
                                LabelPoint = labelPoint
                            };
                            seriesCollection.Add(pieSeries);
                        }
                    }
                    decimalPieChart.LegendLocation = LegendLocation.Bottom;
                    decimalPieChart.Series = seriesCollection;
                    decimalPieChart.Zoom = ZoomingOptions.Xy;
                }
                #endregion
            }
        }
    }
}
