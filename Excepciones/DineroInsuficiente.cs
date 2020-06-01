using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DineroInsuficiente : Exception
    {
        public DineroInsuficiente(string dineroFaltante) : base("El dinero que usted ha ingresado no es suficiente para comprar el producto.\nA usted le faltan $" + dineroFaltante + "para completar la operación")
        {

        }
    }
}
