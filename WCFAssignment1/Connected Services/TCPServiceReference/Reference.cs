﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFAssignment1.TCPServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TCPServiceReference.ITCP")]
    public interface ITCP {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITCP/TodayProgram", ReplyAction="http://tempuri.org/ITCP/TodayProgramResponse")]
        string TodayProgram(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITCP/TodayProgram", ReplyAction="http://tempuri.org/ITCP/TodayProgramResponse")]
        System.Threading.Tasks.Task<string> TodayProgramAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITCPChannel : WCFAssignment1.TCPServiceReference.ITCP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TCPClient : System.ServiceModel.ClientBase<WCFAssignment1.TCPServiceReference.ITCP>, WCFAssignment1.TCPServiceReference.ITCP {
        
        public TCPClient() {
        }
        
        public TCPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TCPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TCPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TCPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TodayProgram(string name) {
            return base.Channel.TodayProgram(name);
        }
        
        public System.Threading.Tasks.Task<string> TodayProgramAsync(string name) {
            return base.Channel.TodayProgramAsync(name);
        }
    }
}
