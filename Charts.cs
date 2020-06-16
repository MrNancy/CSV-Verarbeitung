using CSV_Verarbeitung.Operations;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSV_Verarbeitung
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
            ChartProcessor.PopulateChart(tabPageAdv1, tabPageAdv2, StringChart, DecimalChart, ChartProcessor.stringListValuePairs, ChartProcessor.decimalListValuePairs);
        }

        private void StringChart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
    }
}
