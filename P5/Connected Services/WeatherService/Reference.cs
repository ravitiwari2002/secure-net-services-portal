﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P5.WeatherService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherService.IService3")]
    public interface IService3 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/getCatPic", ReplyAction="http://tempuri.org/IService3/getCatPicResponse")]
        string getCatPic(string makeItTalk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/getCatPic", ReplyAction="http://tempuri.org/IService3/getCatPicResponse")]
        System.Threading.Tasks.Task<string> getCatPicAsync(string makeItTalk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/getCatFact", ReplyAction="http://tempuri.org/IService3/getCatFactResponse")]
        string getCatFact();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/getCatFact", ReplyAction="http://tempuri.org/IService3/getCatFactResponse")]
        System.Threading.Tasks.Task<string> getCatFactAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/mathOperations", ReplyAction="http://tempuri.org/IService3/mathOperationsResponse")]
        double mathOperations(string task, double mathStuff1, double mathStuff2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/mathOperations", ReplyAction="http://tempuri.org/IService3/mathOperationsResponse")]
        System.Threading.Tasks.Task<double> mathOperationsAsync(string task, double mathStuff1, double mathStuff2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/WordCount", ReplyAction="http://tempuri.org/IService3/WordCountResponse")]
        string WordCount(string inputData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/WordCount", ReplyAction="http://tempuri.org/IService3/WordCountResponse")]
        System.Threading.Tasks.Task<string> WordCountAsync(string inputData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/Weather5day", ReplyAction="http://tempuri.org/IService3/Weather5dayResponse")]
        string[] Weather5day(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/Weather5day", ReplyAction="http://tempuri.org/IService3/Weather5dayResponse")]
        System.Threading.Tasks.Task<string[]> Weather5dayAsync(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/nameAge", ReplyAction="http://tempuri.org/IService3/nameAgeResponse")]
        string nameAge(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/nameAge", ReplyAction="http://tempuri.org/IService3/nameAgeResponse")]
        System.Threading.Tasks.Task<string> nameAgeAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService3Channel : P5.WeatherService.IService3, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service3Client : System.ServiceModel.ClientBase<P5.WeatherService.IService3>, P5.WeatherService.IService3 {
        
        public Service3Client() {
        }
        
        public Service3Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service3Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service3Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service3Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getCatPic(string makeItTalk) {
            return base.Channel.getCatPic(makeItTalk);
        }
        
        public System.Threading.Tasks.Task<string> getCatPicAsync(string makeItTalk) {
            return base.Channel.getCatPicAsync(makeItTalk);
        }
        
        public string getCatFact() {
            return base.Channel.getCatFact();
        }
        
        public System.Threading.Tasks.Task<string> getCatFactAsync() {
            return base.Channel.getCatFactAsync();
        }
        
        public double mathOperations(string task, double mathStuff1, double mathStuff2) {
            return base.Channel.mathOperations(task, mathStuff1, mathStuff2);
        }
        
        public System.Threading.Tasks.Task<double> mathOperationsAsync(string task, double mathStuff1, double mathStuff2) {
            return base.Channel.mathOperationsAsync(task, mathStuff1, mathStuff2);
        }
        
        public string WordCount(string inputData) {
            return base.Channel.WordCount(inputData);
        }
        
        public System.Threading.Tasks.Task<string> WordCountAsync(string inputData) {
            return base.Channel.WordCountAsync(inputData);
        }
        
        public string[] Weather5day(string zipcode) {
            return base.Channel.Weather5day(zipcode);
        }
        
        public System.Threading.Tasks.Task<string[]> Weather5dayAsync(string zipcode) {
            return base.Channel.Weather5dayAsync(zipcode);
        }
        
        public string nameAge(string name) {
            return base.Channel.nameAge(name);
        }
        
        public System.Threading.Tasks.Task<string> nameAgeAsync(string name) {
            return base.Channel.nameAgeAsync(name);
        }
    }
}
