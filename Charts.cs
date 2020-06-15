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
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = CsvProcessor.csvData;
        }
    }
}
