namespace WindowsForms1
{
    partial class SanPham
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(277, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 22);
            this.textBox4.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Số lượng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 22);
            this.textBox3.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ghi chú";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MaNCC,
            this.SoLuong,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(17, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 248);
            this.dataGridView1.TabIndex = 51;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.FillWeight = 150F;
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 180;
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 180;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 34);
            this.button3.TabIndex = 50;
            this.button3.Text = "Làm mới";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 34);
            this.button2.TabIndex = 49;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 47;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 22);
            this.textBox2.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(650, 67);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(139, 34);
            this.btnDangNhap.TabIndex = 43;
            this.btnDangNhap.Text = "Thêm";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(17, 145);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(230, 22);
            this.txtPass.TabIndex = 42;
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(17, 87);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(230, 22);
            this.txtTk.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "SẢN PHẨM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 109;
            this.label13.Text = "Tìm kiếm";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(352, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 30);
            this.button4.TabIndex = 108;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(17, 264);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(291, 22);
            this.textBox5.TabIndex = 107;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
    }
}