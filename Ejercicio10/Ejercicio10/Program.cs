using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            string numero = "";
            int edad = 0;
            string nombre = "";
            string apellido = "";

            Console.WriteLine("Ingrese nombre, apellido, y edad:");
            cadena = Console.ReadLine();

            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsDigit(cadena[i]))
                {
                    numero += cadena[i];
                }
            }
            if (numero.Length > 0)
            {
                edad = int.Parse(numero);
            }

            string cadenaSinNro = cadena.Trim(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ' });

            String[] palabras = cadenaSinNro.Split(' ');
            nombre = palabras[0];
            apellido = palabras[1];

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Presione cualquier tecla para salir.");

            Console.ReadKey();
        }
    }
}
