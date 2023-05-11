using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sueldo_diario { get; set; }
        public int Sueldo_empleado { get; set; }

        public static void Calcular_Sueldo(int dias_trabajados)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Jacobo";
            empleado.Apellido = "Agami";
            empleado.Sueldo_diario = 500;
            empleado.Sueldo_empleado = empleado.Sueldo_diario * dias_trabajados;

            Console.WriteLine("El sueldo total del empleado: "+empleado.Nombre+" "+empleado.Apellido+" es de "+empleado.Sueldo_empleado);
     
        }
    }
}
