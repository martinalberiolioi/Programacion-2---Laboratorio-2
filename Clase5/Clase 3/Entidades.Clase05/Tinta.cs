<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase05
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        //constructores
        public Tinta()
        {
            this.tipo = ETipoTinta.China;
            this.color = ConsoleColor.Black; 
        }

        public Tinta(ETipoTinta tipo):this()
        {
            this.tipo = tipo; 
        }

        public Tinta(ETipoTinta tipo, ConsoleColor color):this(tipo)
        {
            this.color = color;
        }

            //metodos
            private string Mostrar()
            {
                return "Tipo de tinta: "+this.tipo+"\nColor de tinta: "+this.color+"\n\n";
            }

            public static string Mostrar(Tinta unaTinta)
            {
                return unaTinta.Mostrar();
            }


            public static bool operator ==(Tinta unaTinta, Tinta otraTinta)
            {
                bool valorRetorno = false;

                if (unaTinta.color == otraTinta.color && unaTinta.tipo == otraTinta.tipo)
                {
                    valorRetorno = true;
                }

                return valorRetorno;

            }

            public static bool operator !=(Tinta unaTinta, Tinta otraTinta) //las sobrecargas de operadores necesitan tener su contrario. Por eso si tenemos ==, tiene que existir !=
            {
                return !(unaTinta==otraTinta); //llama a la funcion anterior que es igual, pero niega el resultado
            }

            
            /*public static explicit operator string (Tinta unaTinta) //metodo para convertir un tipo Tinta a String
            {
                return Tinta.Mostrar(unaTinta);
            }*/

            public static implicit operator string(Tinta unaTinta) //OTRO metodo para convertir un tipo Tinta a String
            {
                return unaTinta.tipo.ToString();
            }

                     


    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase05
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        //constructores
        public Tinta()
        {
            this.tipo = ETipoTinta.China;
            this.color = ConsoleColor.Black; 
        }

        public Tinta(ETipoTinta tipo):this()
        {
            this.tipo = tipo; 
        }

        public Tinta(ETipoTinta tipo, ConsoleColor color):this(tipo)
        {
            this.color = color;
        }

            //metodos
            private string Mostrar()
            {
                return "Tipo de tinta: "+this.tipo+"\nColor de tinta: "+this.color+"\n\n";
            }

            public static string Mostrar(Tinta unaTinta)
            {
                return unaTinta.Mostrar();
            }


            public static bool operator ==(Tinta unaTinta, Tinta otraTinta)
            {
                bool valorRetorno = false;

                if (unaTinta.color == otraTinta.color && unaTinta.tipo == otraTinta.tipo)
                {
                    valorRetorno = true;
                }

                return valorRetorno;

            }

            public static bool operator !=(Tinta unaTinta, Tinta otraTinta) //las sobrecargas de operadores necesitan tener su contrario. Por eso si tenemos ==, tiene que existir !=
            {
                return !(unaTinta==otraTinta); //llama a la funcion anterior que es igual, pero niega el resultado
            }

            
            /*public static explicit operator string (Tinta unaTinta) //metodo para convertir un tipo Tinta a String
            {
                return Tinta.Mostrar(unaTinta);
            }*/

            public static implicit operator string(Tinta unaTinta) //OTRO metodo para convertir un tipo Tinta a String
            {
                return unaTinta.tipo.ToString();
            }

                     


    }
}
>>>>>>> refs/remotes/origin/master
