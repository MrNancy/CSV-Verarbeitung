using CSV_Verarbeitung.Operations;
using System;
using System.Windows.Forms;

namespace CSV_Verarbeitung
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
            ChartProcessor.PopulateChart(tabPageAdv1, tabPageAdv2, ChartProcessor.stringListValuePairs, ChartProcessor.decimalListValuePairs);
        }
    }
}
