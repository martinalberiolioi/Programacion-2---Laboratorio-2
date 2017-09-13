using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;
        ConsoleColor Color;

        /// <summary>
        /// Inicializa todo en 0
        /// </summary>
        /// 
        public Cosa()
        {
            this.entero = 0;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        /// <summary>
        /// Inicializa todo en 0, a excepcion del entero, que se inicializa por parametro
        /// </summary>
        /// <param name="entero">Se ingresa el valor del entero</param>
        /// 
        public Cosa(int entero):this()//el ":this()" llama a la sobrecarga sin parametros. Esto me permite repetir codigo, inicializando la fecha en Now y el string en "Sin valor"
        {
            this.entero = entero; //inicializa el entero con el parametro
        }


        /// <summary>
        /// Inicializa la fecha en 0. El entero y la cadena se inicializa por parametro
        /// </summary>
        /// <param name="entero">Se ingresa el valor del entero</param>
        /// <param name="cadena">Se ingresa el valor de la cadena</param>
        /// 
        public Cosa(int entero, string cadena):this(entero)
        {
            this.cadena = cadena;
        }

        public Cosa(DateTime fecha, int entero, string cadena): this(entero, cadena)
        {
            this.fecha = fecha; //hereda entero, string y fecha del constructor, pero aca mismo le pongo la fecha que YO quiero
        }

        /// <summary>
        /// Establece valor de entero
        /// </summary>
        /// <param name="entero">Se ingresa entero</param>
        /// 
        public void establecerValor(int entero)
        {
            this.entero = entero;
        }

        /// <summary>
        /// Estable valor de una cadena
        /// </summary>
        /// <param name="cadena">Se ingresa una cadena</param>
        /// 
        public void establecerValor(string cadena)
        {
            this.cadena = cadena;

        }


        /// <summary>
        /// Establece fecha
        /// </summary>
        /// <param name="fecha">Se ingresa la fecha actual</param>
        /// 
        public void establecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void establecerValor(ConsoleColor color)
        {
            this.Color = ConsoleColor.DarkBlue;
        }

        /// <summary>
        /// Muestra los valores de la clase
        /// </summary>
        /// <returns></returns>
        /// 
        public string Mostrar()
        {
            return "Entero: "+this.entero+"\nCadena: "+this.cadena+"\nFecha: "+this.fecha+"\n\n"; 
        }

        public string Mostrar(ConsoleColor color)
        {
            Console.ForegroundColor = color; //pone que el tipeado de la consola sea del color que ingrtesa por parametro

            return "Entero: " + this.entero + "\nCadena: " + this.cadena + "\nFecha: " + this.fecha + "\n\n"; 
        }


    }
}
