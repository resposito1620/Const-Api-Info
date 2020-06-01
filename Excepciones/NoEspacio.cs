using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
   public class NoEspacio : Exception
    {
        public NoEspacio() : base("La máquina está llena. No pueden agregarse nuevas latas.")
        {

        }
    }
}
