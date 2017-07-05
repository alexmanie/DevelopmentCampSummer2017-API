using DevelopmentCamp.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() < 1) Console.WriteLine("Debes pasar al menos 1 argumento.");
            else
            {
                string param = args[0];

                switch (param)
                {
                    case "CreateProduct":
                        ProductosHandler.CreateProducto();
                        break;
                    case "ReadProduct":
                        var listP = ProductosHandler.GetAll();
                        foreach (var product in listP)
                        {
                            Console.WriteLine($"{product.Nombre} [{product.FechaLanzamiento}]");
                        }
                        break;
                    default:
                        break;
                }

            }

            Console.Write("Salir ....");
            Console.ReadLine();
        }
    }
}
