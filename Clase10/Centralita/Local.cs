using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    class Local:Llamada
    {
        protected float _costo;

        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return this._costo;
            }
        }

        #endregion

        #region Constructores

        public Local(Llamada unaLlamada, float costo)
            : base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._costo = costo;
        }
       
        public Local(string origen, float duracion, string destino, float costo):base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        
        #endregion

        #region Metodos

        private float CalcularCosto()
        {
            return (this._duracion * this._costo);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append(CostoLlamada);

            return sb.ToString();
        }

        #endregion
    }
}
