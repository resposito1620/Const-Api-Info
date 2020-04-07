using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 0;
            int mes = 0;
            int año = 0;

            DateTime fechaActual = DateTime.Today;

            Console.WriteLine("Ingrese un día:");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un mes:");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un año:");
            año = int.Parse(Console.ReadLine());

            DateTime fechaUsuario = new DateTime(año, mes, dia);
            TimeSpan diferencia = fechaUsuario - fechaActual;
            int resultadoDias = diferencia.Days;

            Console.WriteLine("La diferencia de fechas es de " + resultadoDias + " días.");

            Console.WriteLine("Presione cualquier tecla para salir.");

            Console.ReadLine();
        }
    }
}
