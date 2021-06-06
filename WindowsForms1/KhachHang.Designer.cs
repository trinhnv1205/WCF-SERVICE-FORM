namespace WindowsForms1
{
    partial class KhachHang
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
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Makhachhang,
            this.Tenkhachhang,
            this.Diachi,
            this.Sodienthoai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 199);
            this.dataGridView1.TabIndex = 47;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // Makhachhang
            // 
            this.Makhachhang.FillWeight = 150F;
            this.Makhachhang.HeaderText = "Mã khách Hàng";
            this.Makhachhang.MinimumWidth = 6;
            this.Makhachhang.Name = "Makhachhang";
            this.Makhachhang.Width = 180;
            // 
            // Tenkhachhang
            // 
            this.Tenkhachhang.HeaderText = "Tên khách hàng";
            this.Tenkhachhang.MinimumWidth = 6;
            this.Tenkhachhang.Name = "Tenkhachhang";
            this.Tenkhachhang.Width = 180;
            // 
            // Diachi
            // 
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 125;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.HeaderText = "Số điện thoại";
            this.Sodienthoai.MinimumWidth = 6;
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 34);
            this.button3.TabIndex = 46;
            this.button3.Text = "Làm mới";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 34);
            this.button2.TabIndex = 45;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(335, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 22);
            this.textBox2.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Địa chỉ";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(649, 103);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(139, 34);
            this.btnDangNhap.TabIndex = 39;
            this.btnDangNhap.Text = "Thêm";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 173);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(230, 22);
            this.txtPass.TabIndex = 38;
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(12, 103);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(230, 22);
            this.txtTk.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 109;
            this.label13.Text = "Tìm kiếm";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 30);
            this.button4.TabIndex = 108;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(291, 22);
            this.textBox3.TabIndex = 107;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
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
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodienthoai;
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
        private System.Windows.Forms.TextBox textBox3;
    }
}