using System;
using System.Collections;

namespace Unidad4CattaneoEspindolaCeschiOviedo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine();



            edadEn5Anios();



            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 2");
            Console.WriteLine();
            //Ejercicio 2
            sueldos();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 3");
            Console.WriteLine();

            diccionario();

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 4");
            Console.WriteLine();

            numOrdenDescendente();

            Console.ReadKey();

        }



        //Le puse edad en 5 años para que tenga un poco de sentido la funcion
        public static void edadEn5Anios()
        {
            int[] edades = new int[3];
            Console.Write("Ingrese edad de la persona 1: ");
            Int32.TryParse(Console.ReadLine(), out int edad1);

            edades[0] = edad1;

            Console.Write("Ingrese edad de la persona 2:  ");
            Int32.TryParse(Console.ReadLine(), out int edad2);

            edades[1] = edad2;

            Console.Write("Ingrese edad de la persona 3: ");
            Int32.TryParse(Console.ReadLine(), out int edad3);

            edades[2] = edad3;

            Console.WriteLine();

            for (int i = 0; i < edades.Length; i++)
            {
                edades[i] += 5;

                Console.Write($"Edad en 5 años de la persona {i + 1}: {edades[i]} \n");
            }


        }

        public static void sueldos()
        {
            ArrayList sueldos = new ArrayList();


            bool band = true;
            double sueldo;
            Console.WriteLine("Ingrese -1 para Salir.");
            while (band)
            {


                Console.WriteLine("Ingrese sueldo del empleado: ");
                Double.TryParse(Console.ReadLine(), out sueldo);

                if (sueldo == -1)
                {
                    band = false;
                }
                else
                {
                    sueldos.Add(sueldo);

                }


            }
            //Saco el promedio
            double promedio = 0;

            foreach (double s in sueldos)
            {

                promedio += s;
            }

            //Ordeno el array para encontrar mas facil el max y min
            sueldos.Sort();

            promedio /= sueldos.Count;

            Console.WriteLine($"Sueldo Promedio: {promedio}");
            Console.WriteLine($"Sueldo minimo: {sueldos[0]}");
            Console.WriteLine($"Sueldo maximo: {sueldos[sueldos.Count - 1]}");

        }

        public static void diccionario()
        {

            var palabras = new Hashtable(){
                                        {"Actuar", "Comportarse o proceder [una persona] de una manera determinada."},
                                        {"Aprobar", "Considerar que algo está bien, darlo por bueno, aceptarlo o expresar conformidad con ello."},
                                        {"Promocionar", "Ayudar a alguien a subir de categoría en el trabajo o en las relaciones sociales."}
                                        };


            bool band = true;
            string palabra = "";
            string definicion = "";

            Console.WriteLine("Ingrese -1 para Salir.");
            while (band)
            {


                Console.WriteLine("Ingrese palabra a definir: ");
                palabra = Console.ReadLine();

                if (palabra == "-1")
                {
                    band = false;
                }
                else
                {
                    Console.WriteLine("Ingrese definicion: ");
                    definicion = Console.ReadLine();

                    palabras.Add(palabra, definicion);

                    palabra = "";
                    definicion = "";

                }

            }

            foreach (DictionaryEntry p in palabras)
                Console.WriteLine($" {p.Key} : {p.Value}");


        }


        public static void numOrdenDescendente()
        {
            ArrayList array = new ArrayList();
            Console.WriteLine("Ingrese 5 numeros:");

            for (int i = 0; i < 5; i++)
            {

                Int32.TryParse(Console.ReadLine(), out int num);

                array.Add(num);
            }

            array.Sort();
            array.Reverse();

            foreach (int n in array)
            {
                Console.Write(n + " ");
            }

        }

    }
    }
