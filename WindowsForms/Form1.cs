using System;
using System.ComponentModel;
using System.Windows.Forms;
//Khai báo Service
using WindowsForms.ServiceReference1;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceClient taikhoan = new ServiceClient();

        private void DongForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan()

            {
                TenTK = "Ad1",
                MK = "123456",

            };
            if (taikhoan.DangNhapTK(tk) == 1)
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
                /*Main GiaoDienChinh = new Main();
                GiaoDienChinh.FormClosed += new FormClosedEventHandler(DongForm);
                this.Hide();
                GiaoDienChinh.Show();*/

            }
            else
            {
                {
                    MessageBox.Show("Sai Tk hoặc Pass, mời nhập lại");
                    txtTk.Focus();
                }
            }
        }
    }
}
