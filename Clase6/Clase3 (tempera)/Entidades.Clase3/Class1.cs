using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase3
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        private string mostrar()
        {
            return "Marca: " + this._marca + "\nColor: " + this._color + "\nCantidad: " + this._cantidad + "\n";
        }

        public static string mostrar(Tempera unaTempera)
        {
            return unaTempera.mostrar();
        }

        public static bool operator ==(Tempera unaTempera, Tempera otraTempera)
        {
            bool valorRetorno = false;

            if (unaTempera._marca == otraTempera._marca && unaTempera._color == otraTempera._color)
            {
                valorRetorno = true;
            }

            return valorRetorno;
        }

        public static bool operator !=(Tempera unaTempera, Tempera otraTempera)
        {
            return (!(unaTempera == otraTempera));
        }

        public static Tempera operator +(Tempera unaTempera, double aumento)
        {
            if (aumento >= 0 && ((unaTempera._cantidad + (int)aumento)) <= 100) //si la cantidad de tempera MAS el aumento da 100 o menos...
            {
                unaTempera._cantidad += (int)aumento;
            }

            return unaTempera;
        }

        public static implicit operator int(Tempera unaTempera)
        {
            return unaTempera._cantidad;
            //"toma unaTempera, pasalo a INT y devolvelo"
        }


    }

    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantMaximaColores;

 
        private Paleta(int cantidadColores)
        {
            this._colores = new Tempera[cantidadColores];
            this._cantMaximaColores = cantidadColores;

            for (int i = 0; i < cantidadColores; i++)
            {
                this._colores[i] = new Tempera(ConsoleColor.Magenta, "Maped", 30);
            }
        }

        private Paleta(): this(5) //llama al constructor anterior y le pone 5 (valor por defecto si no tiene parametros)
        {
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        public static explicit operator string(Paleta unaPaleta)
        {
            return unaPaleta.mostrar();
        }

        private string mostrar()
        {
            string auxReturn = "Tintas: \n";

            foreach (Tempera i in this._colores)
            {
                auxReturn += Tempera.mostrar(i) + "\n";
            }

            return "Cantidad maxima de colores: " + this._cantMaximaColores;
        }

        static public bool operator ==(Paleta unaPaleta, Tempera unaTempera)
        {
            bool valorRetorno = false;

            foreach (Tempera temp in unaPaleta._colores)
            {
                if (temp == unaTempera)
                {
                    valorRetorno = true;
                    break;
                }
            }

            return valorRetorno;
        }

        static public bool operator !=(Paleta unaPaleta, Tempera unaTempera)
        {
            return (!(unaPaleta == unaTempera));
        }

        private int buscarEspacio()
        {
            int valorRetorno = -1;

            for (int index = 0; index < this._cantMaximaColores; index++)
            {
                if (this._colores.GetValue(index) == null)
                {
                     valorRetorno = index;
                }
            }

            return valorRetorno;
        }

        private int buscarTempera(Tempera unaTempera)
        {
            int valorRetorno = -1;

            for (int index = 0; index < this._cantMaximaColores; index++)
            {
                if (this._colores.GetValue(index) != null)
                {
                    if (this._colores[index] == unaTempera)
                    {
                        valorRetorno = index;
                    }
                }
                                
            }

            return valorRetorno;
        }


        /*public static Paleta operator +(Paleta unaPaleta, Paleta otraPaleta)
        {
            foreach (Tempera masPaleta in otraPaleta._colores)
            {
                unaPaleta += masPaleta;

            }

            return unaPaleta;
        }*/
 
    }
}
