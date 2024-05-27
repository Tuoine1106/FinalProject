using System;
using System.Windows.Forms;
using FinalProject.BLL;

namespace FinalProject
{
    public partial class FormViewStatistics : Form
    {
        private ThongKeSoLieuBLL thongKeBLL = new ThongKeSoLieuBLL();

        public FormViewStatistics()
        {
            InitializeComponent();
        }

        private void FormViewStatistics_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            var statistics = thongKeBLL.GetStatistics();
            dataGridViewStatistics.DataSource = statistics;
        }
    }
}
