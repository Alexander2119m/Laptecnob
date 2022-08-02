using System;
using System.Collections.Generic;
using System.Text;

namespace Etapa3poo
{
    class Ficha_Usuario : ClassPadre,OrdenBase
    {
        public string Mpago { set; get; }

        public Ficha_Usuario(int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion, string Mpago) : base(ID, Cedula, Nombre, Apellido, Correo, Edad, Telefono, Direccion)
        {
            this.Mpago = Mpago;
        }

        public override void ImprimirDatos()
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

        public override void pago()
        {

            double operar, credito, final, resultado, debito, resul;
            operar = 1700 * 12 / 100;
            final = 1700 + operar;
            credito = 1700 * 40 / 100;
            resultado = 1700 + credito;
            debito = 1700 * 18 / 100;
            resul = 1700 + debito;
            Console.WriteLine("Forma de pago :" + Mpago);
            Console.WriteLine("El precio inicial de la portatil :" + 1700);
            Console.WriteLine("Estas son las diferentes fomras de pago con sus debidos interes");
            Console.WriteLine("Precio en efectivo :" + final);
            Console.WriteLine("Precio en tarjeta de credito  :" + resultado);
            Console.WriteLine("Precio en tarjeta de debito  :" + resul);


        }
        public double Calcular()
        {
            return 1904;
        }
    }

    //En esta clase Ficha_Usuario le otorgamos la herencia de la clase Ordenbase
    //Creamos la clase calcular
}