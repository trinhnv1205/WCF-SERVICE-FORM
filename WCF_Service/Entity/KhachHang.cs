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
    
    public class KhachHang : EntityBase
    {
        [IsTableKeyAttr(false)]
        
        public string MaKH { get; set; }
        
        public string TenKH { get; set; }
        
        public string Diachi { get; set; }
        
        public string Sdt { get; set; }
    }
}
