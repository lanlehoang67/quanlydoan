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
    public partial class EditformGV : Form
    {
        public delegate void CheckShow();

        public CheckShow ShowForm;
        public EditformGV()
        {
            InitializeComponent();
        }
        public EditformGV(string msgv)
        {
            InitializeComponent();
            LoadData(msgv);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        void LoadData(string msgv)
        {
            using (PCDAEntities db = new PCDAEntities())
            {
                GiaoVien gv = db.GiaoViens.SingleOrDefault(p => p.MSGV == msgv);
                txbMSGV.Text = msgv;
                txbName.Text = gv.TenGV;
                txbSDT.Text = gv.SDT;
                txbEmail.Text = gv.Email;
                txbYearStart.Text = gv.NamBatDau.ToString();
                txbHSTN.Text = gv.HSThamNien.ToString();
                txbHSCM.Text = gv.HSCM.ToString();
                txbHSNCKH.Text = gv.HSNCKH.ToString();
            }
        }
        bool Check()
        {
            int result;
            if (txbName.Text.Length < 3 || txbMSGV.Text.Length < 3)
            {
                MessageBox.Show("length must be >3");
                return false;
            }

            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (PCDAEntities db = new PCDAEntities())
            {
                int result;
                if (Check() == true)
                {
                    try
                    {
                        GiaoVien gv = db.GiaoViens.SingleOrDefault(p => p.MSGV == txbMSGV.Text);
                        gv.TenGV = txbName.Text;
                        gv.SDT = txbSDT.Text;
                        gv.Email = txbEmail.Text;
                        gv.NamBatDau = int.Parse(txbYearStart.Text);
                        gv.HSThamNien = double.Parse(txbHSTN.Text);
                        gv.HSCM = int.Parse(txbHSCM.Text);
                        gv.HSNCKH = int.Parse(txbHSNCKH.Text);
                        db.SaveChanges();
                        if (ShowForm != null)
                        {
                            ShowForm();
                        }
                    }
                    catch
                    {

                    }
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}