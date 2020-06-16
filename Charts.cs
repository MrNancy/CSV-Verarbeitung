using CSV_Verarbeitung.Operations;
using System.Windows.Forms;

namespace CSV_Verarbeitung
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
            ChartProcessor.PopulateChart(cartesianChart1, cartesianChart2);
        }

        private void StringChart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
    }
}
