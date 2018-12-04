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
           
        }
        void Add()
        {
            using (PhanCongDoAnTotNghiepEntities db = new PhanCongDoAnTotNghiepEntities())
            {
                try
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
                }
                catch { }
                if (ShowForm != null)
                {
                    ShowForm();
                }
            }
        }
      
        public string GetMSGV(string tengv)
        {
            using(PhanCongDoAnTotNghiepEntities db=new PhanCongDoAnTotNghiepEntities())
            {
                var query = db.GiaoViens.SingleOrDefault(p => p.TenGV == tengv).MSGV;
                return query.ToString();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Add();
            this.Close();
           

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
