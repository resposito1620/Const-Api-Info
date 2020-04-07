using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 5;
            int[] lista = new int[cant];
            int intermedio = 0;
            int mayor = 0;
            int menor = 0;
            Console.WriteLine("Empiece a ingresar los 5 números");
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese:");
                lista[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = lista[i];
                    menor = lista[i];
                }
                if (lista[i] > mayor)
                {
                    mayor = lista[i];
                }
                if (lista[i] < menor)
                {
                    menor = lista[i];
                }
            }
            intermedio = lista[((cant + 1) / 2) - 1];
            Console.WriteLine("El número más grande es: " + mayor);
            Console.WriteLine("El número intermedio es: " + intermedio);
            Console.WriteLine("El número más chico es: " + menor);
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
