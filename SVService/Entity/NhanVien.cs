using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVService.App_Data;
namespace SVService.Entity
{
    [TableNameAttr("NHANVIEN")]
    public class NhanVien: EntityBase
    {
        [IsTableKeyAttr(true)]
        public string MaNV { get; set; }
        public string Hoten { get; set; }
        public string Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }
        public string Chucvu { get; set; }
        public int Luongcb { get; set; }
        public int Phucap { get; set; }
        public int thuong { get; set; }
        public int Luong { get; set; }
    }   
}       
        
        
        
        
        
        
        