using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int posiciones = 693;
            int[] numeros = new int[posiciones];
            int pos = 0;
            string lista = "";
            bool esPrimo = false;
            NumerosPrimos primo = new NumerosPrimos();
            do
            {
                numeros[pos] = pos + 1;
                esPrimo = primo.esPrimo(numeros[pos]);
                if ((numeros[pos] % 3 == 0) && (esPrimo))
                {
                    lista = numeros[pos] + " - Es primo y divisible por 3";
                }
                else if (numeros[pos] % 3 == 0)
                {
                    lista = numeros[pos] + " - Es divisible por 3";
                }
                else if (esPrimo)
                {
                    lista = numeros[pos] + " - Es primo";
                }
                else
                {
                    lista = numeros[pos].ToString();
                }
                Console.WriteLine(lista);
                pos++;
            } while (pos < posiciones);
            Console.ReadKey();
        }
        public class NumerosPrimos
        {
            public Boolean esPrimo(int numeroAEvaluar)
            {
                bool respuesta = false;
                int contadorDivisores = 0;
                for (int i = 1; i <= numeroAEvaluar; i++)
                {
                    int numero = numeroAEvaluar % i;
                    if (numero == 0)
                    {
                        contadorDivisores++;
                    }
                    if (contadorDivisores > 2)
                    {
                        respuesta = false;
                    }
                    if (numeroAEvaluar == i && contadorDivisores <= 2)
                    {
                        respuesta = true;
                    }
                }
                return respuesta;
            }
        }

    }
}
