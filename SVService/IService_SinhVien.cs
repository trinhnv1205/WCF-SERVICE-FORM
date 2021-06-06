using SVService.Entity;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
namespace SVService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_SinhVien" in both code and config file together.
    [ServiceContract]
    public interface IService_SinhVien
    {
        [OperationContract]
        int Insert_SV(SinhVien sv);

        [OperationContract]
        int Update_SV(SinhVien sv);

        [OperationContract]
        int Xoa_SV(SinhVien sv);

        [OperationContract]
        int Check_Dup(SinhVien sv);

        [OperationContract]
        SinhVien Search_SV(SinhVien sv);

        [OperationContract]
        List<Khoa> GetListCombobox();

        [OperationContract]
        List<SinhVien> GetList();


        //Xu ly bang nhan vien
        [OperationContract]
        int them_nv(NhanVien nhanVien);

        [OperationContract]
        int sua_nv(NhanVien nhanVien);

        [OperationContract]
        int xoa_nv(NhanVien nhanVien);

        [OperationContract]
        DataSet GetListNhanVien();
    }
}
