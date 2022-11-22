using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad5CattaneoEspindolaCeschiOviedo
{
    class Empleado
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        private string puesto;
        private double sueldo;

     

        public Empleado(int id, string nombre, string apellido, int edad, string puesto, double sueldo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Puesto = puesto;
            this.Sueldo = sueldo;
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public string nombreCompleto()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
        public bool validarEdad()
        {
            return this.Edad > 0;
        }
        public bool validarSueldo(){
            return this.Sueldo > 0;
        }

        public override string ToString()
        {
            return $"Id: {this.Id} , " +
                   $"Nombre: {this.Nombre} , " +
                   $"Apellido: {this.Apellido} , " +
                   $"Edad: {this.Edad} , " +
                   $"Puesto: {this.Puesto} ," +
                   $"Sueldo: {this.Sueldo}";
        }



    }
}
