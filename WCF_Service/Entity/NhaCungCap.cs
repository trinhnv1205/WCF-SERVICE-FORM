using SVService.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Entity
{
    [TableNameAttr("NCC")]
    [DataContract]
    public class NhaCungCap : EntityBase
    {
        [IsTableKeyAttr(false)]
        [DataMember]
        public string MaNCC { get; set; }
        [DataMember]
        public string TenNCC { get; set; }
        [DataMember]
        public string Diachi { get; set; }
        [DataMember]
        public string Sdt { get; set; }
    }
}
