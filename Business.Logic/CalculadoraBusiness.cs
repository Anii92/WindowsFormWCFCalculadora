using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CalculadoraBusiness : ICalculadoraBusiness
    {
        private CalculadoraService calculadoraService;

        public CalculadoraBusiness(CalculadoraService calculadoraService)
        {
            this.calculadoraService = calculadoraService;
        }

        public string Dividir(int number1, int number2)
        {
            return this.calculadoraService.Dividir(number1, number2);
        }

        public string Multiplicar(int number1, int number2)
        {
            return this.calculadoraService.Multiplicar(number1, number2);
        }

        public string Restar(int number1, int number2)
        {
            return this.calculadoraService.Restar(number1, number2);
        }

        public string Sumar(int number1, int number2)
        {
            return this.calculadoraService.Sumar(number1, number2);
        }
    }
}
