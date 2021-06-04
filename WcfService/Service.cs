using System;
using System.Collections.Generic;

//Khai báo
using System.Data;
using System.Data.SqlClient;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in both code and config file together.
    public class Service : IService
    {
        SqlConnection conn;
        SqlCommand cmd;
        void ConnectDB()
        {
            string chuoi = @"Data Source=DESKTOP-C1K7M6O\SQLEXPRESS;Initial Catalog=QLsieuthi;Integrated Security=True";
            conn = new SqlConnection(chuoi);
            cmd = conn.CreateCommand();
        }
        public int DangNhapTK(TaiKhoan tk)
        {
            try
            {
                cmd.CommandText = "Select count(*) from TaiKhoan where TenTK = @TenTK and MK = @Pass";
                cmd.Parameters.AddWithValue("TenTK", tk.TenTK);
                cmd.Parameters.AddWithValue("Pass", tk.MK);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public Service()
        {
            ConnectDB();
        }
    }
}

