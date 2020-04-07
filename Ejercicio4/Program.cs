using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su primera palabra: ");
            string palabra1 = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese su segunda palabra: ");
            string palabra2 = Console.ReadLine().ToLower();

            if(palabra1.Length != palabra2.Length)
            {
                Console.WriteLine("Lo sentimos! Las dos palabras ingresadas, no son anagramas");
            }
            else
            {
                for(int i1 = 0; i1 < palabra1.Length; i1++)
                {
                    for(int i2 = 0; i2 < palabra2.Length; i2++)
                    {
                        if(palabra1[i1] == palabra2[i2])
                        {
                            palabra2 = palabra2.Remove(i2, 1);
                        }
                    }
                }
                if(palabra2.Length == 0)
                {
                    Console.WriteLine("Estas palabra son anagramas");
                }
                else
                {
                    Console.WriteLine("Estas palabras NO son anagramas");
                }
            }
            Console.WriteLine("Para salir, presione cualquier tecla");
            Console.ReadKey();
        }
    }
}