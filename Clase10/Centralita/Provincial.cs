using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Constructores

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(origen, destino, duracion)
        {
            base._duracion = duracion;
            base._nroDestino = destino;
            base._nroOrigen = origen;

            this._franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {
        }
           

        #endregion

        #region Metodos

        private float CalcularCosto()
        {
            float costo = 0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = (float)0.99 * this._duracion;
                    break;
                case Franja.Franja_2:
                    costo = (float)1.25 * this._duracion;
                    break;
                case Franja.Franja_3:
                    costo = (float)0.66 * this._duracion;
                    break;
                default:
                    break;
            }

            return costo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append(this._franjaHoraria);
            sb.Append(CostoLlamada);

            return sb.ToString();
        }

        #endregion

    }
}
