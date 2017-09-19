using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{

    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        #region Propiedades

        /*public float GananciaPorLocal
        {
            get
            {
                
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
 
            }
        }

        public float GananciaTotal
        {
            get
            {
 
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
 
            }
        }*/



        #endregion

        #region Constructores

        public Centralita()
        {
            this._razonSocial = "";
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        #endregion

        #region Metodos

        private float CalcularGanancia(TipoLlamada Tipo)
        {
            float ganancia = 0;

            switch (Tipo)
            {
                case TipoLlamada.Local:

                    break;
                case TipoLlamada.Provincial:

                    break;
                case TipoLlamada.Todas:

                    break;
                default:
                    break;
            }

            return ganancia;
            
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Razon social: ");
            sb.AppendLine(this._razonSocial);
            sb.Append("Ganancia total: ");
            //sb.AppendLine(CalcularGanancia().ToString());
            sb.Append("Ganancia por llamados locales: ");
            sb.AppendLine(CalcularGanancia(TipoLlamada.Local).ToString());
            sb.Append("Ganancia por llamados provinciales: ");
            sb.AppendLine(CalcularGanancia(TipoLlamada.Provincial).ToString());

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
 
        }
        #endregion
    }

}
