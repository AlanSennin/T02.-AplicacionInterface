using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterface
{
    public class Calculadora : IDatos, IOperaciones //Heredando de las Interfaces IDatos e IOperaciones
    {
        public double N1 { get; set; } //Implementamos la Interfaz con Control + "."
        public double N2 { get; set; } //Implementamos la Interfaz con Control + "."

        //Metodos para la Operacion a elegir

        public double CalcularDivision() 
        {
            return N1/N2; //Division
        }

        public double CalcularMultiplicacion()
        {
            return N1 * N2; //Multiplicacion
        }

        public double CalcularResta()
        {
            return N1 - N2; //Resta
        }

        public double CalcularSuma()
        {
            return N1 + N2; //Suma
        }
    }
}
