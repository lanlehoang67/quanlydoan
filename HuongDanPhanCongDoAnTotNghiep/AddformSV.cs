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
    public partial class AddformSV : Form
    {
        public delegate void CheckShow();
        public CheckShow ShowForm;
        public AddformSV()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        bool Check()
        {
            int result;
            if (txbName.Text.Length < 3 || txbMSSV.Text.Length < 3)
            {
                MessageBox.Show("length must be >3");
                return false;

            }
            if (!int.TryParse(txbMSSV.Text, out result))
            {
                MessageBox.Show("integer only");
                return false;

            }
            return true;
        }
        void Add()
        {
            using (PCDAEntities db = new PCDAEntities())
            {
                try
                {
                    int result;
                    if (Check() == true)
                    {

                        SinhVien sv = new SinhVien
                        {
                            MSSV = txbMSSV.Text,
                            TenSV = txbName.Text,
                            NgaySinh = dateTimePicker1.Value,
                            Lop = txbClass.Text,

                        };

                        db.SinhViens.Add(sv);

                        db.SaveChanges();


                        if (ShowForm != null)
                        {
                            ShowForm();
                            this.Close();
                        }
                    }
                }
                catch
                {

                }
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            Add();



        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}