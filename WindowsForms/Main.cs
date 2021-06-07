using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHangF khachHang = new KhachHangF();
            khachHang.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVienF khachHang = new NhanVienF();
            khachHang.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPhamF khachHang = new SanPhamF();
            khachHang.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapSPF khachHang = new NhapSPF();
            khachHang.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCCF khachHang = new NhaCCF();
            khachHang.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHangF khachHang = new BanHangF();
            khachHang.Show();
        }
    }
}
