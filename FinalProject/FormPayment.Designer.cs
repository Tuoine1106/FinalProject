namespace FinalProject
{
    partial class FormPayment
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnMoMo;
        private System.Windows.Forms.Button btnVNPay;

        private void InitializeComponent()
        {
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnMoMo = new System.Windows.Forms.Button();
            this.btnVNPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(30, 30);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(100, 30);
            this.btnCreditCard.TabIndex = 0;
            this.btnCreditCard.Text = "Credit Card";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnMoMo
            // 
            this.btnMoMo.Location = new System.Drawing.Point(150, 30);
            this.btnMoMo.Name = "btnMoMo";
            this.btnMoMo.Size = new System.Drawing.Size(100, 30);
            this.btnMoMo.TabIndex = 1;
            this.btnMoMo.Text = "MoMo";
            this.btnMoMo.UseVisualStyleBackColor = true;
            this.btnMoMo.Click += new System.EventHandler(this.btnMoMo_Click);
            // 
            // btnVNPay
            // 
            this.btnVNPay.Location = new System.Drawing.Point(270, 30);
            this.btnVNPay.Name = "btnVNPay";
            this.btnVNPay.Size = new System.Drawing.Size(100, 30);
            this.btnVNPay.TabIndex = 2;
            this.btnVNPay.Text = "VNPay";
            this.btnVNPay.UseVisualStyleBackColor = true;
            this.btnVNPay.Click += new System.EventHandler(this.btnVNPay_Click);
            // 
            // FormPayment
            // 
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.btnMoMo);
            this.Controls.Add(this.btnVNPay);
            this.Name = "FormPayment";
            this.Text = "Payment";
            this.ResumeLayout(false);
        }
    }
}
