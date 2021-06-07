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
    
    public class NhaCungCap : EntityBase
    {
        [IsTableKeyAttr(false)]
        
        public string MaNCC { get; set; }
        
        public string TenNCC { get; set; }
        
        public string Diachi { get; set; }
        
        public string Sdt { get; set; }
    }
}
