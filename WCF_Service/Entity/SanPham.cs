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
    
    public class SanPham : EntityBase
    {
        [IsTableKeyAttr(false)]
        
        public string MaSP { get; set; }
        
        public string TenSP { get; set; }
        
        public string MaNCC { get; set; }
        
        public int Soluong { get; set; }
        
        public int Gia { get; set; }
        
        public string Ghichu { get; set; }
    }
}
