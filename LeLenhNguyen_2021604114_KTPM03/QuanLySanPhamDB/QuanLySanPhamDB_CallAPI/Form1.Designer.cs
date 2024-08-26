namespace QuanLySanPhamDB_CallAPI
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtSlBan = new System.Windows.Forms.TextBox();
            this.txtTienban = new System.Windows.Forms.TextBox();
            this.cboNH = new System.Windows.Forms.ComboBox();
            this.dataSanpham = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnWindow2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhóm hàng";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(172, 29);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(201, 26);
            this.txtMaSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(172, 88);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(201, 26);
            this.txtTenSP.TabIndex = 7;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(172, 149);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(201, 26);
            this.txtDongia.TabIndex = 8;
            // 
            // txtSlBan
            // 
            this.txtSlBan.Location = new System.Drawing.Point(684, 29);
            this.txtSlBan.Name = "txtSlBan";
            this.txtSlBan.Size = new System.Drawing.Size(201, 26);
            this.txtSlBan.TabIndex = 9;
            // 
            // txtTienban
            // 
            this.txtTienban.Location = new System.Drawing.Point(684, 88);
            this.txtTienban.Name = "txtTienban";
            this.txtTienban.Size = new System.Drawing.Size(201, 26);
            this.txtTienban.TabIndex = 10;
            // 
            // cboNH
            // 
            this.cboNH.FormattingEnabled = true;
            this.cboNH.Location = new System.Drawing.Point(684, 149);
            this.cboNH.Name = "cboNH";
            this.cboNH.Size = new System.Drawing.Size(201, 28);
            this.cboNH.TabIndex = 11;
            // 
            // dataSanpham
            // 
            this.dataSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSanpham.Location = new System.Drawing.Point(40, 234);
            this.dataSanpham.Name = "dataSanpham";
            this.dataSanpham.RowHeadersWidth = 62;
            this.dataSanpham.RowTemplate.Height = 28;
            this.dataSanpham.Size = new System.Drawing.Size(845, 203);
            this.dataSanpham.TabIndex = 12;
            this.dataSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSanpham_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(213, 480);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 37);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(339, 480);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 37);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(465, 480);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 37);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnWindow2
            // 
            this.btnWindow2.Location = new System.Drawing.Point(618, 480);
            this.btnWindow2.Name = "btnWindow2";
            this.btnWindow2.Size = new System.Drawing.Size(105, 37);
            this.btnWindow2.TabIndex = 16;
            this.btnWindow2.Text = "Window2";
            this.btnWindow2.UseVisualStyleBackColor = true;
            this.btnWindow2.Click += new System.EventHandler(this.btnWindow2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 557);
            this.Controls.Add(this.btnWindow2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataSanpham);
            this.Controls.Add(this.cboNH);
            this.Controls.Add(this.txtTienban);
            this.Controls.Add(this.txtSlBan);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtSlBan;
        private System.Windows.Forms.TextBox txtTienban;
        private System.Windows.Forms.ComboBox cboNH;
        private System.Windows.Forms.DataGridView dataSanpham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnWindow2;
    }
}

