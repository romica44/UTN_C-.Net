using System;

namespace Unidad1CattaneoCeschiEspindolaOviedo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Solicitar por línea de comandos que el usuario ingrese:

             Apellido y Nombre.

             Dirección

             Teléfono */

            string nombre;
            string apellido;
            string direccion;
            long telefono;

            Console.WriteLine("--------UNIDAD 1 ----------");
            Console.WriteLine("Ingrese su nombre: ");
            nombre= Console.ReadLine();

            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su Direccion: ");
            direccion = Console.ReadLine();

            Console.WriteLine("Ingrese su numero de telefono: ");
            telefono = long.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine($"La persona : {apellido} {nombre} vive en {direccion} .Numero de telefono: {telefono}");


            /*Definir e inicializar una variable de cada tipo (bool, byte, char, decimal, double, float, int, long, short y string) y mostrar por pantalla el contenido de cada uno. */

            bool verdad = true;
            string cadena = "Sofia";
            byte bite = 255;
            char c = 'd';
            decimal deci = 2.4m;
            double numDouble = 2.3;
            float flotante = 23.45f;
            int entero = 234;
            short corto = 124;
            long largo = 3426142003;

            Console.WriteLine(" ");
            Console.WriteLine($"bool: {verdad} ");
            Console.WriteLine($"string: {cadena} ");
            Console.WriteLine($"byte: {bite} ");
            Console.WriteLine($"char: {c} ");
            Console.WriteLine($"decimal: {deci} ");
            Console.WriteLine($"double: {numDouble} ");
            Console.WriteLine($"float: {flotante} ");
            Console.WriteLine($"int: {entero} ");
            Console.WriteLine($"short: {corto} ");
            Console.WriteLine($"long: {largo} ");

        

            /*
             ¿Las siguientes variables están bien inicializadas? ¿cual es el error de compilación? 

                int numero = "string"; 

                string cadena = 1; 

             No estan bien inicializadas ya que estamos asignando diferentes tipos de datos. A un entero le estamos asignando un string y a un string un entero. 
             
             */



        }
    }
}
