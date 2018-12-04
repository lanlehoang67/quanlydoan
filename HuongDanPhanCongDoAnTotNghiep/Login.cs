using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuongDanPhanCongDoAnTotNghiep
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txbTK.Text == "admin" && txbMK.Text == "123456")
            {
                MessageBox.Show("Login Success");
               
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }
        void Close()
        {
            this.Close();
        }
    }
}
