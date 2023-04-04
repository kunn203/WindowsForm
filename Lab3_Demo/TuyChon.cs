using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    public partial class frmTuyChon : Form
    {
        QuanLySinhVien qlsv;
        public List<SinhVien> DanhSach;


        public frmTuyChon()
        {
            InitializeComponent();
        }

        public int SapXep;
        public string Data="";
        public int Chon;
         

        enum TuyChon
        {
          MaSV,
          HoTen,
          NgaySinh
        }

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            btnTim.Enabled = true;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if(rdMaSV.Checked)
                SapXep = 0;
            if (rdHoTen.Checked)
                SapXep = 1;
            if (rdNgaySinh.Checked)
                SapXep = 2;
            Chon = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdMaSV.Checked)
                SapXep = 0;
            if (rdHoTen.Checked)
                SapXep = 1;
            if (rdNgaySinh.Checked)
                SapXep = 2;
            Data = txtNhap.Text;
            Chon = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
