﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="ybao", ConfigurationName="ServiceReference.IService1", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld1", ReplyAction="ybao/IService1/HelloWorld1Response")]
        string HelloWorld1();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld1", ReplyAction="ybao/IService1/HelloWorld1Response")]
        System.Threading.Tasks.Task<string> HelloWorld1Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/YbaoHelloWorld2", ReplyAction="ybao/IService1/YbaoHelloWorld2Response")]
        string YbaoHelloWorld2();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/YbaoHelloWorld2", ReplyAction="ybao/IService1/YbaoHelloWorld2Response")]
        System.Threading.Tasks.Task<string> YbaoHelloWorld2Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld3", ReplyAction="ybao/IService1/HelloWorld3Response")]
        string HelloWorld3();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld3", ReplyAction="ybao/IService1/HelloWorld3Response")]
        System.Threading.Tasks.Task<string> HelloWorld3Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld5", ReplyAction="ybao/IService1/HelloWorld5Response")]
        string HelloWorld5();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld5", ReplyAction="ybao/IService1/HelloWorld5Response")]
        System.Threading.Tasks.Task<string> HelloWorld5Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld6", ReplyAction="ybao/IService1/HelloWorld6Response")]
        string HelloWorld6();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld6", ReplyAction="ybao/IService1/HelloWorld6Response")]
        System.Threading.Tasks.Task<string> HelloWorld6Async();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="ybao/IService1/HelloWorld7")]
        void HelloWorld7();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="ybao/IService1/HelloWorld7")]
        System.Threading.Tasks.Task HelloWorld7Async();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="ybao/IService1/HelloWorld8", ReplyAction="ybao/IService1/HelloWorld8Response")]
        string HelloWorld8();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="ybao/IService1/HelloWorld8", ReplyAction="ybao/IService1/HelloWorld8Response")]
        System.Threading.Tasks.Task<string> HelloWorld8Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld9", ReplyAction="ybao/IService1/HelloWorld9Response")]
        string HelloWorld9();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld9", ReplyAction="ybao/IService1/HelloWorld9Response")]
        System.Threading.Tasks.Task<string> HelloWorld9Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld10", ReplyAction="ybao/IService1/HelloWorld10Response")]
        string HelloWorld10();
        
        [System.ServiceModel.OperationContractAttribute(Action="ybao/IService1/HelloWorld10", ReplyAction="ybao/IService1/HelloWorld10Response")]
        System.Threading.Tasks.Task<string> HelloWorld10Async();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference.IService1>, Client.ServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld1() {
            return base.Channel.HelloWorld1();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorld1Async() {
            return base.Channel.HelloWorld1Async();
        }
        
        public string YbaoHelloWorld2() {
            return base.Channel.YbaoHelloWorld2();
        }
        
        public System.Threading.Tasks.Task<string> YbaoHelloWorld2Async() {
            return base.Channel.YbaoHelloWorld2Async();
        }
        
        public string HelloWorld3() {
            return base.Channel.HelloWorld3();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorld3Async() {
            return base.Channel.HelloWorld3Async();
        }
        
        public string HelloWorld5() {
            return base.Channel.HelloWorld5();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorld5Async() {
            return base.Channel.HelloWorld5Async();
        }
        
        public string HelloWorld6() {
            return base.Channel.HelloWorld6();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorld6Async() {
            return base.Channel.HelloWorld6Async();
        }
        
        public void HelloWorld7() {
            base.Channel.HelloWorld7();
        }
        
        public System.Threading.Tasks.Task HelloWorld7Async() {
            return base.Channel.HelloWorld7Async();
        }
        
        public string HelloWorld8() {
            return base.Channel.HelloWorld8();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorld8Async() {
            return base.Channel.HelloWorld8Async();
        }
        
        public string HelloWorld9() {
            return base.Channel.HelloWorld9();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorld9Async() {
            return base.Channel.HelloWorld9Async();
        }
        
        public string HelloWorld10() {
            return base.Channel.HelloWorld10();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorld10Async() {
            return base.Channel.HelloWorld10Async();
        }
    }
}
