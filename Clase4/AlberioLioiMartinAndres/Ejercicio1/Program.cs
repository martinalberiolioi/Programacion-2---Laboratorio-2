using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa unaCosa = new Cosa();
            Cosa otraCosa = new Cosa(25);
            Cosa unaCosaMas = new Cosa(50, "Todo ok");
            Cosa unaMas = new Cosa(new DateTime(1998, 01, 18), 500, "otra prueba");

            Console.Write(unaCosa.Mostrar()); //muestra los valores por defecto

            unaCosa.establecerValor(15);
            unaCosa.establecerValor("Hola");
            unaCosa.establecerValor(DateTime.Now);

            Console.Write(unaCosa.Mostrar()); //vuelve a mostrar pero los valores cambiados en la linea anterior
            Console.Write(otraCosa.Mostrar());
            Console.Write(unaCosaMas.Mostrar());
            Console.Write(unaMas.Mostrar());
            Console.Write(unaMas.Mostrar(ConsoleColor.Red));

            Console.ReadLine();
        }
    }
}
