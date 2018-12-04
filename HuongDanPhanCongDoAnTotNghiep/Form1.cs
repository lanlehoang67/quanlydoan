
using Excel;
using Excel2= Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace HuongDanPhanCongDoAnTotNghiep
{
    public partial class Form1 : Form
    {
        public delegate void CloseForm();
        public CloseForm Close;
        bool imported = false;
        struct DataParameter
        {
            public List<SinhVien> SinhVienList;
            public string FileName { get; set; }
        }
        DataParameter _inputparameter;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        void Show1()
        {
            listBox1.Items.Clear();
            groupBox1.Visible = true;
            groupBox1.Text = "Danh sách lớp";
            groupBox2.Visible = true;
            groupBox2.Text = "Danh sách sinh viên";
            using (PhanCongDoAnTotNghiepEntities db = new PhanCongDoAnTotNghiepEntities())
            {
                var query = from p in db.KetQuas.OrderBy(k => k.SinhVien.TenSV)
                            select new
                            {
                                MSSV = p.MSSV,
                                p.SinhVien.TenSV,
                                p.SinhVien.Lop,
                                p.SinhVien.NgaySinh,
                                TenGV1 = p.GiaoVien.TenGV,
                                TenGV2 = p.GiaoVien1.TenGV,
                            };
                var query2 = from p in db.KetQuas.OrderBy(k => k.SinhVien.Lop)
                             select p.SinhVien.Lop;
                foreach (var item in query2.ToList())
                {
                    if (listBox1.FindStringExact(item.ToString()) < 0)
                    {
                        listBox1.Items.Add(item.ToString());
                    }
                }
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns[0].HeaderText = "MSSV";
                dataGridView1.Columns[1].HeaderText = "Họ và tên";
                dataGridView1.Columns[2].HeaderText = "Lớp";
                dataGridView1.Columns[3].HeaderText = "Ngày sinh";
                dataGridView1.Columns[4].HeaderText = "Tên GVHD1";
                dataGridView1.Columns[5].HeaderText = "Tên GVHD2";
           
            }
        }
        void Show2()
        {
            listBox1.Items.Clear();
            groupBox1.Visible = true;
            groupBox1.Text = "Danh sách chuyên môn";
            groupBox2.Visible = true;
            groupBox2.Text = "Danh sách giảng viên";
            using (PhanCongDoAnTotNghiepEntities db = new PhanCongDoAnTotNghiepEntities())
            {
                var query = from p in db.GiaoViens.OrderBy(k => k.TenGV)
                            select new
                            {
                                p.MSGV,
                                p.TenGV,
                                p.SDT,
                                p.Email,
                                p.NamBatDau,
                                p.HSThamNien,
                                p.HSCM,
                                p.HSNCKH,
                                diem = p.HSThamNien + p.HSCM + p.HSNCKH
                            };
                var query2 = from p in db.GiaoViens.OrderBy(k => k.HeSoChuyenMon.ChuyenMon)
                             select p.HeSoChuyenMon.ChuyenMon;
                foreach (var item in query2.ToList())
                {
                    if (listBox1.FindStringExact(item.ToString()) < 0)
                    {
                        listBox1.Items.Add(item.ToString());
                    }
                }
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns[0].HeaderText = "MSGV";
                dataGridView1.Columns[1].HeaderText = "Họ và tên";
                dataGridView1.Columns[2].HeaderText = "Số điện thoại";
                dataGridView1.Columns[3].HeaderText = "Email";
                dataGridView1.Columns[4].HeaderText = "Năm bắt đầu";
                dataGridView1.Columns[5].HeaderText = "Hệ số thâm niên";
                dataGridView1.Columns[6].HeaderText = "Hệ số chuyên môn";
                dataGridView1.Columns[7].HeaderText = "Hệ số NCKH";
                dataGridView1.Columns[8].HeaderText = "Tổng điểm";


            }
        }
        void ShowKQ()
        {
            listBox1.Items.Clear();
            groupBox1.Visible = true;
            groupBox1.Text = "Danh sách giảng viên";
            groupBox2.Visible = true;
            groupBox2.Text = "Kết quả";
            using (PhanCongDoAnTotNghiepEntities db = new PhanCongDoAnTotNghiepEntities())
            {
                var query = from p in db.KetQuas
                            select new
                            {
                                p.SinhVien.MSSV,
                                p.SinhVien.TenSV,
                                
                                TENGV= p.GiaoVien.TenGV,
                               
                                TENGV2=p.GiaoVien1.TenGV
                            };
                var query2 = from p in db.GiaoViens.OrderBy(k => k.TenGV)
                             select p.TenGV;
                foreach (var item in query2.ToList())
                {
                    if (listBox1.FindStringExact(item.ToString()) < 0)
                    {
                        listBox1.Items.Add(item.ToString());
                    }
                }
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns[0].HeaderText = "MSSV";
                dataGridView1.Columns[1].HeaderText = "Họ và tên";
               
                dataGridView1.Columns[2].HeaderText = "Tên GVHD1";
                
                dataGridView1.Columns[3].HeaderText = "Tên GVHD2";
              
            }
        }
        private void tsStudent_Click(object sender, EventArgs e)
        {
            Show1();

        }

        private void tsTeacher_Click(object sender, EventArgs e)
        {
            Show2();
        }
        private void tsResult_Click(object sender, EventArgs e)
        {
            ShowKQ();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBox2.Text == "Danh sách sinh viên")
            {
                dataGridView1.ClearSelection();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
                string lop = listBox1.SelectedItem.ToString();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                currencyManager1.SuspendBinding();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (lop != row.Cells[2].Value.ToString())
                    {
                        row.Visible = false;
                    }

                    currencyManager1.ResumeBinding();
                }
            }
            else if (groupBox2.Text == "Danh sách giảng viên")
            {

                dataGridView1.ClearSelection();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
                string chuyenmon = listBox1.SelectedItem.ToString();
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                currencyManager1.SuspendBinding();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (chuyenmon == "Kỹ sư")
                    {
                        if (int.Parse(row.Cells[6].Value.ToString()) != 1)
                        {
                            row.Visible = false;
                        }
                    }
                    else if (chuyenmon == "Thạc sĩ")
                    {
                        if (int.Parse(row.Cells[6].Value.ToString()) != 2)
                        {
                            row.Visible = false;
                        }
                    }

                    currencyManager1.ResumeBinding();
                }
            }
            else if(imported)
            {
                dataGridView1.DataSource = result.Tables[listBox1.SelectedIndex ];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (groupBox2.Text == "Danh sách sinh viên")
            {
                AddformSV af = new AddformSV();

                af.Show();
                af.ShowForm += Show1;
            }
            else if(groupBox2.Text == "Danh sách giảng viên")
            {
                AddformGV gv = new AddformGV();
                gv.Show();
                
            }
            else if(groupBox2.Text == "Kết quả")
            {
                AddformKQ kq = new AddformKQ();
                kq.Show();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            Editform ef = new Editform();
            ef.Show();
            ef.ShowForm += Show1;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                List<int> listIndex = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    listIndex.Add(row.Index);
                }
                foreach (int index in listIndex)
                {
                    string deleteMSSV = dataGridView1.Rows[index].Cells[0].Value.ToString();


                    using (PhanCongDoAnTotNghiepEntities db = new PhanCongDoAnTotNghiepEntities())
                    {
                        SinhVien deleteSV = db.SinhViens.SingleOrDefault(p => p.MSSV == deleteMSSV);
                        KetQua deleteKq = db.KetQuas.SingleOrDefault(p => p.MSSV == deleteMSSV);
                        db.KetQuas.Remove(deleteKq);
                        db.SinhViens.Remove(deleteSV);
                        db.SaveChanges();
                        Show1();
                    }
                }
            }

        }
        DataSet result;
        private void tsOpenFile_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003|*.xls|Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (ofd.FilterIndex == 1)
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    }
                    else
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    }
                    reader.IsFirstRowAsColumnNames = true;
                    result = reader.AsDataSet();
                    listBox1.Items.Clear();
                    foreach(System.Data.DataTable dt in result.Tables)
                    {
                        listBox1.Items.Add(dt.TableName);
                    }
                    if (reader.IsValid)
                    {
                        groupBox1.Visible = true;
                        groupBox2.Visible = true;
                        imported = true;
                        dataGridView1.DataSource = result.Tables[listBox1.SelectedIndex+1];
                    }
                    reader.Close();
                }
            }
        }

        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tsExportFile_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(>2007)|*.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Excel2.Application ExcelApp = new Excel2.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 20;
                for(int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                 for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount ; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] =dataGridView1.Rows[i].Cells[j].Value;
                    }
                }        ﻿
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<SinhVien> list = ((DataParameter)e.Argument).SinhVienList;
            string fileName = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = list.Count;
            ws.Cells[1, 1] = "MSSV";
            ws.Cells[1, 2] = "Họ và tên";
            ws.Cells[1, 3] = "Ngày sinh";
            ws.Cells[1, 4] = "Lớp";
            foreach(SinhVien sv in list)
            {
                if (!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = sv.MSSV.ToString();
                    ws.Cells[index, 2] = sv.TenSV;
                    ws.Cells[index, 3] = sv.NgaySinh.ToString();
                    ws.Cells[index, 4] = sv.Lop.ToString();
                    
                }
            }
            ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            excel.Quit();
        }
        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Close != null)
            {
                Close();
            }
        }

        
    }
}
