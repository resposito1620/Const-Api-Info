using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CodigoIncorrecto : Exception
    {
        public CodigoIncorrecto() : base("El código ingresado no es correcto.")
        {

        }
    }
}
