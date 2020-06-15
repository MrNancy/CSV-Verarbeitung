using Syncfusion.Windows.Forms;
using System.Windows.Forms;

namespace CSV_Verarbeitung.Operations
{
    class ChartProcessor
    {
        public static bool CreateChart(DataGridView dataGridView, string type)
        {
            CsvProcessor.csvData = CsvProcessor.PopulateCsvString(dataGridView);
            bool isCreated;
            if (dataGridView.SelectedColumns.Count > 1)
            {
                if (type == "tortendiagramm")
                {

                    isCreated = true;
                }
                else if (type == "balkendiagramm")
                {

                    isCreated = true;
                }
                else
                {
                    isCreated = false;
                }
            }
            else
            {
                Interface.DesignMessageBox(MessageBoxButtons.OK);
                MessageBoxAdv.Show("Wählen Sie mehr als eine Spalte", "Spalte wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isCreated = false;
            }
            return isCreated;
        }
    }
}
