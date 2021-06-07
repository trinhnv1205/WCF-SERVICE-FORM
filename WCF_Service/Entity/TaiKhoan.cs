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
    
    public class TaiKhoan : EntityBase
    {
        [IsTableKeyAttr(false)]
        
        public string TenTK { get; set; }
        
        public string MK { get; set; }
        
        public string CV { get; set; }
        
        public string Fullname { get; set; }
    }
}
