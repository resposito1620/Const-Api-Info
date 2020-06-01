using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneral
{
    public static class AyudaConsola
    {
        public static double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            double c = Validaciones.ValidarDouble(Console.ReadLine());
            if (c < 0)
            {
                throw new Exception("El valor ingresado no es válido.");
            }
            else
            {
                return c;
            }
        }
        public static bool EsOpcionValida(string input, string opcionesValidas)
        {
            try
            {
                if (string.IsNullOrEmpty(input) || input.Length > 1 || !opcionesValidas.ToUpper().Contains(input.ToUpper()))
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
