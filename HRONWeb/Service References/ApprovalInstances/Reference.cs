﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRONWeb.ApprovalInstances {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WFApprovals", Namespace="http://schemas.datacontract.org/2004/07/HRONLib")]
    [System.SerializableAttribute()]
    public partial class WFApprovals : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> approvedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string approverActivityIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid approverWFIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string bodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> endtimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime starttimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string subjectField;
        
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
        public System.Nullable<bool> approved {
            get {
                return this.approvedField;
            }
            set {
                if ((this.approvedField.Equals(value) != true)) {
                    this.approvedField = value;
                    this.RaisePropertyChanged("approved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string approverActivityID {
            get {
                return this.approverActivityIDField;
            }
            set {
                if ((object.ReferenceEquals(this.approverActivityIDField, value) != true)) {
                    this.approverActivityIDField = value;
                    this.RaisePropertyChanged("approverActivityID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid approverWFID {
            get {
                return this.approverWFIDField;
            }
            set {
                if ((this.approverWFIDField.Equals(value) != true)) {
                    this.approverWFIDField = value;
                    this.RaisePropertyChanged("approverWFID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string body {
            get {
                return this.bodyField;
            }
            set {
                if ((object.ReferenceEquals(this.bodyField, value) != true)) {
                    this.bodyField = value;
                    this.RaisePropertyChanged("body");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> endtime {
            get {
                return this.endtimeField;
            }
            set {
                if ((this.endtimeField.Equals(value) != true)) {
                    this.endtimeField = value;
                    this.RaisePropertyChanged("endtime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mail {
            get {
                return this.mailField;
            }
            set {
                if ((object.ReferenceEquals(this.mailField, value) != true)) {
                    this.mailField = value;
                    this.RaisePropertyChanged("mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string note {
            get {
                return this.noteField;
            }
            set {
                if ((object.ReferenceEquals(this.noteField, value) != true)) {
                    this.noteField = value;
                    this.RaisePropertyChanged("note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime starttime {
            get {
                return this.starttimeField;
            }
            set {
                if ((this.starttimeField.Equals(value) != true)) {
                    this.starttimeField = value;
                    this.RaisePropertyChanged("starttime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string subject {
            get {
                return this.subjectField;
            }
            set {
                if ((object.ReferenceEquals(this.subjectField, value) != true)) {
                    this.subjectField = value;
                    this.RaisePropertyChanged("subject");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://HRONLib.Contracts/2017/04", ConfigurationName="ApprovalInstances.IApprovalService")]
    public interface IApprovalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HRONLib.Contracts/2017/04/IApprovalService/getApprovalInstances", ReplyAction="http://HRONLib.Contracts/2017/04/IApprovalService/getApprovalInstancesRespons" +
            "e")]
        HRONWeb.ApprovalInstances.WFApprovals[] getApprovalInstances(string MailAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HRONLib.Contracts/2017/04/IApprovalService/getApprovalInstances", ReplyAction="http://HRONLib.Contracts/2017/04/IApprovalService/getApprovalInstancesRespons" +
            "e")]
        System.Threading.Tasks.Task<HRONWeb.ApprovalInstances.WFApprovals[]> getApprovalInstancesAsync(string MailAddress);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApprovalServiceChannel : HRONWeb.ApprovalInstances.IApprovalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApprovalServiceClient : System.ServiceModel.ClientBase<HRONWeb.ApprovalInstances.IApprovalService>, HRONWeb.ApprovalInstances.IApprovalService {
        
        public ApprovalServiceClient() {
        }
        
        public ApprovalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApprovalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApprovalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApprovalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HRONWeb.ApprovalInstances.WFApprovals[] getApprovalInstances(string MailAddress) {
            return base.Channel.getApprovalInstances(MailAddress);
        }
        
        public System.Threading.Tasks.Task<HRONWeb.ApprovalInstances.WFApprovals[]> getApprovalInstancesAsync(string MailAddress) {
            return base.Channel.getApprovalInstancesAsync(MailAddress);
        }
    }
}
