using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using SVService.App_Data;
namespace SVService.Entity
{
    [TableNameAttr("NHANVIEN")]
    [DataContract]
    public class NhanVien: EntityBase
    {
        [IsTableKeyAttr(false)]
        [DataMember]
        public string MaNV { get; set; }
        [DataMember]
        public string Hoten { get; set; }
        [DataMember]
        public string Ngaysinh { get; set; }
        [DataMember]
        public string Diachi { get; set; }
        [DataMember]
        public string Sdt { get; set; }
        [DataMember]
        public string Chucvu { get; set; }
        [DataMember]
        public int Luongcb { get; set; }
        [DataMember]
        public int Phucap { get; set; }
        [DataMember]
        public int thuong { get; set; }
        [DataMember]
        public int Luong { get; set; }
    }   
}       
        
        
        
        
        
        
        