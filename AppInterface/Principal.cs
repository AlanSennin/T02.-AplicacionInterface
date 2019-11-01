using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterface
{
    public class Principal
    {
        Calculadora C = new Calculadora(); //Instanciando la Clase Calculadora

        public void Menu() //Menu para seleccionar la Opcion que querramos
        {
            Console.WriteLine("Ingrese Numero 1:");
            C.N1 = Convert.ToDouble(Console.ReadLine()); //Pidiendo al usuario ingresar el primer dato

            Console.WriteLine("");

            Console.WriteLine("Ingrese Numero 2:");
            C.N2 = Convert.ToDouble(Console.ReadLine()); //Pidiendo al usuario ingresar el primer dato

            Console.Clear();

            Console.WriteLine("!Bienvenido a la calculadora de 2 Numeros!");
            Console.WriteLine("");
            Console.WriteLine("(1) Suma");
            Console.WriteLine("(2) Resta");
            Console.WriteLine("(3) Multiplicacion");
            Console.WriteLine("(4) Division");
            Console.WriteLine("");
            Console.WriteLine("Ingrese una Opcion...");

            switch (Console.ReadLine()) //Switch para mandar a llamar los Metodos
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Suma: "+C.CalcularSuma());
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Resta: "+C.CalcularResta());
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Multiplicacion: "+C.CalcularMultiplicacion());
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Division: "+C.CalcularDivision());
                    break;

                default:
                    Console.WriteLine("Ingrese una opcion valida...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para regresar al menu...");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}
