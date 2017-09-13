using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase05
{
    public class Plumas
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        //constructores
        public Plumas()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 0; 
        }

        public Plumas(string marca):this()
        {
            this._marca = marca; 
        }

        public Plumas(string marca, Tinta tinta):this(marca)           
        {
            this._tinta = tinta; 
        }

        public Plumas(string marca, Tinta tinta, int cantidad): this(marca, tinta)           
        {
            this._cantidad = cantidad;               
        }

        //-----------------------------------------

        //instancias
        private string Mostrar()
        {
            return "Marca: " + this._marca + "\nTinta: " + this._tinta + "\nCantidad: " + this._cantidad + "\n";
        }

        public static bool operator ==(Plumas pluma, Tinta tinta)
        {
            bool valorRetorno = false;

            if (pluma._tinta == tinta)
            {
                valorRetorno = true;    
            }

            return valorRetorno;
        }

        public static bool operator !=(Plumas pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Plumas operator +(Plumas pluma, Tinta tinta)
        {

            if (pluma == tinta && pluma._cantidad <= 100)
            {
                pluma._cantidad++;
            }

            return pluma;
        }

        public static Plumas operator -(Plumas pluma, Tinta tinta)
        {

            if (pluma == tinta && pluma._cantidad >= 0)
            {
                pluma._cantidad--;
            }

            return pluma;
        }


        public static implicit operator string(Plumas pluma)
        {
            return pluma.Mostrar();

        }


        
    }
}
