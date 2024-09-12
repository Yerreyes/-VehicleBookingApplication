using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class Cobertura
    {
        private int idCobertura = 0;
        private string descripcion = "";
        TipoVehiculo tipoVehiculo;
        private bool estado = false;
        private int monto;

        string estadoAux;
        public Cobertura(int idCobertura, string descripcion, TipoVehiculo tipoVehiculo, bool estado, int monto)
        {
            this.idCobertura = idCobertura;
            this.descripcion = descripcion;
            this.tipoVehiculo = tipoVehiculo;
            this.estado = estado;
            this.monto = monto;

            if (estado)
            {
                estadoAux = "Activo";
            }
            else
            {
                estadoAux = "Inactivo";
            }
        }

        public string ToString()
        {
            return "Id cobertura|  " + idCobertura + "  |Descripción " + descripcion + "  |Monto "  + monto ;
        }

        public int IdCobertura { get { return idCobertura; } set { idCobertura = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public TipoVehiculo TipoVehiculo { get { return tipoVehiculo; } set { tipoVehiculo = value; } }
        public bool IsEstado { get { return estado; } set { estado = value; } }
        public String EstadoAux { get { return estadoAux; } set { estadoAux = value; } }
        public int Monto { get { return monto; } set { monto = value; } }
    }
}
