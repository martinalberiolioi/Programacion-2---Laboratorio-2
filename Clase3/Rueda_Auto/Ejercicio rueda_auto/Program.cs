using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_rueda_auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda ruedaUno = new Rueda();
            Rueda ruedaDos = new Rueda();
            Rueda ruedaTres = new Rueda();

            Auto autoUno = new Auto();

            Console.Write("Marca: {0}   Tamaño: {1}", ruedaUno.marca, ruedaUno.tamaño);
            Console.ReadLine();


        }
    }
}
