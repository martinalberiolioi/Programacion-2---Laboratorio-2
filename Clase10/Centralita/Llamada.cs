using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #region Propiedades

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        #endregion

        #region Constructores

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        #endregion

        #region Metodos

        public string Mostrar()
        {
            return "Numero de origen: " + this._nroOrigen + "\nNumero de destino: " + this._nroDestino + "\nDuracion: " + this._duracion + "\n";
        }

        public int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            int retorno;

            if (llamadaUno._duracion > llamadaDos._duracion)
            {
                retorno = 1;
            }
            else if (llamadaUno._duracion < llamadaDos._duracion)
            {
                retorno = -1;
            }
            else
            {
                retorno = 0;
            }

            return retorno;
 
        }

        #endregion

    }
}
