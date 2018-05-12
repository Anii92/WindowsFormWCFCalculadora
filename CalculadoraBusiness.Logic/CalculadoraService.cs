using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBusiness.Logic
{
    public class CalculadoraService
    {
        ReferenciaWeb.Service1Client serviceCalculator;

        public CalculadoraService()
        {
            this.serviceCalculator = new ReferenciaWeb.Service1Client("Tcp");
        }

        public string Sumar(int number1, int number2)
        {
            return this.serviceCalculator.Suma(4, 2).ToString();
        }

        public string Restar(int number1, int number2)
        {
            return this.serviceCalculator.Resta(4, 2).ToString();
        }

        public string Multiplicar(int number1, int number2)
        {
            return this.serviceCalculator.Multiplicacion(4, 2).ToString();
        }

        public string Dividir(int number1, int number2)
        {
            return this.serviceCalculator.Division(4, 2).ToString();
        }
    }
}
