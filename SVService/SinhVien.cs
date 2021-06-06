//Khai báo thêm
using System.Runtime.Serialization;

namespace SVService
{
    [DataContract]
    public class SinhVien
    {
        [DataMember]
        public int IDSV { get; set; }

        [DataMember]
        public string HoTen { get; set; }

        [DataMember]
        public string DiaChi { get; set; }

        [DataMember]
        public int Tuoi { get; set; }

    }
    public class Khoa
    {
        [DataMember]
        public int IDMaKhoa { get; set; }

        [DataMember]
        public string TenKhoa { get; set; }

        [DataMember]
        public string DiaChi { get; set; }

        [DataMember]
        public string DienThoai { get; set; }

        [DataMember]
        public string Email { get; set; }

    }
}
