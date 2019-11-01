using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterface
{
    interface IOperaciones
    {
        double CalcularSuma(); //Metodo para Calcular la Suma
        double CalcularResta(); //Metodo para Calcular la Resta
        double CalcularMultiplicacion(); //Metodo para Calcular la Multiplicacion
        double CalcularDivision(); //Metodo para Calcular la Division
    }
}
