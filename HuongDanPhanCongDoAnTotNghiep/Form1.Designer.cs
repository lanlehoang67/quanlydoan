namespace HuongDanPhanCongDoAnTotNghiep
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsResult = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnXep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txbFind = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenFile,
            this.tsExportFile,
            this.tsSaveFile,
            this.tsStudent,
            this.tsTeacher,
            this.tsResult,
            this.printToolStripMenuItem,
            this.tsLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 80);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsOpenFile
            // 
            this.tsOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsOpenFile.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.decrypted;
            this.tsOpenFile.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpenFile.Name = "tsOpenFile";
            this.tsOpenFile.Size = new System.Drawing.Size(60, 76);
            this.tsOpenFile.Text = "Mở File";
            this.tsOpenFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsOpenFile.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsOpenFile.Click += new System.EventHandler(this.tsOpenFile_Click);
            // 
            // tsExportFile
            // 
            this.tsExportFile.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.apply;
            this.tsExportFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsExportFile.Name = "tsExportFile";
            this.tsExportFile.Size = new System.Drawing.Size(64, 76);
            this.tsExportFile.Text = "Xuất File";
            this.tsExportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsExportFile.Click += new System.EventHandler(this.tsExportFile_Click);
            // 
            // tsSaveFile
            // 
            this.tsSaveFile.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.filesave;
            this.tsSaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSaveFile.Name = "tsSaveFile";
            this.tsSaveFile.Size = new System.Drawing.Size(60, 76);
            this.tsSaveFile.Text = "Lưu";
            this.tsSaveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSaveFile.Click += new System.EventHandler(this.tsSaveFile_Click);
            // 
            // tsStudent
            // 
            this.tsStudent.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.student;
            this.tsStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsStudent.Name = "tsStudent";
            this.tsStudent.Size = new System.Drawing.Size(66, 76);
            this.tsStudent.Text = "Học viên";
            this.tsStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStudent.Click += new System.EventHandler(this.tsStudent_Click);
            // 
            // tsTeacher
            // 
            this.tsTeacher.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.teacher;
            this.tsTeacher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTeacher.Name = "tsTeacher";
            this.tsTeacher.Size = new System.Drawing.Size(75, 76);
            this.tsTeacher.Text = "Giảng viên";
            this.tsTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsTeacher.Click += new System.EventHandler(this.tsTeacher_Click);
            // 
            // tsResult
            // 
            this.tsResult.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.lichbieu;
            this.tsResult.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsResult.Name = "tsResult";
            this.tsResult.Size = new System.Drawing.Size(60, 76);
            this.tsResult.Text = "Kết quả";
            this.tsResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsResult.Click += new System.EventHandler(this.tsResult_Click_1);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.printer1;
            this.printToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(60, 76);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // tsLogOut
            // 
            this.tsLogOut.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.exit;
            this.tsLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLogOut.Name = "tsLogOut";
            this.tsLogOut.Size = new System.Drawing.Size(72, 76);
            this.tsLogOut.Text = "Đăng xuất";
            this.tsLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogOut.Click += new System.EventHandler(this.tsLogOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnFix);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 396);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(118, 370);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(48, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFix
            // 
            this.btnFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFix.Location = new System.Drawing.Point(67, 370);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(48, 23);
            this.btnFix.TabIndex = 2;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(13, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(178, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 396);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnXep
            // 
            this.btnXep.Location = new System.Drawing.Point(799, 25);
            this.btnXep.Name = "btnXep";
            this.btnXep.Size = new System.Drawing.Size(75, 23);
            this.btnXep.TabIndex = 4;
            this.btnXep.Text = "Xếp";
            this.btnXep.UseVisualStyleBackColor = true;
            this.btnXep.Click += new System.EventHandler(this.btnXep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(218, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(113, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Tìm theo tên";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbFind
            // 
            this.txbFind.Location = new System.Drawing.Point(15, 32);
            this.txbFind.Name = "txbFind";
            this.txbFind.Size = new System.Drawing.Size(197, 20);
            this.txbFind.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txbFind);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Location = new System.Drawing.Point(581, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 100);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(HuongDanPhanCongDoAnTotNghiep.SinhVien);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXep);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quản lý phân công đồ án tốt nghiệp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tsExportFile;
        private System.Windows.Forms.ToolStripMenuItem tsSaveFile;
        private System.Windows.Forms.ToolStripMenuItem tsStudent;
        private System.Windows.Forms.ToolStripMenuItem tsTeacher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnXep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tsResult;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txbFind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tsLogOut;
        private System.Windows.Forms.Label label3;
    }
}

