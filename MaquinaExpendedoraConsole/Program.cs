using ClassGeneral;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarActivo = true;
            string precondicion = "¡Bienvenido a la expendedora de latas de gaseosa!\nPulse:\nO - Encender\nX - Salir.";
            Expendedora appExpendedora = new Expendedora("FCE", 50);
            while (continuarActivo)
            {
                Console.WriteLine(precondicion);
                try
                {
                    string opcionEncendido = Console.ReadLine();
                    if (AyudaConsola.EsOpcionValida(opcionEncendido, "OX"))
                    {
                        if (opcionEncendido.ToUpper() == "O")
                        {
                            appExpendedora.EncenderMaquina();
                            do
                            {
                                Console.Clear();
                                string menu = "Elija la opción deseada:\n1 - Latas disponibles\n2 - Insertar lata\n3 - Comprar lata\n4 - Ver balance\n5 - Stock completo\nX - Salir";
                                Console.WriteLine(menu);
                                string opcionSeleccionada = Console.ReadLine();
                                try
                                {
                                    if (AyudaConsola.EsOpcionValida(opcionSeleccionada, "12345X"))
                                    {
                                        if (opcionSeleccionada.ToUpper() == "X")
                                        {
                                            continuarActivo = false;
                                            continue;
                                        }
                                        switch (opcionSeleccionada)
                                        {
                                            case "1":
                                                Program.ListarLatas(appExpendedora);
                                                break;
                                            case "2":
                                                Program.IngresarLata(appExpendedora);
                                                break;
                                            case "3":
                                                Program.ExtraerLata(appExpendedora);
                                                break;
                                            case "4":
                                                Program.ObtenerBalance(appExpendedora);
                                                break;
                                            case "5":
                                                Program.MostrarStock(appExpendedora);
                                                break;
                                            default:
                                                Console.WriteLine("Opción inválida.");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opción inválida.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error durante la ejecución del comando. Por favor, intente nuevamente: " + ex.Message);
                                }
                                Console.WriteLine("Ingrese una tecla para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                            } while (continuarActivo);
                        }
                        else
                        {
                            continuarActivo = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error durante la ejecución del comando. Por favor, intente nuevamente: " + ex.Message);
                }
            }
            Console.WriteLine("Gracias por utilizar la máquina. Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
        #region
        private static void ListarLatas(Expendedora app)
        {
            foreach (Lata l in app.Latas)
            {
                Console.WriteLine(l.ToString());
            }
        }
        private static void IngresarLata(Expendedora app)
        {
            ListarLatas(app);
            string menuNombre = "Ingrese dos letras para indicar la marca:\nCO - Coca Cola\nSP - Sprite\nFA - Fanta";
            string menuTipo = "Ingrese un número para indicar el tipo de gaseosa:\n1 - Regular\n2 - Zero";
            try
            {
                Console.WriteLine("Código:\n" + menuNombre);
                string ingresoNombre = Console.ReadLine().ToUpper();
                if (ingresoNombre.Length != 2 && ingresoNombre != "CO" && ingresoNombre != "SP" && ingresoNombre != "FA")
                {
                    throw new CodigoIncorrecto();
                }
                Console.WriteLine(menuTipo);
                string ingresoTipo = Console.ReadLine();
                if (ingresoTipo.Length != 1 && ingresoNombre != "1" && ingresoNombre != "2")
                {
                    throw new CodigoIncorrecto();
                }
                string c = ingresoNombre + ingresoTipo;
                double v = AyudaConsola.PedirDouble("volumen:");
                app.AgregarLata(new Lata(c, v));
                Console.WriteLine("Lata agregada con éxito.");
            }
            catch (CodigoIncorrecto ciex)
            {
                Console.WriteLine(ciex.Message);
            }
            catch (NoEspacio capex)
            {
                Console.WriteLine(capex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en uno de los datos ingresados: " + ex.Message + " Intente nuevamente.");
                IngresarLata(app);
            }
        }
        private static void ExtraerLata(Expendedora app)
        {
            ListarLatas(app);
            Console.WriteLine("Ingrese el código de la lata que desea extraer:");
            try
            {
                string codigo = Console.ReadLine();
                if (codigo.Length != 3 && codigo != "CO1" && codigo != "CO2" && codigo != "SP1" && codigo != "SP2" && codigo != "FA1" && codigo != "FA2")
                {
                    throw new CodigoIncorrecto();
                }
                double dinero = AyudaConsola.PedirDouble("dinero:");
                ExtraccionObtenida result = app.ExtraerLata(codigo, dinero);
                if (result.Vuelto != 0)
                {
                    Console.WriteLine("Ha comprado la bebida " + result.Lata.ToString() + "\nSu vuelto es $" + result.Vuelto);
                }
                else if (result.Vuelto == 0)
                {
                    Console.WriteLine("Ha comprado la bebida " + result.Lata.ToString());
                }
            }
            catch (CodigoIncorrecto ciex)
            {
                Console.WriteLine(ciex.Message);
            }
            catch (DineroInsuficiente diex)
            {
                Console.WriteLine(diex.Message);
            }
            catch (NoExisteStock ssex)
            {
                Console.WriteLine(ssex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en uno de los datos ingresados: " + ex.Message + " Intente nuevamente.");
            }
        }
        private static void ObtenerBalance(Expendedora app)
        {
            string balance = app.GetBalance();
            Console.WriteLine(balance);
        }
        private static void MostrarStock(Expendedora app)
        {
            if (app.EstaVacia())
            {
                Console.WriteLine("La máquina expendedora no posee stock.");
            }
            else
            {
                foreach (Lata l in app.Latas)
                {
                    Console.WriteLine(String.Format("{0} - {1} ${2} / $/L {3}", l.Nombre, l.Sabor, l.Precio, l.GetPrecioPorLitro()));
                }
            }
        }
        #endregion
    }
}
