using SVService.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Entity
{
    [TableNameAttr("BANHANG")]
    
    public class BanHang : EntityBase
    {
        [IsTableKeyAttr(true)]
        
        public int ID { get; set; }
        
        public string MaHD { get; set; }
        
        public string MaSP { get; set; }
        
        public string TenSP { get; set; }
        
        public string MaKH { get; set; }
        
        public string MaNCC { get; set; }
        
        public string Ngayban { get; set; }
        
        public int Soluong { get; set; }
        
        public int Gia { get; set; }
        
        public string Ghichu { get; set; }
        
        public int Thanhtien { get; set; }
    }
}
