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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface IServiceWCF
    {
        /// <summary>
        /// ban hang
        /// </summary>
        /// <param name="bh"></param>
        [OperationContract]
        void InsertBH(BanHang bh);

        [OperationContract]
        void UpdateBH(BanHang bh);

        [OperationContract]
        void DeleteBH(BanHang bh);

        [OperationContract]
        List<BanHang> GetAllBH();

        /// <summary>
        /// khach hang
        /// </summary>
        /// <param name="bh"></param>
        [OperationContract]
        void InsertKH(KhachHang kh);

        [OperationContract]
        void UpdateKH(KhachHang kh);

        [OperationContract]
        void DeleteKH(KhachHang kh);

        [OperationContract]
        List<KhachHang> GetAllKH();

        /// <summary>
        /// nha cung cap
        /// </summary>
        /// <param name="ncc"></param>
        [OperationContract]
        void InsertNCC(NhaCungCap ncc);

        [OperationContract]
        void UpdateNCC(NhaCungCap ncc);

        [OperationContract]
        void DeleteNCC(NhaCungCap ncc);

        [OperationContract]
        List<NhaCungCap> GetAllNCC();

        /// <summary>
        /// nhan vien
        /// </summary>
        /// <param name="nv"></param>
        [OperationContract]
        void InsertNV(NhanVien nv);

        [OperationContract]
        void UpdateNV(NhanVien nv);

        [OperationContract]
        void DeleteNV(NhanVien nv);

        [OperationContract]
        List<NhanVien> GetAllNV();

        /// <summary>
        /// nhap san pham
        /// </summary>
        /// <param name="nsp"></param>
        [OperationContract]
        void InsertNSP(NhapSanPham nsp);

        [OperationContract]
        void UpdateNSP(NhapSanPham nsp);

        [OperationContract]
        void DeleteNSP(NhapSanPham nsp);

        [OperationContract]
        List<NhapSanPham> GetAllNSP();

        /// <summary>
        /// nhap san pham
        /// </summary>
        /// <param name="sp"></param>
        [OperationContract]
        void InsertSP(SanPham sp);

        [OperationContract]
        void UpdateSP(SanPham sp);

        [OperationContract]
        void DeleteSP(SanPham sp);

        [OperationContract]
        List<SanPham> GetAllSP();

        /// <summary>
        /// tai khoan
        /// </summary>
        /// <param name="tk"></param>
        [OperationContract]
        void InsertTK(TaiKhoan tk);

        [OperationContract]
        void UpdateTK(TaiKhoan tk);

        [OperationContract]
        void DeleteTK(TaiKhoan tk);

        [OperationContract]
        List<TaiKhoan> GetAllTK();
    }
}
