using CSV_Verarbeitung.Operations;
using System.Windows.Forms;

namespace CSV_Verarbeitung
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
            ChartProcessor.BindChartData(stringBarChart, decimalBarChart, stringPieChart, decimalPieChart);
        }

        private void StringChart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
    }
}
