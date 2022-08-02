using System;
using System.Collections.Generic;
using System.Text;

namespace Etapa3poo
{
    class Decorador : OrdenBase
    {
        protected OrdenBase orden;

        public Decorador(OrdenBase orden)
        {
            this.orden = orden;
        }
        public virtual double Calcular()
        {
            
            return orden.Calcular();
        }
        //Patron de diseño: Decorador
        //Creamos una clase nueva con el nombre Decorador 
        //La variable OrdenBase debe estar protegida
        //Luego el metodo Calcular debe de ser public virtual

    }
}
