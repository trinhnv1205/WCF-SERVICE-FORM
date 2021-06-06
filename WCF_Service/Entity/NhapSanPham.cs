using SVService.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Entity
{
    [TableNameAttr("NHAPSP")]
    [DataContract]
    public class NhapSanPham :EntityBase
    {
        [IsTableKeyAttr(false)]
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string MaPhieu { get; set; }
        [DataMember]
        public string MaSP { get; set; }
        [DataMember]
        public string TenSP { get; set; }
        [DataMember]
        public string MaNCC { get; set; }
        [DataMember]
        public string Ngaynhap { get; set; }
        [DataMember]
        public int Soluong { get; set; }
        [DataMember]
        public int Gianhap { get; set; }
        [DataMember]
        public int Thanhtien { get; set; }
        [DataMember]
        public string Ghichu { get; set; }
    }
}
