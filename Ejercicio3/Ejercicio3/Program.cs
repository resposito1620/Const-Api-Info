using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3

{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba una palabra y sabrá si es palíndroma :) ");
            String palabra = Console.ReadLine();
            if (esPalindroma(palabra)) Console.WriteLine("Es palíndroma");
            else Console.WriteLine("No es palíndroma");
            Console.ReadLine();
        }

        static Boolean esPalindroma(String cadena)
        {
            Console.WriteLine("Función llamada con => " + cadena);
            if (cadena.Length < 2) return true;
            Console.WriteLine("Vamos a comparar => " + cadena[0]);
            Console.WriteLine("Con => " + cadena[cadena.Length - 1]);
            if (cadena[0] == cadena[cadena.Length - 1]) return esPalindroma(cadena.Substring(1, cadena.Length - 2));
            return false;
        }
    }
}

