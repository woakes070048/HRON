﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRON.EmployeeOnBoarding {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://HRONLib.Contracts/2017/04", ConfigurationName="EmployeeOnBoarding.IOnBoardingService")]
    public interface IOnBoardingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HRONLib.Contracts/2017/04/IOnBoardingService/StartProcess", ReplyAction="http://HRONLib.Contracts/2017/04/IOnBoardingService/StartProcessResponse")]
        System.Guid StartProcess(HRONLib.Employee Employee, byte[] workflow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HRONLib.Contracts/2017/04/IOnBoardingService/StartProcess", ReplyAction="http://HRONLib.Contracts/2017/04/IOnBoardingService/StartProcessResponse")]
        System.Threading.Tasks.Task<System.Guid> StartProcessAsync(HRONLib.Employee Employee, byte[] workflow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HRONLib.Contracts/2017/04/IOnBoardingService/getWorkflowStatus", ReplyAction="http://HRONLib.Contracts/2017/04/IOnBoardingService/getWorkflowStatusResponse" +
            "")]
        string[] getWorkflowStatus(System.Guid WFID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HRONLib.Contracts/2017/04/IOnBoardingService/getWorkflowStatus", ReplyAction="http://HRONLib.Contracts/2017/04/IOnBoardingService/getWorkflowStatusResponse" +
            "")]
        System.Threading.Tasks.Task<string[]> getWorkflowStatusAsync(System.Guid WFID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOnBoardingServiceChannel : HRON.EmployeeOnBoarding.IOnBoardingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OnBoardingServiceClient : System.ServiceModel.ClientBase<HRON.EmployeeOnBoarding.IOnBoardingService>, HRON.EmployeeOnBoarding.IOnBoardingService {
        
        public OnBoardingServiceClient() {
        }
        
        public OnBoardingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OnBoardingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OnBoardingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OnBoardingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid StartProcess(HRONLib.Employee Employee, byte[] workflow) {
            return base.Channel.StartProcess(Employee, workflow);
        }
        
        public System.Threading.Tasks.Task<System.Guid> StartProcessAsync(HRONLib.Employee Employee, byte[] workflow) {
            return base.Channel.StartProcessAsync(Employee, workflow);
        }
        
        public string[] getWorkflowStatus(System.Guid WFID) {
            return base.Channel.getWorkflowStatus(WFID);
        }
        
        public System.Threading.Tasks.Task<string[]> getWorkflowStatusAsync(System.Guid WFID) {
            return base.Channel.getWorkflowStatusAsync(WFID);
        }
    }
}
