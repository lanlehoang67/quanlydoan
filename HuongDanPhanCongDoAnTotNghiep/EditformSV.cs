﻿using System;
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
    public partial class EditformSV : Form
    {
       
        

        public delegate void CheckShow();

        public CheckShow ShowForm;
        public EditformSV()
        {
            InitializeComponent();



        }
        public EditformSV(string mssv)
        {
            InitializeComponent();
            this.Enabled = true;

            lbMSSV.Text = mssv;
            txbMSSV.Text = mssv;
            LoadData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        void LoadData()
        {
            using(PCDAEntities db = new PCDAEntities())
            {
                SinhVien sv = db.SinhViens.SingleOrDefault(p => p.MSSV == lbMSSV.Text);
                txbClass.Text = sv.Lop;
                txbName.Text = sv.TenSV;
                dateTimePicker1.Value =(DateTime) sv.NgaySinh;
            }
        }
        void Update1()
        {
            using (PCDAEntities db = new PCDAEntities())
            {
                SinhVien sv = db.SinhViens.SingleOrDefault(p => p.MSSV == lbMSSV.Text.ToString());

                if (sv != null)
                {
                    
                    sv.TenSV = txbName.Text;
                    sv.NgaySinh = (DateTime)dateTimePicker1.Value;
                    sv.Lop = txbClass.Text;
                    db.SaveChanges();
                    if (ShowForm != null)
                    {
                        ShowForm();
                    }
                    lbMSSV.Text = txbMSSV.Text;
                }
            }
        }





       

        

       

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Update1();
            this.Close();
        }
    }

}