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
            Empleado empleado = new Empleado("Marvin");

            // Demostración con métodos Accessor/Mutator
            // Console.WriteLine("El nombre del empleado es {0}", empleado.GetNombre());

            // Propiedades .NET
            Console.WriteLine("El nombre del empleado es {0}", empleado.Nombre);

            Empleado otroEmpleado = new Empleado();
            // otroEmpleado.SetNombre("María");
            // Console.WriteLine("El nombre del empleado es {0}", otroEmpleado.GetNombre());
            otroEmpleado.Nombre = "María";
            Console.ReadLine();
        }
    }
}
