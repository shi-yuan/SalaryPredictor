using DevExpress.XtraEditors;
using System;

namespace SalaryPredictor
{
    public partial class MainForm : XtraForm
    {
        private KNNPredictor predicator;

        public MainForm(KNNPredictor predicator)
        {
            InitializeComponent();
            this.predicator = predicator;
        }

        private void btn_predicate_Click(object sender, EventArgs e)
        {
            var pred = predicator.predicate(
                Double.Parse(txtEdit_job.Text),
                Double.Parse(txtEdit_school.Text),
                Double.Parse(txtEdit_degree.Text),
                Double.Parse(txtEdit_address.Text),
                Double.Parse(txtEdit_year.Text)
                ).ToString();
            memoEdit_salary.Text = pred;
        }
    }
}
