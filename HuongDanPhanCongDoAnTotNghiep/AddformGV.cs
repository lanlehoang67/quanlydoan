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
        void Add()
        {
            using (PCDAEntities db = new PCDAEntities())
            {
                GiaoVien gv = new GiaoVien
                    {
                       MSGV = txbMSGV.Text,
                       TenGV = txbName.Text,
                       SDT = txbSDT.Text,
                       Email = txbEmail.Text,
                       NamBatDau = int.Parse(txbYearStart.Text),
                       HSThamNien = double.Parse( txbHSTN.Text),
                       HSCM = int.Parse(txbHSCM.Text),
                       HSNCKH= int.Parse(txbHSNCKH.Text)

                    };

                    db.GiaoViens.Add(gv);

                    db.SaveChanges();
                
               
                if (ShowForm != null)
                {
                    ShowForm();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Add();
            this.Close();
        }
    }
}
