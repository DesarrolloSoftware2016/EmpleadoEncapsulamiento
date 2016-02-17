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
        // Variable miembro constante, accesible sólamente
        // desde la clase, no accesible por el objeto.
        private const double ihss = 0.07;

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

        public int Id
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public double Pago
        {
            get { return salarioActual; }
            set { salarioActual = value; }
        }

        public int Edad
        {
            get { return edadEmpleado; }
            set { edadEmpleado = value; }
        }

        // Constructores
        public Empleado() { }

        public Empleado(string nombre, int id, double salario, int edad)
        {
            // Utilizar las propiedades para reducir la cantidad
            // de código para validaciones y tambíén evitar errores
            Nombre = nombre;
            Id = id;
            Pago = salario;
            Edad = edad;
        }

        // Métodos
        public void DarBono(double cantidad)
        {
            salarioActual += cantidad;
        }

        public void DesplegarEstado()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Identidad: {0}", Id);
            Console.WriteLine("Edad: {0}", Edad);
            Console.WriteLine("Salario: {0}", Pago);
            Console.WriteLine("El valor del IHSS({0}) es: {1}", ihss, CalcularIhss());
        }

        public double CalcularIhss()
        {
            return Pago * ihss;
        }
    }
}
