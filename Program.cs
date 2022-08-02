using System;

namespace Etapa3poo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ficha_Usuario usuario = new Ficha_Usuario(5458636, 1305468593, " Pedro ", " Cevallos ", " pedro1998@gmail.com ", 25, 0998231547, " Calle 312 Av 217 ", " Detallar las formas de pago ");
            usuario.ImprimirDatos();
            usuario.pago();

            

            Ficha_Vendedor vendedor = new Ficha_Vendedor(7896356, 1307895622, " Juan ", " Gomez ", " juan1975@gmail.com ", 35, 0989695223, " Calle 320 Av 117 ", " Mayor edad , Experencia Previa ,  Aprendizaje proactivo    ", " Ventas de laptops ", " Catalogo de laptops ");
            vendedor.ImprimirDatos();
            vendedor.Servicio();
            vendedor.venta();
            vendedor.legales();

            
            var ficha_Usuario = new Ficha_Usuario(5458636, 1305468593, " Pedro ", " Cevallos ", " pedro1998@gmail.com ", 25, 0998231547, " Calle 312 Av 217 ", " Detallar las formas de pago ");

            var accesorio1 = new Accesorio1(ficha_Usuario);
            Console.WriteLine($"El precio en efectivo del computador mas el accesorio es : {accesorio1.Calcular()}");
            var accesorio2 = new Accesorio2(ficha_Usuario);
            Console.WriteLine($"El precio en efectivo del computador mas el accesorio es : {accesorio2.Calcular()}");

            Ficha_Administrador Administrador = new Ficha_Administrador(457896, 130235784, " Jose ", " Arteaga ", " jose23@gmail.com ", 48, 0989695223, " Ciudadela Universitaria ", " Contar con una experiencia laboral de 5 años  ", " Ingeniero Tecnologia de la Informacion  ");
            Administrador.ImprimirDatos();
            Administrador.Servicio();

            Requisitos Req = new Requisitos();
            Req.Requisito();


            
        }

        //Finalmente en esta clase Program añadimos el metodo calcular de la clase decorador
    }
}
