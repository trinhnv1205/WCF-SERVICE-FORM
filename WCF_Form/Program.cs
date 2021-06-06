using System;
using System.Windows.Forms;
using WCF_Form;

namespace WCF_SinhVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NhanVien());
        }
    }
}
