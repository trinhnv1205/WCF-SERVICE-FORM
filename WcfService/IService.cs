﻿using System.Collections.Generic;
using System.ServiceModel;
namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        //Dang Nhap Tai Khoan
        [OperationContract]
        int DangNhapTK(TaiKhoan tk);
    }
}
