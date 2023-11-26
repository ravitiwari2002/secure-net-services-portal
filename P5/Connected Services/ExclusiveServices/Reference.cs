﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P5.ExclusiveServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ExclusiveServices.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createAccount", ReplyAction="http://tempuri.org/IService1/createAccountResponse")]
        bool createAccount(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createAccount", ReplyAction="http://tempuri.org/IService1/createAccountResponse")]
        System.Threading.Tasks.Task<bool> createAccountAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/findNearestStore", ReplyAction="http://tempuri.org/IService1/findNearestStoreResponse")]
        string findNearestStore(string zipcode, string storeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/findNearestStore", ReplyAction="http://tempuri.org/IService1/findNearestStoreResponse")]
        System.Threading.Tasks.Task<string> findNearestStoreAsync(string zipcode, string storeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewsFocus", ReplyAction="http://tempuri.org/IService1/NewsFocusResponse")]
        string[] NewsFocus(string[] topics);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewsFocus", ReplyAction="http://tempuri.org/IService1/NewsFocusResponse")]
        System.Threading.Tasks.Task<string[]> NewsFocusAsync(string[] topics);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : P5.ExclusiveServices.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<P5.ExclusiveServices.IService1>, P5.ExclusiveServices.IService1 {
        
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
        
        public bool createAccount(string username, string password) {
            return base.Channel.createAccount(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> createAccountAsync(string username, string password) {
            return base.Channel.createAccountAsync(username, password);
        }
        
        public string findNearestStore(string zipcode, string storeName) {
            return base.Channel.findNearestStore(zipcode, storeName);
        }
        
        public System.Threading.Tasks.Task<string> findNearestStoreAsync(string zipcode, string storeName) {
            return base.Channel.findNearestStoreAsync(zipcode, storeName);
        }
        
        public string[] NewsFocus(string[] topics) {
            return base.Channel.NewsFocus(topics);
        }
        
        public System.Threading.Tasks.Task<string[]> NewsFocusAsync(string[] topics) {
            return base.Channel.NewsFocusAsync(topics);
        }
    }
}
