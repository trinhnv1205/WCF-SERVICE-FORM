using SVService.App_Data;
using SVService.Entity;
using System;
using System.Collections.Generic;

//Khai báo
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SVService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_SinhVien" in both code and config file together.
    public class Service_SinhVien : IService_SinhVien
    {
        DbAccess dbAccess = new DbAccess(); // db

        SqlConnection conn;
        SqlCommand cmd;

        void ConnectDB()
        {
            string chuoi = @"Data Source=DESKTOP-C1K7M6O\SQLEXPRESS;Initial Catalog=QLSV_WCF;Integrated Security=True";
            conn = new SqlConnection(chuoi);
            cmd = conn.CreateCommand();
        }

        public int Insert_SV(SinhVien sv)
        
        {
            try
            {
                
                {
                    cmd.CommandText = "insert into t_sinhvien values(@IDSV, @HoTen,@DiaChi,@Tuoi)";
                    cmd.Parameters.AddWithValue("IDSV", sv.IDSV);
                    cmd.Parameters.AddWithValue("HoTen", sv.HoTen);
                    cmd.Parameters.AddWithValue("DiaChi", sv.DiaChi);
                    cmd.Parameters.AddWithValue("Tuoi", sv.Tuoi);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                
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

        public List<SinhVien> GetList()
        {
            List<SinhVien> SV_L = new List<SinhVien>();
            try
            {
                cmd.CommandText = "Select IDSV,HoTen,DiaChi,Tuoi from t_sinhvien";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SinhVien sinhVien = new SinhVien()
                    {
                        IDSV = Convert.ToInt32(dr[0]),
                        HoTen = dr[1].ToString(),
                        DiaChi = dr[2].ToString(),
                        Tuoi = Convert.ToInt32(dr[3])
                    };
                    SV_L.Add(sinhVien);

                };

                return SV_L;
            }

            catch (Exception ex)
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

        public int Update_SV(SinhVien sv)
        {
            try
            {
                cmd.CommandText = "Update t_sinhvien set Hoten=@HoTen,DiaChi=@DiaChi,Tuoi=@Tuoi where IDSV=@IDSV";
                cmd.Parameters.AddWithValue("IDSV", sv.IDSV);
                cmd.Parameters.AddWithValue("HoTen", sv.HoTen);
                cmd.Parameters.AddWithValue("DiaChi", sv.DiaChi);
                cmd.Parameters.AddWithValue("Tuoi", sv.Tuoi);


                cmd.CommandType = CommandType.Text;
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch
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

        public SinhVien Search_SV(SinhVien sv)
        {
            SinhVien sinhVien = new SinhVien();
            try
            {
                cmd.CommandText = "Select * from t_sinhvien where IDSV=@IDSV";
                cmd.Parameters.AddWithValue("IDSV", sv.IDSV);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sinhVien.IDSV = Convert.ToInt32(dr[0]);
                    sinhVien.HoTen = dr[1].ToString();
                    sinhVien.DiaChi = dr[2].ToString();
                    sinhVien.Tuoi = Convert.ToInt32(dr[3]);

                }

                return sinhVien;
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

        public int Xoa_SV(SinhVien sv)
        {
            try
            {
                cmd.CommandText = "delete from t_sinhvien where idsv=@idsv ";
                cmd.Parameters.AddWithValue("IDSV", sv.IDSV); ;
                cmd.CommandType = CommandType.Text;
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch
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

        public int Check_Dup(SinhVien sv)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM t_sinhvien WHERE IDSV=@IDSV";
                cmd.Parameters.AddWithValue("IDSV", sv.IDSV);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch(Exception)
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

        public List<Khoa> GetListCombobox()
        {
            List<Khoa> Khoa_L = new List<Khoa>();
            try
            {
                cmd.CommandText = "select * from t_khoa";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Khoa khoa = new Khoa()
                    {
                       IDMaKhoa = Convert.ToInt32(dr[0]),
                       TenKhoa = dr[1].ToString(),
                       DiaChi = dr[2].ToString(),
                       DienThoai = dr[3].ToString(),
                       Email = dr[4].ToString(),
                    };
                    Khoa_L.Add(khoa);
                };

                return Khoa_L;
            }

            catch (Exception ex)
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

        public int them_nv(NhanVien nhanVien)
        {
            return dbAccess.ExecuteQuery(nhanVien.GetBaseInsertSql(), nhanVien.GetParamDataTable());
        }

        public int sua_nv(NhanVien nhanVien)
        {
            return dbAccess.ExecuteQuery(nhanVien.GetBaseUpdateSql(), nhanVien.GetParamDataTable());
        }

        public int xoa_nv(NhanVien nhanVien)
        {
            return dbAccess.ExecuteQuery(nhanVien.GetBaseDeleteSql(), nhanVien.GetParamDataTable());
        }

        public DataSet GetListNhanVien()
        {
            List<HoaDonExt> getAllNhanVien = ConvertUtil.ConvertToList<HoaDonExt>(dbAccess.Select("select * from NHANVIEN m1 inner join BanHang m2 on m1.maNV = m2.maNV"));
            NhanVien nhanVien = new NhanVien();
            var check = getAllNhanVien.Single(s => s.MaNV == nhanVien.MaNV);
            throw new NotImplementedException();
        }

        //Ham Tao
        public Service_SinhVien()
        {
            ConnectDB();
        }
    }
}
