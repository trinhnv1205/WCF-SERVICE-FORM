using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Service;

namespace WCF_Form
{
    public partial class NhanVien : Form
    {
        // service
        ServiceWCF _service = new ServiceWCF();

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}
