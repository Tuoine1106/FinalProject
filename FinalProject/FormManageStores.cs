using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormManageStores : Form
    {
        private QuanLyCuaHangBLL quanLyCuaHangBLL = new QuanLyCuaHangBLL();

        public FormManageStores()
        {
            InitializeComponent();
        }

        private void FormManageStores_Load(object sender, EventArgs e)
        {
            LoadStores();
        }

        private void LoadStores()
        {
            var stores = quanLyCuaHangBLL.GetStores();
            dataGridViewStores.DataSource = stores;
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            var store = new QuanLyCuaHang
            {
                TenQuanLy = txtTenQuanLy.Text,
                SoDienThoai = txtSoDienThoai.Text
            };
            quanLyCuaHangBLL.AddStore(store);
            LoadStores();
        }
    }
}
