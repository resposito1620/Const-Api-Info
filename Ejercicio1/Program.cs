using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            mostrarPorPantalla(889693);

            Console.ReadKey();
        }

        /* Ejercicio 1
         * Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del propio número de registro (en caso de ser comenzar con 0, sumarle 100), 
         * todos los números deben mostrarse por pantalla y, con los múltiplos de 3 se debera agregar “Foo”, con los múltiplos de 5, “Bar”, y, por último, 
         * con los múltiplos de ambos, “FooBar”. Por ejemplo, con el número mostrará “15 – FooBar”.
         */
        static void mostrarPorPantalla(int numeroRegistro)
        {
            string nroRegistro = numeroRegistro.ToString();
            string ultimosTresDigitos = nroRegistro.Substring(nroRegistro.Length - 3, 3);

            if (ultimosTresDigitos[0] == '0')
            {
                ultimosTresDigitos = "1" + ultimosTresDigitos[1] + ultimosTresDigitos[2];
            }

            int ultimosTresInt = int.Parse(ultimosTresDigitos);

            for (int digito = 1; digito <= ultimosTresInt; digito++)
            {
                if (digito % 3 == 0 && digito % 5 == 0)
                {
                    Console.WriteLine("Mi numero es: " + digito + ", FooBar");
                }
                else if (digito % 3 == 0)
                {
                    Console.WriteLine("Mi numero es: " + digito + ", Foo");
                }
                
                else  if (digito % 5 == 0)
                {
                    Console.WriteLine("Mi numero es: " + digito + ", Bar");
                }

            }

        }
    }
}
