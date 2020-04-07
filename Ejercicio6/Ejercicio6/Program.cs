using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int resultado = 0;
          
                Console.WriteLine("Ingrese el primer número:");
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Error. No ha ingresado un número.");
                } 
           
                Console.WriteLine("Ingrese el segundo número:");
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Error. No ha ingresado un número.");
                }
           
            resultado = (a + b) * (a - b);
            Console.WriteLine("Diferencia de cuadrados: " + resultado);
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
