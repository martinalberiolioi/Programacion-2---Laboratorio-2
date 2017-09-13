using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Auto
    {
        public string marca;
        public string patente;
        public float precio;
        public static int contadorAutos;
        public static DateTime horaInicio;
        public static DateTime horaFin;
        
        private string Mostrar()
        {
            return "Marca: " + this.marca + "\nPatente: " + this.patente + "\nPrecio: " + this.precio+"\n";
            //this --> todo atributo que utilice de una clase tiene que estar acompañado por el THIS
        }

        public static string Mostrar(Auto car)
        {
            //return "Marca: " + car.marca + "\nPatente: " + car.patente + "\nPrecio: " + car.precio + "\n";
            return car.Mostrar();
        }

        public Auto() //cada vez que se pone un new, cuenta un auto
        {
       
            if (contadorAutos == 0)
            {
                Auto.horaInicio = DateTime.Now;
            }
            else
            {
                Auto.horaFin = DateTime.Now;
            }

            Auto.contadorAutos++;
        }

    }
}
