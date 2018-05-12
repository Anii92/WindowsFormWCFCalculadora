using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBusiness.Logic
{
    public interface ICalculadoraBusiness
    {
        string Sumar(int number1, int number2);
        string Restar(int number1, int number2);
        string Dividir(int number1, int number2);
        string Multiplicar(int number1, int number2);
    }
}
