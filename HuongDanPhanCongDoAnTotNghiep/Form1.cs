
using Excel;
using Excel2 = Microsoft.Office.Interop.Excel;
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
using System.Collections;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace HuongDanPhanCongDoAnTotNghiep
{
    public partial class Form1 : Form
    {

        public delegate void CloseForm();
        public CloseForm Close;
        public delegate void PassControl(object sender);
        public PassControl passControl;
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
            dataGridView1.ReadOnly = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public Form1(string power)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;

            this.StartPosition = FormStartPosition.CenterScreen;
            if (power == "user")
            {
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnFix.Enabled = false;
                label3.Text = "Hello user";
            }
            else label3.Text = "Hello admin";
        }
        void Show1()
        {
            btnAdd.Visible = true;
            btnDel.Visible = true;
            btnFix.Visible = true;

            int soSV;
            listBox1.Items.Clear();
            groupBox1.Visible = true;
            groupBox1.Text = "Danh sách lớp";
            groupBox2.Visible = true;
            groupBox2.Text = "Danh sách sinh viên";
            using (PCDAEntities db = new PCDAEntities())
            {
                var query = from p in db.SinhViens.OrderBy(k => k.TenSV)
                            select new
                            {
                                MSSV = p.MSSV,
                                p.TenSV,
                                p.Lop,
                                p.NgaySinh

                            };
                var query2 = from p in db.SinhViens.OrderBy(k => k.Lop)
                             select p.Lop;
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


            }
            label2.Text = dataGridView1.Rows.Count.ToString();
            soSV = int.Parse(dataGridView1.Rows.Count.ToString());
        }
        void Show2()
        {
            btnAdd.Visible = true;
            btnDel.Visible = true;
            btnFix.Visible = true;

            listBox1.Items.Clear();
            groupBox1.Visible = true;
            groupBox1.Text = "Danh sách chuyên môn";
            groupBox2.Visible = true;
            groupBox2.Text = "Danh sách giảng viên";
            using (PCDAEntities db = new PCDAEntities())
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
            label2.Text = dataGridView1.Rows.Count.ToString();
        }
        void ShowKQ()
        {
            btnAdd.Visible = true;
            btnDel.Visible = true;
            btnFix.Visible = true;
            listBox1.Items.Clear();
            groupBox1.Visible = true;
            groupBox1.Text = "Danh sách giảng viên";
            groupBox2.Visible = true;
            groupBox2.Text = "Kết quả";
            using (PCDAEntities db = new PCDAEntities())
            {
                var query = from p in db.KetQuas
                            from k in db.SinhViens
                            from s in db.GiaoViens
                            where p.MSGVHD1 == s.MSGV && p.MSSV == k.MSSV
                            select new
                            {
                                p.MSSV,
                                k.TenSV,
                                k.NgaySinh,
                                k.Lop,
                                GVHD = s.TenGV

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

                dataGridView1.Columns[2].HeaderText = "Ngày sinh";

                dataGridView1.Columns[3].HeaderText = "Lớp";
                dataGridView1.Columns[4].HeaderText = "GVHD";

            }
            label2.Text = dataGridView1.Rows.Count.ToString();
        }
        private void tsStudent_Click(object sender, EventArgs e)
        {
            Show1();

        }

        private void tsTeacher_Click(object sender, EventArgs e)
        {
            Show2();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                else if (groupBox2.Text == "Kết quả")
                {
                    dataGridView1.ClearSelection();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Visible = true;
                    }
                    string tengv = listBox1.SelectedItem.ToString();
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        if (tengv != row.Cells[4].Value.ToString())
                        {
                            row.Visible = false;
                        }

                        currencyManager1.ResumeBinding();
                    }
                }
                else if (groupBox2.Text == "Danh sách phân công")
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

                        if (lop != row.Cells[3].Value.ToString())
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
                        else if (chuyenmon == "Tiến sĩ")
                        {
                            if (int.Parse(row.Cells[6].Value.ToString()) != 3)
                            {
                                row.Visible = false;
                            }
                        }
                        else if (chuyenmon == "PGS,TSKH")
                        {
                            if (int.Parse(row.Cells[6].Value.ToString()) != 4)
                            {
                                row.Visible = false;
                            }
                        }
                        else if (chuyenmon == "GS")
                        {
                            if (int.Parse(row.Cells[6].Value.ToString()) != 5)
                            {
                                row.Visible = false;
                            }
                        }

                        currencyManager1.ResumeBinding();
                    }
                }
                else if (imported)
                {
                    dataGridView1.DataSource = result.Tables[listBox1.SelectedIndex];
                }

            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (groupBox2.Text == "Danh sách sinh viên")
            {
                AddformSV sv = new AddformSV();
                sv.Show();
                sv.ShowForm += Show1;
            }
            else if (groupBox2.Text == "Danh sách giảng viên")
            {
                AddformGV gv = new AddformGV();
                gv.Show();
                gv.ShowForm += Show2;
            }

        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (groupBox2.Text == "Danh sách sinh viên")
            {
                EditformSV efsv = new EditformSV(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                efsv.Show();
                efsv.ShowForm += Show1;
            }
            else if (groupBox2.Text == "Danh sách giảng viên")
            {
                EditformGV efgv = new EditformGV(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                efgv.Show();
                efgv.ShowForm += Show2;
            }
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
                if (groupBox2.Text == "Danh sách sinh viên")
                {
                    foreach (int index in listIndex)
                    {
                        string deleteMSSV = dataGridView1.Rows[index].Cells[0].Value.ToString();


                        using (PCDAEntities db = new PCDAEntities())
                        {

                            SinhVien deleteSV = db.SinhViens.SingleOrDefault(p => p.MSSV == deleteMSSV);


                            db.SinhViens.Remove(deleteSV);
                            db.SaveChanges();
                            Show1();
                        }
                    }
                }
                else if (groupBox2.Text == "Danh sách giảng viên")
                {
                    foreach (int index in listIndex)
                    {
                        string deleteMSGV = dataGridView1.Rows[index].Cells[0].Value.ToString();


                        using (PCDAEntities db = new PCDAEntities())
                        {

                            GiaoVien deleteGV = db.GiaoViens.SingleOrDefault(p => p.MSGV == deleteMSGV);


                            db.GiaoViens.Remove(deleteGV);
                            db.SaveChanges();
                            Show2();
                        }
                    }
                }
            }

        }
        DataSet result;
        private void tsOpenFile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003|*.xls|Excel Workbook|*.xlsx", ValidateNames = true })
            {
                //if (ofd.ShowDialog() == DialogResult.OK)
                //{
                //    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                //    IExcelDataReader reader;
                //    if (ofd.FilterIndex == 1)
                //    {
                //        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                //    }
                //    else
                //    {
                //        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                //    }
                //    reader.IsFirstRowAsColumnNames = true;
                //    result = reader.AsDataSet();
                //    listBox1.Items.Clear();
                //    foreach (System.Data.DataTable dt in result.Tables)
                //    {
                //        listBox1.Items.Add(dt.TableName);
                //    }
                //    if (reader.IsValid)
                //    {
                //        groupBox1.Visible = true;
                //        groupBox2.Visible = true;
                //        imported = true;
                //        dataGridView1.DataSource = result.Tables[listBox1.SelectedIndex + 1];
                //    }
                //    reader.Close();
                //}
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream stream = new FileStream(ofd.FileName, FileMode.Open);
                    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    DataSet result = excelReader.AsDataSet();
                    using(PCDAEntities db = new PCDAEntities())
                    {
                       foreach(System.Data.DataTable table in result.Tables)
                        {
                            foreach(DataRow dr in table.Rows)
                            {
                                if (dr[4].ToString() == "GVHD") continue;
                                KetQua kq = new KetQua
                                {
                                    MSSV = dr[0].ToString(),
                                    MSGVHD1 = GetMSGV(dr[4].ToString())
                                };
                                db.KetQuas.Add(kq);
                                db.SaveChanges();
                            }
                        }
                    }
                    excelReader.Close();
                    stream.Close();
                    MessageBox.Show("imported");
                }
            }
        }

        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsExportFile_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook Workbooks = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

            List<string> tenLop = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!tenLop.Contains(row.Cells[3].Value.ToString()))
                {
                    tenLop.Add(row.Cells[3].Value.ToString());
                }
            }
            
            for (int k = 1; k <= tenLop.Count; k++)
            {
                Microsoft.Office.Interop.Excel.Worksheet Worksheet1 = (Microsoft.Office.Interop.Excel.Worksheet)Workbooks.Worksheets[1];
                if (tenLop.Count == 1)
                {
                    Worksheet1 = (Worksheet)Workbooks.Worksheets[k + 1];
                }
                else if(k < tenLop.Count)
                {
                    Worksheet1 = Workbooks.Sheets.Add(Type.Missing, Workbooks.Sheets[Workbooks.Sheets.Count], 1, Type.Missing) as Worksheet;
                }
                Worksheet1.Name = tenLop[k - 1].ToString();

                List<DataGridViewRow> rowFound = dataGridView1.Rows.Cast<DataGridViewRow>().Where(t => t.Cells[3].Value.ToString().Equals(tenLop[k - 1])).ToList();

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    Worksheet1.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < rowFound.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {

                        if (rowFound[i].Cells[j].Value != null)
                        {
                            if (rowFound[i].Cells[3].Value.ToString() == tenLop[k - 1].ToString())
                            {
                                Worksheet1.Cells[i + 2, j + 1] = rowFound[i].Cells[j].Value.ToString();
                            }
                        }
                        else Worksheet1.Cells[i + 2, j + 1].Value = "NULL";

                    }

                }

                Worksheet1.Columns.AutoFit();

            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                Workbooks.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
            MessageBox.Show("Successfully exported to excel");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell.ReadOnly = false;
        }

        private void btnXep_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnDel.Visible = false;
            btnFix.Visible = false;

            listBox1.Items.Clear();
            double tongDiem = 0;
            int soSV;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            if (btnAdd.Enabled == false)
            {
                dataGridView1.ReadOnly = true;
            }
            using (PCDAEntities db = new PCDAEntities())
            {
                //var query = db.SinhViens.ToList();

                soSV = db.SinhViens.ToList().Count;
                var listdiemGV = from p in db.GiaoViens.OrderBy(k => k.TenGV)
                                 select new
                                 {

                                     MSGV = p.MSGV,
                                     TenGV = p.TenGV,
                                     diem = p.HSThamNien + p.HSCM + p.HSNCKH
                                 };

                foreach (var item in listdiemGV.ToList())
                {
                    tongDiem += (double)item.diem;
                }
                List<int> ListSoSV1GV = new List<int>();
                Random rd = new Random();
                List<int> IndexSVofGV = new List<int>();
                List<int> IndexSVofGVnew = new List<int>();
                List<int> sosv1gvlist = new List<int>();
                for (int i = 0; i < soSV; i++)
                {
                    IndexSVofGVnew.Add(i);
                }
                var listcvDiemGV = listdiemGV.ToList();

                for (int j = 0; j < listcvDiemGV.Count; j++)
                {
                    int sosv1gv = Convert.ToInt32(listcvDiemGV[j].diem / tongDiem * soSV);
                    sosv1gvlist.Add(sosv1gv);
                    for (int i = 0; i < sosv1gv; i++)
                    {
                        if (IndexSVofGVnew.Count > 0)
                        {
                            int temp1 = rd.Next(0, IndexSVofGVnew.Count);
                            IndexSVofGV.Add(IndexSVofGVnew[temp1]);
                            IndexSVofGVnew.Remove(IndexSVofGVnew[temp1]);
                        }

                    }

                }
                //comboBox1.DataSource = sosv1gvlist;
                //  MessageBox.Show("so sv " + IndexSVofGV.Count.ToString());
                List<SinhVien> listSV = db.SinhViens.OrderBy(k => k.TenSV).ToList();
                List<GiaoVien> listGV = db.GiaoViens.OrderBy(k => k.TenGV).ToList();
                int x = 0;
                List<SinhVien> alllistsv = new List<SinhVien>();

                for (int j = 0; j < listcvDiemGV.Count; j++)
                {
                    int sosv1gvv = sosv1gvlist[j];
                    for (int i = 0; i < sosv1gvv; i++)
                    {
                        if (x < soSV - 1)
                        {
                            x++;
                            listSV[IndexSVofGV[x]].TenGV = listcvDiemGV[j].TenGV;
                            alllistsv.Add(listSV[IndexSVofGV[x]]);
                        }

                    }
                }
                
                dataGridView1.DataSource = alllistsv;
                
                dataGridView1.Columns[0].HeaderText = "MSSV";
                dataGridView1.Columns[1].HeaderText = "Họ và tên";
                dataGridView1.Columns[2].HeaderText = "Ngày sinh";
                dataGridView1.Columns[3].HeaderText = "Lớp";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "GVHD";
                dataGridView1.Columns[5].Name = "GVHD";
                dataGridView1.Columns[6].Visible = false;
                
                label2.Text = (dataGridView1.Rows.Count + 1).ToString();
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox1.Text = "Danh sách lớp";

                groupBox2.Text = "Danh sách phân công";
                var query2 = from p in db.SinhViens.OrderBy(k => k.Lop)
                             select p.Lop;
                foreach (var item in query2.ToList())
                {
                    if (listBox1.FindStringExact(item.ToString()) < 0)
                    {
                        listBox1.Items.Add(item.ToString());
                    }
                }
            }
        }
        string GetMSGV(string TenGV)
        {
            using (PCDAEntities db = new PCDAEntities())
            {
                string MSGV = db.GiaoViens.SingleOrDefault(p => p.TenGV == TenGV).MSGV.ToString();
                return MSGV;
            }
        }
        private void tsSaveFile_Click(object sender, EventArgs e)
        {

            using (PCDAEntities db = new PCDAEntities())
            {

                if (groupBox2.Text == "Danh sách phân công" || dataGridView1.Columns[4].HeaderText != "GVHD" )
                {
                    var query = db.KetQuas.ToList();
                    foreach (KetQua kq in query)
                    {
                        db.KetQuas.Remove(kq);
                    }
                    db.SaveChanges();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        KetQua kq = new KetQua
                        {
                            MSSV = row.Cells[0].Value.ToString(),
                            MSGVHD1 = GetMSGV(row.Cells["GVHD"].Value.ToString())

                        };
                        db.KetQuas.Add(kq);
                        db.SaveChanges();

                    }

                    MessageBox.Show("Successfully saved");
                }
            }

        }
        List<SinhVien> listUpdateSV = new List<SinhVien>();




        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void tsResult_Click_1(object sender, EventArgs e)
        {
            ShowKQ();
        }
        void exportgridtopdf(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\ARIALUNI.TTF", BaseFont.IDENTITY_H, true);
            PdfPTable pdfPTable = new PdfPTable(dgv.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add header
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);
            }
            //add datagrow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {

                        pdfPTable.AddCell(new Phrase("NULL", text));

                    }
                    else pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialogue = new SaveFileDialog();
            savefiledialogue.FileName = filename;
            savefiledialogue.DefaultExt = ".pdf";
            if (savefiledialogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportgridtopdf(dataGridView1, "xuatfile");
            MessageBox.Show("pdf exported");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(txbFind.Text))
                {
                    row.Visible = true;
                }
                else row.Visible = false;
                currencyManager1.ResumeBinding();

            }
        }

        private void tsLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();

        }
    }
}
