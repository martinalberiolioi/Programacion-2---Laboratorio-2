using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase3;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera tempera1 = new Tempera(ConsoleColor.Blue, "Colorin", 5);
            Tempera tempera2 = new Tempera(ConsoleColor.Green, "Maped", 20);

            Paleta paleta1 = 8;

                                              

            Console.WriteLine(Tempera.mostrar(tempera1));
            Console.WriteLine(Tempera.mostrar(tempera2));

            Console.WriteLine("Aumento de tempera:");
            Console.WriteLine(tempera1+5);

            Console.WriteLine("¿Ambas temperas son iguales?");
            Console.WriteLine(tempera1 == tempera2);

            Console.WriteLine("\n\nPALETA:");
            Console.WriteLine((string)paleta1);
                                    

            Console.ReadLine();
            
                
        }
    }
}
