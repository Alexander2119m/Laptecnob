using System;
using System.Collections.Generic;
using System.Text;

namespace Etapa3poo
{
    public class ClassPadre
    {

        public int ID { set; get; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }


        public ClassPadre(int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion)
        {
            this.ID = ID;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Correo = Correo;
            this.Edad = Edad;
            this.Telefono = Telefono;
            this.Direccion = Direccion;

        }
        public virtual void ImprimirDatos()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Identificacion: " + ID);
            Console.WriteLine("Numero de Cedula " + Cedula);
            Console.WriteLine(" Nombre : " + Nombre);
            Console.WriteLine("Apellidos :" + Apellido);
            Console.WriteLine("Edad  :" + Edad);
            Console.WriteLine("Correo Electronico :" + Correo);
            Console.WriteLine("Numero de telefono :" + Telefono);
            Console.WriteLine("Direccion del domicilio :" + Direccion);
        }
        public virtual void Servicio()
        {

        }
        public virtual void venta()
        {

        }
        public virtual void pago()
        {

        }
        public virtual void legales()
        {

        }
        public virtual void Requisitos()
        {

        }
    }
}