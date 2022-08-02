using System;
using System.Collections.Generic;
using System.Text;

namespace Etapa3poo
{
    class Accesorio1: Decorador
    {
        
        public Accesorio1(OrdenBase orden) : base(orden)
        {
            
        }
        public override double Calcular()
        {
            return base.Calcular() + 80;
        }
        //Creamos la clase Accesorio1
        //Que permite realizar el calculo 
        //Del computador más el valor del accesorio

    }
}
