using System;

namespace banimal
{
    class Program
    {        
        static void Main(string[] args)
        {
            string opcion = "";
            Animales datos = new Animales();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tipos de Animales");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Mamiferos");
                Console.WriteLine("2 - Insectos");
                Console.WriteLine("3 - Peces");
                Console.WriteLine("4 - Aves");
                Console.WriteLine("5 - Anfibios");
                Console.WriteLine("6 - Reptiles");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        inventario.listarProductos();
                        break;
                    case "2":
                        inventario.ingresoDeInventario();
                        break;
                    case "3":
                        inventario.salidaDeInventario();
                        break;    
                    case "4":
                        inventario.ajustenegativoDeInventario();
                        break;
                    case "5":
                        inventario.ajustepositivoDeInventario();
                        break;                                        
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}