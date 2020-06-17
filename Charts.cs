using CSV_Verarbeitung.Operations;
using System.Windows.Forms;

namespace CSV_Verarbeitung
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void Charts_Load(object sender, System.EventArgs e)
        {
            ChartProcessor.ClearChart(stringBarChart, stringPieChart);
            ChartProcessor.BindChartData(stringBarChart, stringPieChart);
        }

        private void Charts_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChartProcessor.stringListValuePairs.Clear();
        }
    }
}