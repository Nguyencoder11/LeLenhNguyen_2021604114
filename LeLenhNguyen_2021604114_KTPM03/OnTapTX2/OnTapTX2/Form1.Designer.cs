namespace OnTapTX2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHangXe = new System.Windows.Forms.TextBox();
            this.txtDongXe = new System.Windows.Forms.TextBox();
            this.txtPhienBan = new System.Windows.Forms.TextBox();
            this.txtDongCo = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataXe = new System.Windows.Forms.DataGridView();
            this.hangxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phienban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãng xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dòng xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phiên bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Động cơ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá";
            // 
            // txtHangXe
            // 
            this.txtHangXe.Location = new System.Drawing.Point(186, 46);
            this.txtHangXe.Name = "txtHangXe";
            this.txtHangXe.Size = new System.Drawing.Size(219, 26);
            this.txtHangXe.TabIndex = 5;
            this.txtHangXe.TextChanged += new System.EventHandler(this.txtHangXe_TextChanged);
            // 
            // txtDongXe
            // 
            this.txtDongXe.Location = new System.Drawing.Point(186, 92);
            this.txtDongXe.Name = "txtDongXe";
            this.txtDongXe.Size = new System.Drawing.Size(219, 26);
            this.txtDongXe.TabIndex = 6;
            // 
            // txtPhienBan
            // 
            this.txtPhienBan.Location = new System.Drawing.Point(186, 144);
            this.txtPhienBan.Name = "txtPhienBan";
            this.txtPhienBan.Size = new System.Drawing.Size(219, 26);
            this.txtPhienBan.TabIndex = 7;
            // 
            // txtDongCo
            // 
            this.txtDongCo.Location = new System.Drawing.Point(575, 46);
            this.txtDongCo.Name = "txtDongCo";
            this.txtDongCo.Size = new System.Drawing.Size(225, 26);
            this.txtDongCo.TabIndex = 8;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(575, 92);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(225, 26);
            this.txtGia.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(889, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 42);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(889, 96);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 42);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(889, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 42);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(889, 223);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 42);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataXe
            // 
            this.dataXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hangxe,
            this.dongxe,
            this.phienban,
            this.dongco,
            this.gia});
            this.dataXe.Location = new System.Drawing.Point(24, 294);
            this.dataXe.Name = "dataXe";
            this.dataXe.RowHeadersWidth = 62;
            this.dataXe.RowTemplate.Height = 28;
            this.dataXe.Size = new System.Drawing.Size(965, 217);
            this.dataXe.TabIndex = 14;
            this.dataXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataXe_CellClick);
            // 
            // hangxe
            // 
            this.hangxe.HeaderText = "Hãng xe";
            this.hangxe.MinimumWidth = 8;
            this.hangxe.Name = "hangxe";
            // 
            // dongxe
            // 
            this.dongxe.HeaderText = "Dòng xe";
            this.dongxe.MinimumWidth = 8;
            this.dongxe.Name = "dongxe";
            this.dongxe.Width = 120;
            // 
            // phienban
            // 
            this.phienban.HeaderText = "Phiên bản";
            this.phienban.MinimumWidth = 8;
            this.phienban.Name = "phienban";
            this.phienban.Width = 150;
            // 
            // dongco
            // 
            this.dongco.HeaderText = "Động cơ";
            this.dongco.MinimumWidth = 8;
            this.dongco.Name = "dongco";
            this.dongco.Width = 150;
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 8;
            this.gia.Name = "gia";
            this.gia.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 537);
            this.Controls.Add(this.dataXe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtDongCo);
            this.Controls.Add(this.txtPhienBan);
            this.Controls.Add(this.txtDongXe);
            this.Controls.Add(this.txtHangXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHangXe;
        private System.Windows.Forms.TextBox txtDongXe;
        private System.Windows.Forms.TextBox txtPhienBan;
        private System.Windows.Forms.TextBox txtDongCo;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn phienban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongco;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}

