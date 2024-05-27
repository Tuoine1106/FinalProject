using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormManagerMain : Form
    {
        public FormManagerMain()
        {
            InitializeComponent();
        }

        private void btnTrackOrders_Click(object sender, EventArgs e)
        {
            FormTrackOrder formTrackOrder = new FormTrackOrder();
            formTrackOrder.ShowDialog();
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            FormViewStatistics formViewStatistics = new FormViewStatistics();
            formViewStatistics.ShowDialog();
        }

        private void FormManagerMain_Load(object sender, EventArgs e)
        {
            // Add any initialization code here
        }
    }
}
