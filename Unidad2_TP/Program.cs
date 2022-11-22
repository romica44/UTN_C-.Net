using System;

namespace Unidad2CattaneoCeschiEspindolaOviedo
{
    class Program
    {
        static void Main(string[] args)
        {


            esDivisible3();
            mesNumATexto();
            tablaDeMultiplicar();


          

        }

        //Hacer un programa que le pida al usuario que ingrese un número y le responda si es divisible por 3
        public static void esDivisible3()
        {

            bool esNumero = true;
            Console.WriteLine();
            Console.WriteLine("Ejercicio 1 - Es divisible?");
            do
            {
                Console.WriteLine("Ingrese un número");
                string numero = Console.ReadLine();
                esNumero = int.TryParse(numero, out int resultado);

                if (esNumero)
                {
                    if (resultado % 3 == 0)
                    {
                        Console.WriteLine("El número es divisible por 3");
                    }
                    else
                    {
                        Console.WriteLine("El número no es divisible por 3");
                    }
                }
                else {
                    
                    Console.WriteLine("Error. Debe ingresar un numero");
                    
                }
                

            } while (!esNumero);
        
        }

        // Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponda a ese número. Usar Switch
        public static void mesNumATexto() {


            bool esNumero = true;
            Console.WriteLine();
            Console.WriteLine("Ejercicio 2 - Que mes es");
            do
            {
                Console.WriteLine("Ingrese un número");
                string numero = Console.ReadLine();
                esNumero = int.TryParse(numero, out int resultado);

                if (esNumero) {
                    if (resultado >= 1 && resultado <= 12)
                    {
                        switch (resultado)
                        {
                            case 1:
                                Console.WriteLine("Enero");
                                break;
                            case 2:
                                Console.WriteLine("Febrero");
                                break;
                            case 3:
                                Console.WriteLine("Marzo");
                                break;
                            case 4:
                                Console.WriteLine("Abril");
                                break;
                            case 5:
                                Console.WriteLine("Mayo");
                                break;
                            case 6:
                                Console.WriteLine("Junio");
                                break;
                            case 7:
                                Console.WriteLine("Julio");
                                break;
                            case 8:
                                Console.WriteLine("Agosto");
                                break;
                            case 9:
                                Console.WriteLine("Septiembre");
                                break;
                            case 10:
                                Console.WriteLine("Octubre");
                                break;
                            case 11:
                                Console.WriteLine("Noviembre");
                                break;
                            case 12:
                                Console.WriteLine("Diciembre");
                                break;
                            default:
                                Console.WriteLine("El numero no corresponde a un mes");
                                break;
                        }
                    }

                }
                else
                {

                    Console.WriteLine("Error. Debe ingresar un numero");

                }
                


            } while (!esNumero);

            

        }

        //Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número
        public static void tablaDeMultiplicar() {

            
            bool esNumero = true;
            Console.WriteLine();
            Console.WriteLine("Ejercicio 3 - Tabla de Multiplicar");
            do
            {
                Console.WriteLine("Ingrese un número");
                string numero = Console.ReadLine();
                esNumero = int.TryParse(numero, out int resultado);

                if (esNumero) {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(resultado + " x " + i + " = " + resultado * i);
                    }
                }
                else
                {

                    Console.WriteLine("Error. Debe ingresar un numero");

                }
              


            } while (!esNumero);
        

        }
    }



}
