using System;
using System.Collections.Generic;
using System.Text;

namespace Etapa3poo
{
    class Ficha_Vendedor : ClassPadre
    {
        public string Rlegales { set; get; }
        public string Dservicio { set; get; }
        public string Opventa { set; get; }

        public Ficha_Vendedor(int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion, string Rlegales, string Dservicio, string Opventa) : base(ID, Cedula, Nombre, Apellido, Correo, Edad, Telefono, Direccion)
        {
            this.Rlegales = Rlegales;
            this.Dservicio = Dservicio;
            this.Opventa = Opventa;

        }
        public override void ImprimirDatos()
        {
            Console.WriteLine("----------------------");
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

        public override void Servicio()
        {

            Console.WriteLine("---------------");
            Console.WriteLine("----------------------");
            Console.WriteLine("Bienvenidos al centro de ventas Laptecnology en este lugar usted encotrara una gran variedad");
            Console.WriteLine("de laptops de diferentes modelos y precios a continuacion procedemos a  mostrar el catalogo de las maquinas");


        }

        public override void legales()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Requisitos legales " + Rlegales);
        }
        public override void venta()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("----------------------");
            Console.WriteLine("Opciones de venta" + Opventa);
            Console.WriteLine("rog zephyrus m16");
            Console.WriteLine("asus tuf dash f15");
            Console.WriteLine("Msi gl75");

        }
    }
}