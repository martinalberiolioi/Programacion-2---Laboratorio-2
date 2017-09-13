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
            //crear dos instancias de la clase Auto y mostrarlas
            Auto AutoUno = new Auto();
            Auto AutoDos = new Auto();

            AutoUno.marca = "Ferrari";
            AutoUno.patente = "AB677EM";
            AutoUno.precio = 350000;

            AutoDos.marca = "Lamborghini";
            AutoDos.patente = "AA420MM";
            AutoDos.precio = 550000;

            //AutoUno = AutoDos; --> esto se puede hacer porque ambas variables son del mismo tipo (Auto)
            
            //Console.WriteLine(AutoUno.Mostrar());
            //Console.WriteLine(AutoDos.Mostrar());

            Console.WriteLine(Auto.Mostrar(AutoUno));
            Console.WriteLine(Auto.Mostrar(AutoDos));

            Console.WriteLine("Fecha de primera creacion: {0}", Auto.horaInicio);
            Console.WriteLine("Fecha de ultima creacion: {0}", Auto.horaFin);
            Console.WriteLine("Tiempo pasado de la primera a la ultima creacion: {0}\n", (Auto.horaFin - Auto.horaInicio));
            //si quisiese guardar la diferencia entre dos fechas en una variable, esta variable tendria que ser de tipo TimeSpan

            Console.WriteLine("Cantidad de autos: {0}", Auto.contadorAutos);

            Console.ReadLine();

        }
    }
}
