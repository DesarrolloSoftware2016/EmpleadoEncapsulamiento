using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoEncapsulamiento
{
    class Empleado
    {
        // Variables miembro
        private string nombreEmpleado;
        private int idEmpleado;
        private double salarioActual;
        private int edadEmpleado;

        /*
        // Accessor (método get)
        public string GetNombre()
        {
            return nombreEmpleado;
        }

        // Mutator (método set)
        public void SetNombre(string nombre)
        {
            // Revisar el valor del nombre antes de asignarlo
            if (nombre.Length >= 10)
                nombreEmpleado = nombre;
            else
                Console.WriteLine("¡Error! El nombre no puede ser menor de 10 caracteres...");
        }
        */

        // Agregando métodos set/get de la manera .NET
        // a través de PROPIEDADES

        public string Nombre
        {
            get { return nombreEmpleado; }
            set
            {
                if (value.Length >= 10)
                    nombreEmpleado = value;
                else
                    Console.WriteLine("¡Error! El nombre no puede ser menor de 10 caracteres...");
            }
        }

        // Constructores
        public Empleado() { }

        public Empleado(string nombre)
        {
            nombreEmpleado = nombre;
        }
    }
}
