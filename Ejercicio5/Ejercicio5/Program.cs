using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nroIngresado = "";
            int comprobacion = 0;
            string cadenaInvertida = "";
            do
            {
                Console.WriteLine("Ingrese un número:");
                nroIngresado = Console.ReadLine();
                if (!int.TryParse(nroIngresado, out comprobacion))
                {
                    Console.WriteLine("Error. No se ingresó un número.");
                }
            } while (!int.TryParse(nroIngresado, out comprobacion));
            foreach (char letra in nroIngresado)
            {
                cadenaInvertida = letra + cadenaInvertida;
            }
            Console.WriteLine("El número invertido es: " + cadenaInvertida);
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}