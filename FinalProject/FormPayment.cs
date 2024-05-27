using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormPayment : Form
    {
        private int orderId;

        public FormPayment(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            OpenShippingForm();
        }

        private void btnMoMo_Click(object sender, EventArgs e)
        {
            OpenShippingForm();
        }

        private void btnVNPay_Click(object sender, EventArgs e)
        {
            OpenShippingForm();
        }

        private void OpenShippingForm()
        {
            FormShipping formShipping = new FormShipping(orderId);
            formShipping.ShowDialog();
            this.Close();
        }
    }
}
