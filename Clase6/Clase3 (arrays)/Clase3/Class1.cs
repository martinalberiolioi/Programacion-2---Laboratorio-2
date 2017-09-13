using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
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

        public static Tempera operator +(Tempera unaTempera, double aumento)
        {
            unaTempera._cantidad += (int)aumento;

            return unaTempera;
        }
    }
}
