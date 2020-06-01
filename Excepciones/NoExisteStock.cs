using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoExisteStock : Exception
    {
        public NoExisteStock() : base("No contamos con stock de la bebida seleccionada, en este momento. Disculpe las molestias.")
        {

        }
    }
}
