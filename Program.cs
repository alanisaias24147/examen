using System;
using pendientes;

namespace examen_3er_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Pendientes pendientes = new pendientes;
            pendientes.push();
            pendientes.push();
            pendientes.push();

            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";

                while (opcion != "1" && opcion != "2" && opcion != "3")
                {
                    Console.WriteLine("ingresa tu nombre");
                    string pendiente = Console.ReadLine();
                    Console.WriteLine("2)agregar pendiente");
                    Console.WriteLine("4)quitar pendiente");
                    Console.WriteLine("6)checar pendiente");
                    Console.WriteLine("8) salir");

                    opcion = Console.ReadLine();

                    if (opcion != "1" && opcion != "2" && opcion != "9")
                    {
                        Console.WriteLine("La opcion seleccionada no es correcta");
                    }
                }

                if (opcion == "2")
                {
                    Console.WriteLine("agregar nota");
                    string nombre = Console.ReadLine();
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("quitar pendiente");
                    string nombre = Console.ReadLine();
                }
                else if (opcion == "6")
                {
                    Console.WriteLine("checar pendiente");
                }
                else if (opcion == "8")
                {
                    Console.WriteLine("salir");
                    
                    
                }
            }
        }
    }
}
