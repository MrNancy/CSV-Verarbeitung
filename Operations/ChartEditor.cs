using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    class ChartEditor
    {
        public static void CreateChart(DataGridView dataGridView)
        {
            CsvProcessor.csvData = CsvProcessor.PopulateCsvString(dataGridView);
        }
    }
}
