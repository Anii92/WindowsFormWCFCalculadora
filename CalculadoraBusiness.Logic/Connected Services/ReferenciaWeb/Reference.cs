﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculadoraBusiness.Logic.ReferenciaWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenciaWeb.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Suma", ReplyAction="http://tempuri.org/IService1/SumaResponse")]
        int Suma(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Suma", ReplyAction="http://tempuri.org/IService1/SumaResponse")]
        System.Threading.Tasks.Task<int> SumaAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Resta", ReplyAction="http://tempuri.org/IService1/RestaResponse")]
        int Resta(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Resta", ReplyAction="http://tempuri.org/IService1/RestaResponse")]
        System.Threading.Tasks.Task<int> RestaAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiplicacion", ReplyAction="http://tempuri.org/IService1/MultiplicacionResponse")]
        int Multiplicacion(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiplicacion", ReplyAction="http://tempuri.org/IService1/MultiplicacionResponse")]
        System.Threading.Tasks.Task<int> MultiplicacionAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Division", ReplyAction="http://tempuri.org/IService1/DivisionResponse")]
        int Division(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Division", ReplyAction="http://tempuri.org/IService1/DivisionResponse")]
        System.Threading.Tasks.Task<int> DivisionAsync(int num1, int num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CalculadoraBusiness.Logic.ReferenciaWeb.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CalculadoraBusiness.Logic.ReferenciaWeb.IService1>, CalculadoraBusiness.Logic.ReferenciaWeb.IService1 {
        
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
        
        public int Suma(int num1, int num2) {
            return base.Channel.Suma(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SumaAsync(int num1, int num2) {
            return base.Channel.SumaAsync(num1, num2);
        }
        
        public int Resta(int num1, int num2) {
            return base.Channel.Resta(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> RestaAsync(int num1, int num2) {
            return base.Channel.RestaAsync(num1, num2);
        }
        
        public int Multiplicacion(int num1, int num2) {
            return base.Channel.Multiplicacion(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicacionAsync(int num1, int num2) {
            return base.Channel.MultiplicacionAsync(num1, num2);
        }
        
        public int Division(int num1, int num2) {
            return base.Channel.Division(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> DivisionAsync(int num1, int num2) {
            return base.Channel.DivisionAsync(num1, num2);
        }
    }
}
