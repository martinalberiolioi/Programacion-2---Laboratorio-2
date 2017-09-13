using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_rueda_auto
{
    class Rueda
    {
        public string marca;
        public int tamaño;

        public Rueda()
        {
            this.marca = "Sin marca";
            this.tamaño = 165;
        }

    }

    class Auto
    {
        public string fabricante;
        public Rueda ruedaDD = new Rueda();
        public Rueda ruedaDI = new Rueda();
        public Rueda ruedaTD = new Rueda();
        public Rueda ruedaTI = new Rueda();

        /*public Auto() //  C. RELACION DE COMPOSICION DE CLASES
        {
            ruedaDD.marca = "Pirelli";
            ruedaDD.tamaño = 165;

            ruedaDI.marca = "Pirelli";
            ruedaDI.tamaño = 165;

            ruedaTD.marca = "Pirelli";
            ruedaTD.tamaño = 165;

            ruedaTI.marca = "Pirelli";
            ruedaTI.tamaño = 165;
        }*/

        

    }
}
