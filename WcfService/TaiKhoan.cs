using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Khai báo thêm
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class TaiKhoan
    {
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
