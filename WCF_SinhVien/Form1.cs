using System;
using System.Collections.Generic;
using System.Windows.Forms;
//Khai báo Service
using WCF_SinhVien.ServiceReference1;


namespace WCF_SinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Khai báo
        Service_SinhVienClient sinhvien = new Service_SinhVienClient();
        Service_SinhVienClient khoa = new Service_SinhVienClient();
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien()

            {
                IDSV = Convert.ToInt32(txtID.Text),
                HoTen = txtHoTen.Text,
                DiaChi = txtDiaChi.Text,
                Tuoi = Convert.ToInt32(txtTuoi.Text)

            };       
            if (sinhvien.Check_Dup(sv) == 1)
            {
                MessageBox.Show("Trung ma!");
                txtID.Focus();
            }
            else
            {
                if (sinhvien.Insert_SV(sv) == 1)
                {
                    Clear_All();
                    View_All();
                    MessageBox.Show("Thành công");
                }

            }     
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien()
            {
                IDSV = Convert.ToInt32(txtID.Text),
                HoTen = txtHoTen.Text,
                DiaChi = txtHoTen.Text,
                Tuoi = Convert.ToInt32(txtTuoi.Text),
            };
            if (sinhvien.Update_SV(sv) == 1)
            {
                Clear_All();
                View_All();
                MessageBox.Show("Thành công");
            }
        }
        private void Clear_All()
        {
            txtID.Clear();
            txtHoTen.Clear();
            txtTuoi.Clear();
            txtDiaChi.Clear();
        }
        void View_All()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sinhvien.GetList();
            foreach (var k in khoa.GetListCombobox())
            {
                /*  comboBox1.Text = k.IDMaKhoa.ToString();*/
                comboBox1.Items.Add(k.TenKhoa);
        }
    }
        private void Form1_Load(object sender, EventArgs e)
        {
            View_All();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i=0; i<dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["IDSV"].Value.ToString();
            txtHoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtTuoi.Text = dataGridView1.CurrentRow.Cells["Tuoi"].Value.ToString();
            txtID.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==0)
            {
                View_All();
            }
            else
            {
                List<SinhVien> SV_L = new List<SinhVien>();
                SinhVien sv = new SinhVien()
                {
                    IDSV = Convert.ToInt32(textBox1.Text)
                };
                SV_L.Add(sinhvien.Search_SV(sv));
                dataGridView1.DataSource = SV_L;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Clear_All();
            comboBox1.Items.Clear();
            textBox1.Clear();
            txtID.Enabled = true;
            View_All();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập cần xóa");
            }
            else
            {
                SinhVien sv = new SinhVien()
                {
                    IDSV = Convert.ToInt32(txtID.Text),
                };
                {
                    DialogResult Yes = MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Yes == DialogResult.Yes)
                        if (sinhvien.Xoa_SV(sv) == 1)
                        {
                            Clear_All();
                            View_All();

                        }
                }
            }
        }
    }
}
