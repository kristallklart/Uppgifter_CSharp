﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uppgift3_Forms.Uppgift3_ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Grupp7", ConfigurationName="Uppgift3_ServiceReference.ServiceSoap")]
    public interface ServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace Grupp7 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="Grupp7/HelloWorld", ReplyAction="*")]
        Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldResponse HelloWorld(Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="Grupp7/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldResponse> HelloWorldAsync(Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="Grupp7", Order=0)]
        public Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="Grupp7", Order=0)]
        public Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Grupp7")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : Uppgift3_Forms.Uppgift3_ServiceReference.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<Uppgift3_Forms.Uppgift3_ServiceReference.ServiceSoap>, Uppgift3_Forms.Uppgift3_ServiceReference.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldResponse Uppgift3_Forms.Uppgift3_ServiceReference.ServiceSoap.HelloWorld(Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequest inValue = new Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequest();
            inValue.Body = new Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequestBody();
            Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldResponse retVal = ((Uppgift3_Forms.Uppgift3_ServiceReference.ServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldResponse> Uppgift3_Forms.Uppgift3_ServiceReference.ServiceSoap.HelloWorldAsync(Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldResponse> HelloWorldAsync() {
            Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequest inValue = new Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequest();
            inValue.Body = new Uppgift3_Forms.Uppgift3_ServiceReference.HelloWorldRequestBody();
            return ((Uppgift3_Forms.Uppgift3_ServiceReference.ServiceSoap)(this)).HelloWorldAsync(inValue);
        }
    }
}
