﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWCF.WebRefClient.Contract2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="MyWCF", ConfigurationName="Contract2.HelloWorldService")]
    public interface HelloWorldService {
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWCF/HelloWorldService/SayHelloTo", ReplyAction="MyWCF/HelloWorldService/SayHelloToResponse")]
        string SayHelloTo(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloWorldServiceChannel : MyWCF.WebRefClient.Contract2.HelloWorldService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldServiceClient : System.ServiceModel.ClientBase<MyWCF.WebRefClient.Contract2.HelloWorldService>, MyWCF.WebRefClient.Contract2.HelloWorldService {
        
        public HelloWorldServiceClient() {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHelloTo(string name) {
            return base.Channel.SayHelloTo(name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="MyWCF", ConfigurationName="Contract2.HelloWorldExService")]
    public interface HelloWorldExService {
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWCF/HelloWorldService/SayHelloTo", ReplyAction="MyWCF/HelloWorldService/SayHelloToResponse")]
        string SayHelloTo(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWCF/HelloWorldExService/SayHelloToEx", ReplyAction="MyWCF/HelloWorldExService/SayHelloToExResponse")]
        string SayHelloToEx(string[] names);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloWorldExServiceChannel : MyWCF.WebRefClient.Contract2.HelloWorldExService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldExServiceClient : System.ServiceModel.ClientBase<MyWCF.WebRefClient.Contract2.HelloWorldExService>, MyWCF.WebRefClient.Contract2.HelloWorldExService {
        
        public HelloWorldExServiceClient() {
        }
        
        public HelloWorldExServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldExServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldExServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldExServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHelloTo(string name) {
            return base.Channel.SayHelloTo(name);
        }
        
        public string SayHelloToEx(string[] names) {
            return base.Channel.SayHelloToEx(names);
        }
    }
}
