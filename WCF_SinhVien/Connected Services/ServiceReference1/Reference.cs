﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_SinhVien.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SinhVien", Namespace="http://schemas.datacontract.org/2004/07/SVService")]
    [System.SerializableAttribute()]
    public partial class SinhVien : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HoTenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDSVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TuoiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DiaChi {
            get {
                return this.DiaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaChiField, value) != true)) {
                    this.DiaChiField = value;
                    this.RaisePropertyChanged("DiaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HoTen {
            get {
                return this.HoTenField;
            }
            set {
                if ((object.ReferenceEquals(this.HoTenField, value) != true)) {
                    this.HoTenField = value;
                    this.RaisePropertyChanged("HoTen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDSV {
            get {
                return this.IDSVField;
            }
            set {
                if ((this.IDSVField.Equals(value) != true)) {
                    this.IDSVField = value;
                    this.RaisePropertyChanged("IDSV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tuoi {
            get {
                return this.TuoiField;
            }
            set {
                if ((this.TuoiField.Equals(value) != true)) {
                    this.TuoiField = value;
                    this.RaisePropertyChanged("Tuoi");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Khoa", Namespace="http://schemas.datacontract.org/2004/07/SVService")]
    [System.SerializableAttribute()]
    public partial class Khoa : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DienThoaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDMaKhoaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenKhoaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DiaChi {
            get {
                return this.DiaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaChiField, value) != true)) {
                    this.DiaChiField = value;
                    this.RaisePropertyChanged("DiaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DienThoai {
            get {
                return this.DienThoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.DienThoaiField, value) != true)) {
                    this.DienThoaiField = value;
                    this.RaisePropertyChanged("DienThoai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDMaKhoa {
            get {
                return this.IDMaKhoaField;
            }
            set {
                if ((this.IDMaKhoaField.Equals(value) != true)) {
                    this.IDMaKhoaField = value;
                    this.RaisePropertyChanged("IDMaKhoa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenKhoa {
            get {
                return this.TenKhoaField;
            }
            set {
                if ((object.ReferenceEquals(this.TenKhoaField, value) != true)) {
                    this.TenKhoaField = value;
                    this.RaisePropertyChanged("TenKhoa");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService_SinhVien")]
    public interface IService_SinhVien {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Insert_SV", ReplyAction="http://tempuri.org/IService_SinhVien/Insert_SVResponse")]
        int Insert_SV(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Insert_SV", ReplyAction="http://tempuri.org/IService_SinhVien/Insert_SVResponse")]
        System.Threading.Tasks.Task<int> Insert_SVAsync(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Update_SV", ReplyAction="http://tempuri.org/IService_SinhVien/Update_SVResponse")]
        int Update_SV(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Update_SV", ReplyAction="http://tempuri.org/IService_SinhVien/Update_SVResponse")]
        System.Threading.Tasks.Task<int> Update_SVAsync(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Xoa_SV", ReplyAction="http://tempuri.org/IService_SinhVien/Xoa_SVResponse")]
        int Xoa_SV(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Xoa_SV", ReplyAction="http://tempuri.org/IService_SinhVien/Xoa_SVResponse")]
        System.Threading.Tasks.Task<int> Xoa_SVAsync(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Check_Dup", ReplyAction="http://tempuri.org/IService_SinhVien/Check_DupResponse")]
        int Check_Dup(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Check_Dup", ReplyAction="http://tempuri.org/IService_SinhVien/Check_DupResponse")]
        System.Threading.Tasks.Task<int> Check_DupAsync(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Search_SV", ReplyAction="http://tempuri.org/IService_SinhVien/Search_SVResponse")]
        WCF_SinhVien.ServiceReference1.SinhVien Search_SV(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/Search_SV", ReplyAction="http://tempuri.org/IService_SinhVien/Search_SVResponse")]
        System.Threading.Tasks.Task<WCF_SinhVien.ServiceReference1.SinhVien> Search_SVAsync(WCF_SinhVien.ServiceReference1.SinhVien sv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/GetListCombobox", ReplyAction="http://tempuri.org/IService_SinhVien/GetListComboboxResponse")]
        WCF_SinhVien.ServiceReference1.Khoa[] GetListCombobox();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/GetListCombobox", ReplyAction="http://tempuri.org/IService_SinhVien/GetListComboboxResponse")]
        System.Threading.Tasks.Task<WCF_SinhVien.ServiceReference1.Khoa[]> GetListComboboxAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/GetList", ReplyAction="http://tempuri.org/IService_SinhVien/GetListResponse")]
        WCF_SinhVien.ServiceReference1.SinhVien[] GetList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SinhVien/GetList", ReplyAction="http://tempuri.org/IService_SinhVien/GetListResponse")]
        System.Threading.Tasks.Task<WCF_SinhVien.ServiceReference1.SinhVien[]> GetListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_SinhVienChannel : WCF_SinhVien.ServiceReference1.IService_SinhVien, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_SinhVienClient : System.ServiceModel.ClientBase<WCF_SinhVien.ServiceReference1.IService_SinhVien>, WCF_SinhVien.ServiceReference1.IService_SinhVien {
        
        public Service_SinhVienClient() {
        }
        
        public Service_SinhVienClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_SinhVienClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_SinhVienClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_SinhVienClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Insert_SV(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Insert_SV(sv);
        }
        
        public System.Threading.Tasks.Task<int> Insert_SVAsync(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Insert_SVAsync(sv);
        }
        
        public int Update_SV(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Update_SV(sv);
        }
        
        public System.Threading.Tasks.Task<int> Update_SVAsync(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Update_SVAsync(sv);
        }
        
        public int Xoa_SV(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Xoa_SV(sv);
        }
        
        public System.Threading.Tasks.Task<int> Xoa_SVAsync(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Xoa_SVAsync(sv);
        }
        
        public int Check_Dup(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Check_Dup(sv);
        }
        
        public System.Threading.Tasks.Task<int> Check_DupAsync(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Check_DupAsync(sv);
        }
        
        public WCF_SinhVien.ServiceReference1.SinhVien Search_SV(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Search_SV(sv);
        }
        
        public System.Threading.Tasks.Task<WCF_SinhVien.ServiceReference1.SinhVien> Search_SVAsync(WCF_SinhVien.ServiceReference1.SinhVien sv) {
            return base.Channel.Search_SVAsync(sv);
        }
        
        public WCF_SinhVien.ServiceReference1.Khoa[] GetListCombobox() {
            return base.Channel.GetListCombobox();
        }
        
        public System.Threading.Tasks.Task<WCF_SinhVien.ServiceReference1.Khoa[]> GetListComboboxAsync() {
            return base.Channel.GetListComboboxAsync();
        }
        
        public WCF_SinhVien.ServiceReference1.SinhVien[] GetList() {
            return base.Channel.GetList();
        }
        
        public System.Threading.Tasks.Task<WCF_SinhVien.ServiceReference1.SinhVien[]> GetListAsync() {
            return base.Channel.GetListAsync();
        }
    }
}