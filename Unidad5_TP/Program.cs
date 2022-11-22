using System;
using System.Collections;

namespace Unidad5CattaneoEspindolaCeschiOviedo
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList empleados = new ArrayList();



            for(int i=0; i < 3; i++)
            {

                Empleado empleado;


                int edad;
                double sueldo;

                Console.WriteLine($"Ingrese los datos del empleado {i+1}: ");

                Console.WriteLine("Ingrese nombre:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese apellido:");
                string apellido = Console.ReadLine();


                Console.WriteLine("Ingrese edad:");
                Int32.TryParse(Console.ReadLine(), out edad);


                Console.WriteLine("Ingrese puesto:");
                string puesto = Console.ReadLine();


                Console.WriteLine("Ingrese sueldo:");
                Double.TryParse(Console.ReadLine(), out sueldo);



                empleado = new Empleado(1, nombre, apellido, edad, puesto, sueldo);

                if (!empleado.validarEdad())
                {
                    Console.WriteLine("La edad debe ser mayor a cero.Por favor ingrese nuevamente:");
                    Int32.TryParse(Console.ReadLine(), out edad);
                    empleado.Edad = edad;

                }
                if (!empleado.validarSueldo())
                {
                    Console.WriteLine("El sueldo debe ser mayor a cero.Por favor ingrese nuevamente:");
                    Double.TryParse(Console.ReadLine(), out sueldo);

                    empleado.Sueldo = sueldo;

                }

                empleados.Add(empleado);

                Console.ReadKey();
                Console.Clear();



            }

            foreach (Empleado e in empleados) {

                Console.WriteLine(e.ToString());
            }





        }
    }
}
