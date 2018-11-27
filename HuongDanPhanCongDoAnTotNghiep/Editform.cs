using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HuongDanPhanCongDoAnTotNghiep
{
    public partial class Editform : Form
    {
        Addform af;
        public delegate void CheckShow();
        public CheckShow ShowForm;
        public Editform()
        {
            InitializeComponent();
            LoadCbb();
            cbb1.SelectedIndex = 0;
            cbb2.SelectedIndex = 0;

        }
        void LoadCbb()
        {
           
            using (PhanCongDoAnEntities db = new PhanCongDoAnEntities())
            {
                var query1 = from p in db.KetQuas
                            select p.MSSV;
                var query2= from p in db.GiaoViens
                            select p.TenGV;
                foreach (var item in query1.ToList())
                {
                    cbbMSSV.Items.Add(item.ToString());
                 
                }
                foreach( var item in query2.ToList())
                {
                    cbb1.Items.Add(item.ToString());
                    cbb2.Items.Add(item.ToString());
                }
            }
        }
        void Update1()
        {
            using(PhanCongDoAnEntities db=new PhanCongDoAnEntities())
            {
                SinhVien sv = db.SinhViens.SingleOrDefault(p => p.MSSV == cbbMSSV.SelectedItem.ToString());
                KetQua kq = db.KetQuas.SingleOrDefault(p => p.MSSV == cbbMSSV.SelectedItem.ToString());
                if(sv!= null && kq!=null)
                {
                    sv.MSSV = cbbMSSV.SelectedItem.ToString();
                    sv.TenSV = txbName.Text;
                    sv.NgaySinh =(DateTime) dateTimePicker1.Value;
                    sv.Lop = txbClass.Text;
                    db.SaveChanges();
                    if (ShowForm != null)
                    {
                        ShowForm();
                    }
                }
            }
        }

        public string GetMSGV(string tengv)
        {
           
            using (PhanCongDoAnEntities db = new PhanCongDoAnEntities())
            {
                var query = db.GiaoViens.SingleOrDefault(p => p.TenGV == tengv).MSGV;
                return query.ToString();
            }
        }
        int GetIndex(ComboBox cbb, string value)
        {
            for (int i = 0; i < cbb.Items.Count; i++)
            {
                if (cbb.Items[i].ToString() == value)
                {
                    return i;
                }

            }
            return -1;
        }

        private void cbbMSSV_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                item.Enabled = true;
            }
            using (PhanCongDoAnEntities db = new PhanCongDoAnEntities())
            {
               
                SinhVien sv= db.SinhViens.SingleOrDefault(p => p.MSSV == cbbMSSV.SelectedItem.ToString());
                KetQua kq = db.KetQuas.SingleOrDefault(p => p.MSSV == sv.MSSV.ToString());
                GiaoVien gv1 = db.GiaoViens.SingleOrDefault(p => p.MSGV == kq.MSGVHD1);
                GiaoVien gv2 = db.GiaoViens.SingleOrDefault(p => p.MSGV == kq.MSGVHD2);
                txbName.Text = sv.TenSV.ToString();
                txbClass.Text = sv.Lop;
                dateTimePicker1.Value = Convert.ToDateTime(sv.NgaySinh.Value);
                cbb1.SelectedIndex = GetIndex(cbb1, gv1.TenGV);
                if (gv2 == null)
                {
                    cbb2.SelectedIndex = 0;
                }
                else
                {
                    cbb2.SelectedIndex = GetIndex(cbb2, gv2.TenGV);
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Update1();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
