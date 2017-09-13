using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase05;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta unaTinta = new Tinta();
            Tinta dosTintas = new Tinta(ETipoTinta.ConBrillito);
            Tinta tresTintas = new Tinta(ETipoTinta.Comun, ConsoleColor.Magenta);
            Plumas unaPluma = new Plumas();

            Console.Write(Tinta.Mostrar(unaTinta));
            Console.Write(Tinta.Mostrar(dosTintas));
            Console.Write(Tinta.Mostrar(tresTintas));

            Console.Write("\n\nLa primera tinta es igual a la segunda tinta?: {0}\n\n",unaTinta == dosTintas); //compara si unaTinta y dosTintas son iguales

            Console.Write(tresTintas);
            //Console.Write((string)tresTintas); --> esto es esquivalente a la linea de arriba


            Console.Write(unaPluma);
            Console.ReadLine();
                        
        }
    }
}
