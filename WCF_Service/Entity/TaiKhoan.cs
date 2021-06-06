using SVService.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Entity
{
    [TableNameAttr("TAIKHOAN")]
    [DataContract]
    public class TaiKhoan : EntityBase
    {
        [IsTableKeyAttr(false)]
        [DataMember]
        public string TenTK { get; set; }
        [DataMember]
        public string MK { get; set; }
        [DataMember]
        public string CV { get; set; }
        [DataMember]
        public string Fullname { get; set; }
    }
}
