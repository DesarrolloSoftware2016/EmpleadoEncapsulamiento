using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Demostración del encapsulamiento *****");

            // Crear objetos de tipo Empleado
            Empleado empleado = new Empleado("Marvin", 123, 10000, 23);

            // Demostración con métodos Accessor/Mutator
            // Console.WriteLine("El nombre del empleado es {0}", empleado.GetNombre());

            // Propiedades .NET
            // Console.WriteLine("El nombre del empleado es {0}", empleado.Nombre);

            empleado.DesplegarEstado();

            // Darle un bono al empleado accediendo a la variable miembro
            // a través de un método
            empleado.DarBono(1200);
            empleado.DesplegarEstado();

            Empleado otroEmpleado = new Empleado();
            // otroEmpleado.SetNombre("María");
            // Console.WriteLine("El nombre del empleado es {0}", otroEmpleado.GetNombre());
            otroEmpleado.Nombre = "María";
            Console.ReadLine();
        }
    }
}
