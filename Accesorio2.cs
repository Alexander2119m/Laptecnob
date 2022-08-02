using System;
using System.Collections.Generic;
using System.Text;

namespace Etapa3poo
{
    class Accesorio2 : Decorador
    {
        public Accesorio2(OrdenBase orden) : base(orden)
        {
        }

        public override double Calcular()
        {
            return base.Calcular() + 100;
        }
    }

    //Creamos la clase Accesorio2
    //Que permite realizar el calculo 
    //Del computador más el valor del accesorio
}
