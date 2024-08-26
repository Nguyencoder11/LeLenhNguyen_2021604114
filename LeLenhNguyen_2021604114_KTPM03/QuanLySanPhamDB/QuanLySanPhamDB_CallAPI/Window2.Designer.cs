namespace QuanLySanPhamDB_CallAPI
{
    partial class Window2
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
            this.dataMoreThanFive = new System.Windows.Forms.DataGridView();
            this.btnTurnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoreThanFive)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SẢN PHẨM CÓ SỐ LƯỢNG > 5";
            // 
            // dataMoreThanFive
            // 
            this.dataMoreThanFive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMoreThanFive.Location = new System.Drawing.Point(27, 114);
            this.dataMoreThanFive.Name = "dataMoreThanFive";
            this.dataMoreThanFive.RowHeadersWidth = 62;
            this.dataMoreThanFive.RowTemplate.Height = 28;
            this.dataMoreThanFive.Size = new System.Drawing.Size(750, 229);
            this.dataMoreThanFive.TabIndex = 1;
            // 
            // btnTurnBack
            // 
            this.btnTurnBack.Location = new System.Drawing.Point(27, 380);
            this.btnTurnBack.Name = "btnTurnBack";
            this.btnTurnBack.Size = new System.Drawing.Size(120, 46);
            this.btnTurnBack.TabIndex = 2;
            this.btnTurnBack.Text = "Back";
            this.btnTurnBack.UseVisualStyleBackColor = true;
            this.btnTurnBack.Click += new System.EventHandler(this.btnTurnBack_Click);
            // 
            // Window2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTurnBack);
            this.Controls.Add(this.dataMoreThanFive);
            this.Controls.Add(this.label1);
            this.Name = "Window2";
            this.Text = "Window2";
            ((System.ComponentModel.ISupportInitialize)(this.dataMoreThanFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataMoreThanFive;
        private System.Windows.Forms.Button btnTurnBack;
    }
}