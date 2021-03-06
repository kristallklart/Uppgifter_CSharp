﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uppgift1_Forms.Uppgift1_ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Grupp7", ConfigurationName="Uppgift1_ServiceReference.Uppgift1_ServiceSoap")]
    public interface Uppgift1_ServiceSoap {
        
        // CODEGEN: Generating message contract since element name s from namespace Grupp7 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="Grupp7/OpenFile", ReplyAction="*")]
        Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileResponse OpenFile(Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="Grupp7/OpenFile", ReplyAction="*")]
        System.Threading.Tasks.Task<Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileResponse> OpenFileAsync(Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OpenFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OpenFile", Namespace="Grupp7", Order=0)]
        public Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequestBody Body;
        
        public OpenFileRequest() {
        }
        
        public OpenFileRequest(Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Grupp7")]
    public partial class OpenFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string s;
        
        public OpenFileRequestBody() {
        }
        
        public OpenFileRequestBody(string s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OpenFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OpenFileResponse", Namespace="Grupp7", Order=0)]
        public Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileResponseBody Body;
        
        public OpenFileResponse() {
        }
        
        public OpenFileResponse(Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Grupp7")]
    public partial class OpenFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string OpenFileResult;
        
        public OpenFileResponseBody() {
        }
        
        public OpenFileResponseBody(string OpenFileResult) {
            this.OpenFileResult = OpenFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Uppgift1_ServiceSoapChannel : Uppgift1_Forms.Uppgift1_ServiceReference.Uppgift1_ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Uppgift1_ServiceSoapClient : System.ServiceModel.ClientBase<Uppgift1_Forms.Uppgift1_ServiceReference.Uppgift1_ServiceSoap>, Uppgift1_Forms.Uppgift1_ServiceReference.Uppgift1_ServiceSoap {
        
        public Uppgift1_ServiceSoapClient() {
        }
        
        public Uppgift1_ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Uppgift1_ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Uppgift1_ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Uppgift1_ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileResponse Uppgift1_Forms.Uppgift1_ServiceReference.Uppgift1_ServiceSoap.OpenFile(Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequest request) {
            return base.Channel.OpenFile(request);
        }
        
        public string OpenFile(string s) {
            Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequest inValue = new Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequest();
            inValue.Body = new Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequestBody();
            inValue.Body.s = s;
            Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileResponse retVal = ((Uppgift1_Forms.Uppgift1_ServiceReference.Uppgift1_ServiceSoap)(this)).OpenFile(inValue);
            return retVal.Body.OpenFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileResponse> Uppgift1_Forms.Uppgift1_ServiceReference.Uppgift1_ServiceSoap.OpenFileAsync(Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequest request) {
            return base.Channel.OpenFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileResponse> OpenFileAsync(string s) {
            Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequest inValue = new Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequest();
            inValue.Body = new Uppgift1_Forms.Uppgift1_ServiceReference.OpenFileRequestBody();
            inValue.Body.s = s;
            return ((Uppgift1_Forms.Uppgift1_ServiceReference.Uppgift1_ServiceSoap)(this)).OpenFileAsync(inValue);
        }
    }
}
