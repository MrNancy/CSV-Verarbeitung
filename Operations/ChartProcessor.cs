using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

namespace CSV_Verarbeitung.Operations
{
    internal class ChartProcessor
    {
        public static List<KeyValuePair<string, int>> stringListValuePairs = new List<KeyValuePair<string, int>>();

        public static void ShowChart(DataGridView dataGridView)
        {
            if (dataGridView.SelectedColumns.Count > 0)
            {
                GetSelectedColumnsProcessedValues(dataGridView, stringListValuePairs);
                if (stringListValuePairs.Any())
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

        private static void GetSelectedColumnsProcessedValues(DataGridView dataGridView, List<KeyValuePair<string, int>> stringListValuePairs)
        {
            List<string> columnList = new List<string>();
            List<string> cellList = new List<string>();

            foreach (DataGridViewCell dataGridViewCell in dataGridView.SelectedCells)
            {
                bool isInColumn = false;
                foreach (DataGridViewColumn dataGridViewColumn in dataGridView.SelectedColumns)
                {
                    string headerText = dataGridViewColumn.HeaderText.Replace("●", "");

                    string saveString = headerText + "●" + dataGridViewColumn.Index;

                    if (dataGridViewCell.OwningColumn == dataGridViewColumn && !columnList.Contains(saveString))
                    {
                        columnList.Add(saveString);
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

                string columnName = column.Split('●')[0];

                foreach (var cellValueOccurrences in cellList.GroupBy(i => i))
                {
                    KeyValuePair<string, int> keyValuePair = new KeyValuePair<string, int>(cellValueOccurrences.Key, cellValueOccurrences.Count());
                    stringListValuePairs.Add(keyValuePair);
                }
            }
        }

        public static void ClearChart(LiveCharts.WinForms.CartesianChart barChart, LiveCharts.WinForms.PieChart pieChart)
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

        public static void BindChartData(LiveCharts.WinForms.CartesianChart stringBarChart, LiveCharts.WinForms.PieChart stringPieChart)
        {
            ClearChart(stringBarChart, stringPieChart);

            if (stringListValuePairs.Any())
            {
                Random randomColorGenerator = new Random();
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
                if (i > 100)
                {
                    MessageBoxProcessor.Show("Bei mehr als 100 Einträgen müssen Sie heranzoomen um die einzelnen Einträge richtig anzuzigen." + Environment.NewLine + "Nutzen Sie hierzu das Scrollrad", "Viele Einträge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                #region stringBarChart

                var tooltip = new DefaultTooltip
                {
                    SelectionMode = TooltipSelectionMode.SharedYValues
                };

                SolidColorBrush barBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)randomColorGenerator.Next(255), (byte)randomColorGenerator.Next(255), (byte)randomColorGenerator.Next(255)));
                stringBarChart.Series.Add(new RowSeries
                {
                    Title = "Anzahl",
                    Values = occurrences,
                    StrokeThickness = 0,
                    Width = 20,
                    Fill = barBrush
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

                #endregion stringBarChart

                #region stringPieChart

                string labelPoint(ChartPoint chartPoint) => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                SeriesCollection seriesCollection = new SeriesCollection();

                foreach (KeyValuePair<string, int> keyValuePair in stringListValuePairs)
                {
                    if (!string.IsNullOrWhiteSpace(keyValuePair.Key))
                    {
                        SolidColorBrush pieBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)randomColorGenerator.Next(255), (byte)randomColorGenerator.Next(255), (byte)randomColorGenerator.Next(255)));
                        PieSeries pieSeries = new PieSeries
                        {
                            Title = keyValuePair.Key.ToString(),
                            Values = new ChartValues<double> { keyValuePair.Value },
                            DataLabels = true,
                            LabelPoint = labelPoint,
                            StrokeThickness = 0,
                            Fill = pieBrush
                        };
                        seriesCollection.Add(pieSeries);
                    }
                }
                stringPieChart.LegendLocation = LegendLocation.Bottom;
                stringPieChart.Series = seriesCollection;
                stringPieChart.Zoom = ZoomingOptions.Xy;

                #endregion stringPieChart
            }
        }
    }
}