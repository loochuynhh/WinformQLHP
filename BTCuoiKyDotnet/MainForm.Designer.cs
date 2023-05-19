namespace BTCuoiKyDotnet
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTTimKiem = new System.Windows.Forms.Button();
            this.TBTimKiem = new System.Windows.Forms.TextBox();
            this.CBBHocPhan = new System.Windows.Forms.ComboBox();
            this.LabelHocPhan = new System.Windows.Forms.Label();
            this.BTSapXep = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.CBBSapXep = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTTimKiem
            // 
            this.BTTimKiem.Location = new System.Drawing.Point(1038, 27);
            this.BTTimKiem.Name = "BTTimKiem";
            this.BTTimKiem.Size = new System.Drawing.Size(131, 43);
            this.BTTimKiem.TabIndex = 1;
            this.BTTimKiem.Text = "Tìm Kiếm";
            this.BTTimKiem.UseVisualStyleBackColor = true;
            this.BTTimKiem.Click += new System.EventHandler(this.BTTimKiem_Click);
            // 
            // TBTimKiem
            // 
            this.TBTimKiem.Location = new System.Drawing.Point(846, 37);
            this.TBTimKiem.Name = "TBTimKiem";
            this.TBTimKiem.Size = new System.Drawing.Size(180, 26);
            this.TBTimKiem.TabIndex = 2;
            // 
            // CBBHocPhan
            // 
            this.CBBHocPhan.FormattingEnabled = true;
            this.CBBHocPhan.Location = new System.Drawing.Point(39, 35);
            this.CBBHocPhan.Name = "CBBHocPhan";
            this.CBBHocPhan.Size = new System.Drawing.Size(189, 28);
            this.CBBHocPhan.TabIndex = 3;
            this.CBBHocPhan.SelectedIndexChanged += new System.EventHandler(this.CBBHocPhan_SelectedIndexChanged);
            // 
            // LabelHocPhan
            // 
            this.LabelHocPhan.AutoSize = true;
            this.LabelHocPhan.Location = new System.Drawing.Point(257, 38);
            this.LabelHocPhan.Name = "LabelHocPhan";
            this.LabelHocPhan.Size = new System.Drawing.Size(79, 20);
            this.LabelHocPhan.TabIndex = 4;
            this.LabelHocPhan.Text = "Học Phần";
            this.LabelHocPhan.Click += new System.EventHandler(this.LabelTenHocPhan_Click);
            // 
            // BTSapXep
            // 
            this.BTSapXep.Location = new System.Drawing.Point(818, 425);
            this.BTSapXep.Name = "BTSapXep";
            this.BTSapXep.Size = new System.Drawing.Size(131, 43);
            this.BTSapXep.TabIndex = 6;
            this.BTSapXep.Text = "Sắp Xếp";
            this.BTSapXep.UseVisualStyleBackColor = true;
            this.BTSapXep.Click += new System.EventHandler(this.BTSapXep_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(492, 425);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(131, 43);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(261, 425);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(131, 43);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(39, 425);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(131, 43);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // CBBSapXep
            // 
            this.CBBSapXep.FormattingEnabled = true;
            this.CBBSapXep.Location = new System.Drawing.Point(980, 433);
            this.CBBSapXep.Name = "CBBSapXep";
            this.CBBSapXep.Size = new System.Drawing.Size(189, 28);
            this.CBBSapXep.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 480);
            this.Controls.Add(this.CBBSapXep);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.BTSapXep);
            this.Controls.Add(this.LabelHocPhan);
            this.Controls.Add(this.CBBHocPhan);
            this.Controls.Add(this.TBTimKiem);
            this.Controls.Add(this.BTTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTTimKiem;
        private System.Windows.Forms.TextBox TBTimKiem;
        private System.Windows.Forms.ComboBox CBBHocPhan;
        private System.Windows.Forms.Label LabelHocPhan;
        private System.Windows.Forms.Button BTSapXep;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox CBBSapXep;
    }
}

