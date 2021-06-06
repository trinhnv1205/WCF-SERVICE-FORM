using SVService.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Entity
{
    [TableNameAttr("SP")]
    [DataContract]
    public class SanPham : EntityBase
    {
        [IsTableKeyAttr(false)]
        [DataMember]
        public string MaSP { get; set; }
        [DataMember]
        public string TenSP { get; set; }
        [DataMember]
        public string MaNCC { get; set; }
        [DataMember]
        public int Soluong { get; set; }
        [DataMember]
        public int Gia { get; set; }
        [DataMember]
        public string Ghichu { get; set; }
    }
}
