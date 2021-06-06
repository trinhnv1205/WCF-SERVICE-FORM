using SVService.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Entity
{
    [TableNameAttr("KHACHHANG")]
    [DataContract]
    public class KhachHang : EntityBase
    {
        [IsTableKeyAttr(false)]
        [DataMember]
        public string MaKH { get; set; }
        [DataMember]
        public string TenKH { get; set; }
        [DataMember]
        public string Diachi { get; set; }
        [DataMember]
        public string Sdt { get; set; }
    }
}
