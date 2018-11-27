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
    public partial class Addform : Form
    {
        public delegate void CheckShow();
        public CheckShow ShowForm;
        public Addform()
        {
            InitializeComponent();
            LoadCBB();
            cbb1.SelectedIndex = 0;
            cbb2.SelectedIndex = 0;
        }
        void Add()
        {
            using (PhanCongDoAnEntities db = new PhanCongDoAnEntities())
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
                    KetQua kq = new KetQua
                    {
                        MSSV = txbMSSV.Text,
                        MSGVHD1 = GetMSGV(cbb1.SelectedItem.ToString()),
                        MSGVHD2 = cbb2.SelectedItem.ToString() == "None" ? null : GetMSGV(cbb2.SelectedItem.ToString())
                    };
                    db.SinhViens.Add(sv);
                    db.KetQuas.Add(kq);
                    db.SaveChanges();
                }
                catch { }
                if (ShowForm != null)
                {
                    ShowForm();
                }
            }
        }
        void LoadCBB()
        {
            using (PhanCongDoAnEntities db = new PhanCongDoAnEntities())
            {
                var query = from p in db.GiaoViens
                            select p.TenGV;
                foreach (var item in query.ToList())
                {
                    cbb1.Items.Add(item.ToString());
                    cbb2.Items.Add(item.ToString());
                }
            }

        }
        public string GetMSGV(string tengv)
        {
            using(PhanCongDoAnEntities db=new PhanCongDoAnEntities())
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
