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
    public partial class AddformGV : Form
    {
        public delegate void CheckShow();
        public CheckShow ShowForm;
        public AddformGV()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        bool Check()
        {
            int result;
            if (txbName.Text.Length < 3 || txbMSGV.Text.Length < 3)
            {
                MessageBox.Show("length must be >3");
                return false;
            }
            if (!int.TryParse(txbMSGV.Text, out result))
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
                        GiaoVien gv = new GiaoVien
                        {
                            MSGV = txbMSGV.Text,
                            TenGV = txbName.Text,
                            SDT = txbSDT.Text,
                            Email = txbEmail.Text,
                            NamBatDau = int.Parse(txbYearStart.Text),
                            HSThamNien = double.Parse(txbHSTN.Text),
                            HSCM = int.Parse(txbHSCM.Text),
                            HSNCKH = int.Parse(txbHSNCKH.Text)

                        };

                        db.GiaoViens.Add(gv);

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