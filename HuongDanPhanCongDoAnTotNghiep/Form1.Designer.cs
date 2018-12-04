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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tsOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsResult = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tsResult});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 80);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnFix);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 355);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(118, 329);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(48, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(67, 329);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(48, 23);
            this.btnFix.TabIndex = 2;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(178, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 355);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            // 
            // tsStudent
            // 
            this.tsStudent.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.student;
            this.tsStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsStudent.Name = "tsStudent";
            this.tsStudent.Size = new System.Drawing.Size(83, 76);
            this.tsStudent.Text = "DS Học viên";
            this.tsStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStudent.Click += new System.EventHandler(this.tsStudent_Click);
            // 
            // tsTeacher
            // 
            this.tsTeacher.Image = global::HuongDanPhanCongDoAnTotNghiep.Properties.Resources.teacher;
            this.tsTeacher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTeacher.Name = "tsTeacher";
            this.tsTeacher.Size = new System.Drawing.Size(92, 76);
            this.tsTeacher.Text = "DS Giảng viên";
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
            this.tsResult.Click += new System.EventHandler(this.tsResult_Click);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(HuongDanPhanCongDoAnTotNghiep.SinhVien);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripMenuItem tsResult;
    }
}

