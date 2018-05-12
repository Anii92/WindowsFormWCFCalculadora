using Business.Logic.ReferenciaWeb;
using Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CalculadoraService
    {
        private Service1Client serviceCalculator;

        public CalculadoraService(Service1Client serviceCalculator)
        {
            this.serviceCalculator = serviceCalculator;
        }

        public string Sumar(int number1, int number2)
        {
            this.GetServiceCalculator();
            return this.serviceCalculator.Suma(number1, number2).ToString();
        }

        public string Restar(int number1, int number2)
        {
            this.GetServiceCalculator();
            return this.serviceCalculator.Resta(number1, number2).ToString();
        }

        public string Multiplicar(int number1, int number2)
        {
            this.GetServiceCalculator();
            return this.serviceCalculator.Multiplicacion(number1, number2).ToString();
        }

        public string Dividir(int number1, int number2)
        {
            this.GetServiceCalculator();
            return this.serviceCalculator.Division(number1, number2).ToString();
        }

        private void GetServiceCalculator()
        {
            var connectionType = Configuracion.ReadValueFromAppConfig("TypeConnectionService");
            this.serviceCalculator = new Service1Client(connectionType);
        }
    }
}
