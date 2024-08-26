namespace WeatherApp
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
            this.txtMaKV = new System.Windows.Forms.TextBox();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.txtDoAm = new System.Windows.Forms.TextBox();
            this.dataThoiTiet = new System.Windows.Forms.DataGridView();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataThoiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khu vực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhiệt độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Độ ẩm";
            // 
            // txtMaKV
            // 
            this.txtMaKV.Location = new System.Drawing.Point(162, 33);
            this.txtMaKV.Name = "txtMaKV";
            this.txtMaKV.Size = new System.Drawing.Size(178, 26);
            this.txtMaKV.TabIndex = 4;
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(162, 109);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(239, 26);
            this.txtGio.TabIndex = 5;
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(565, 33);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(166, 26);
            this.txtNhietDo.TabIndex = 6;
            // 
            // txtDoAm
            // 
            this.txtDoAm.Location = new System.Drawing.Point(565, 109);
            this.txtDoAm.Name = "txtDoAm";
            this.txtDoAm.Size = new System.Drawing.Size(166, 26);
            this.txtDoAm.TabIndex = 7;
            // 
            // dataThoiTiet
            // 
            this.dataThoiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThoiTiet.Location = new System.Drawing.Point(59, 177);
            this.dataThoiTiet.Name = "dataThoiTiet";
            this.dataThoiTiet.RowHeadersWidth = 62;
            this.dataThoiTiet.RowTemplate.Height = 28;
            this.dataThoiTiet.Size = new System.Drawing.Size(672, 192);
            this.dataThoiTiet.TabIndex = 8;
            this.dataThoiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThoiTiet_CellClick);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(245, 388);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(95, 38);
            this.btnHienThi.TabIndex = 9;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(363, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 38);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(495, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 38);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dataThoiTiet);
            this.Controls.Add(this.txtDoAm);
            this.Controls.Add(this.txtNhietDo);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.txtMaKV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataThoiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKV;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.TextBox txtDoAm;
        private System.Windows.Forms.DataGridView dataThoiTiet;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}

