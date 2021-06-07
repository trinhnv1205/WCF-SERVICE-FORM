using SVService.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Entity
{
    [TableNameAttr("NHAPSP")]
    
    public class NhapSanPham :EntityBase
    {
        [IsTableKeyAttr(true)]
        
        public int ID { get; set; }
        
        public string MaPhieu { get; set; }
        
        public string MaSP { get; set; }
        
        public string TenSP { get; set; }
        
        public string MaNCC { get; set; }
        
        public string Ngaynhap { get; set; }
        
        public int Soluong { get; set; }
        
        public int Gianhap { get; set; }
        
        public int Thanhtien { get; set; }
        
        public string Ghichu { get; set; }
    }
}
