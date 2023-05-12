using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMorenoAGASYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eliga una apartado 1.-Edad, 2.-Candidatos, 3.-Sueldo, 4.-Cambio de letra, 5.-Sopa de letra");
            int Result = int.Parse(Console.ReadLine());
            switch (Result)
            {
                case 1:
                    Console.Clear();
                    Apartado.Edad();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Apartado.Candidatos();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    int dias_trabajados = 5;
                    Empleado.Empleado.Calcular_Sueldo(dias_trabajados);
                    Console.ReadKey();
                    break;
                case 4:
                    Apartado.CambioLetras();
                    Console.ReadKey();
                    break ;
                case 5:
                    Apartado.sopaLetras();
                    Console.ReadKey();
                    break;
                case 6:
                    Apartado.palabraMasLarga();
                    Console.ReadKey();
                    break;
                case 7:
                    Apartado.factorial();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("No es una opcion correcta");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
