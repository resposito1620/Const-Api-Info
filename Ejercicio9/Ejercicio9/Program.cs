using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int comprobacion = 0;
            do
            {
                Console.WriteLine("Ingrese su nombre, por favor:");
                nombre = Console.ReadLine();
                if (!int.TryParse(nombre, out comprobacion))
                {
                    Console.WriteLine("¡Hola " + nombre + "!");
                }
                else
                {
                    Console.WriteLine("No te conozco.");
                }
            } while (int.TryParse(nombre, out comprobacion));
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
