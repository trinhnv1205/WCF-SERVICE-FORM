using SVService.App_Data;
using SVService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Service.Entity;

namespace WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceWCF" in both code and config file together.
    public class ServiceWCF : IServiceWCF
    {
        // db
        DbAccess dbAccess = new DbAccess();

        public void DeleteBH(BanHang bh)
        {
            dbAccess.ExecuteQuery(bh.GetBaseDeleteSql(), bh.GetParamDataTable());
        }

        public void InsertBH(BanHang bh)
        {
            dbAccess.ExecuteQuery(bh.GetBaseInsertSql(), bh.GetParamDataTable());
        }

        public void UpdateBH(BanHang bh)
        {
            dbAccess.ExecuteQuery(bh.GetBaseUpdateSql(), bh.GetParamDataTable());
        }

        public List<BanHang> GetAllBH()
        {
            return ConvertUtil.ConvertToList<BanHang>(dbAccess.Select("select * from BANHANG"));
        }

        public void InsertKH(KhachHang kh)
        {
            dbAccess.ExecuteQuery(kh.GetBaseInsertSql(), kh.GetParamDataTable());
        }

        public void UpdateKH(KhachHang kh)
        {
            dbAccess.ExecuteQuery(kh.GetBaseUpdateSql(), kh.GetParamDataTable());
        }

        public void DeleteKH(KhachHang kh)
        {
            dbAccess.ExecuteQuery(kh.GetBaseDeleteSql(), kh.GetParamDataTable());
        }

        public List<KhachHang> GetAllKH()
        {
            return ConvertUtil.ConvertToList<KhachHang>(dbAccess.Select("select * from KHACHHANG"));
        }

        public void InsertNCC(NhaCungCap ncc)
        {
            dbAccess.ExecuteQuery(ncc.GetBaseInsertSql(), ncc.GetParamDataTable());
        }

        public void UpdateNCC(NhaCungCap ncc)
        {
            dbAccess.ExecuteQuery(ncc.GetBaseUpdateSql(), ncc.GetParamDataTable());
        }

        public void DeleteNCC(NhaCungCap ncc)
        {
            dbAccess.ExecuteQuery(ncc.GetBaseDeleteSql(), ncc.GetParamDataTable());
        }

        public List<NhaCungCap> GetAllNCC()
        {
            return ConvertUtil.ConvertToList<NhaCungCap>(dbAccess.Select("select * from NCC"));
        }

        public void InsertNV(NhanVien nv)
        {
            dbAccess.ExecuteQuery(nv.GetBaseInsertSql(), nv.GetParamDataTable());
        }

        public void UpdateNV(NhanVien nv)
        {
            dbAccess.ExecuteQuery(nv.GetBaseUpdateSql(), nv.GetParamDataTable());
        }

        public void DeleteNV(NhanVien nv)
        {
            dbAccess.ExecuteQuery(nv.GetBaseDeleteSql(), nv.GetParamDataTable());
        }

        public List<NhanVien> GetAllNV()
        {
            return ConvertUtil.ConvertToList<NhanVien>(dbAccess.Select("select * from NHANVIEN"));
        }

        public void InsertNSP(NhapSanPham nsp)
        {
            dbAccess.ExecuteQuery(nsp.GetBaseInsertSql(), nsp.GetParamDataTable());
        }

        public void UpdateNSP(NhapSanPham nsp)
        {
            dbAccess.ExecuteQuery(nsp.GetBaseUpdateSql(), nsp.GetParamDataTable());
        }

        public void DeleteNSP(NhapSanPham nsp)
        {
            dbAccess.ExecuteQuery(nsp.GetBaseDeleteSql(), nsp.GetParamDataTable());
        }

        public List<NhapSanPham> GetAllNSP()
        {
            return ConvertUtil.ConvertToList<NhapSanPham>(dbAccess.Select("select * from NHAPSP"));
        }

        public void InsertSP(SanPham sp)
        {
            dbAccess.ExecuteQuery(sp.GetBaseInsertSql(), sp.GetParamDataTable());
        }

        public void UpdateSP(SanPham sp)
        {
            dbAccess.ExecuteQuery(sp.GetBaseUpdateSql(), sp.GetParamDataTable());
        }

        public void DeleteSP(SanPham sp)
        {
            dbAccess.ExecuteQuery(sp.GetBaseDeleteSql(), sp.GetParamDataTable());
        }

        public List<SanPham> GetAllSP()
        {
            return ConvertUtil.ConvertToList<SanPham>(dbAccess.Select("select * from SP"));
        }

        public void InsertTK(TaiKhoan tk)
        {
            dbAccess.ExecuteQuery(tk.GetBaseInsertSql(), tk.GetParamDataTable());
        }

        public void UpdateTK(TaiKhoan tk)
        {
            dbAccess.ExecuteQuery(tk.GetBaseUpdateSql(), tk.GetParamDataTable());
        }

        public void DeleteTK(TaiKhoan tk)
        {
            dbAccess.ExecuteQuery(tk.GetBaseDeleteSql(), tk.GetParamDataTable());
        }

        public List<TaiKhoan> GetAllTK()
        {
            return ConvertUtil.ConvertToList<TaiKhoan>(dbAccess.Select("select * from TAIKHOAN"));
        }
    }
}
