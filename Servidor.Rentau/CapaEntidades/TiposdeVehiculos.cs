
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea1_YerlinReyes
{
    public  class TiposdeVehiculos
    {
        private List <TipoVehiculo> arregloDeTipos;
        private  int cantidadDeTipos = 0;

        public TiposdeVehiculos()
        {
            arregloDeTipos = new  List<TipoVehiculo>();
        }

        public void registrarTipo(TipoVehiculo tipoVehiculo)
        {            
            arregloDeTipos.Add( tipoVehiculo);   
            cantidadDeTipos++;
        }



        public string mostrarTipos(TipoVehiculo tipoXmostrar)
        {
            string estadoConvertido = "";
            if (tipoXmostrar.Estado != false)
            {
                estadoConvertido = "Activo";
            }
            else
            {
                estadoConvertido = "Inactivo";
            }
            return "ID:  "+  tipoXmostrar.Id + "  |  Descripción:  " + tipoXmostrar.Descripcion + "  | Estado:  " + estadoConvertido;
        }


        public string mostrarTipoVehiculoConid(string id) // metodo para mostrar todo del tipo de vehiculo a partir del id de tipo de vehiculo
        {
            string estadoConvertido = "";
            string resultado = "";
            foreach (TipoVehiculo tipo1 in arregloDeTipos)
            {
                if (tipo1 != null)
                {
                    {
                        if (tipo1.Estado != false)
                        {
                            estadoConvertido = "Activo";
                        }
                        else
                        {
                            estadoConvertido = "Inactivo";
                        }
                        resultado = "ID:  " + tipo1.Id + "  |  Descripción:  " + tipo1.Descripcion + "  | Estado:  " + estadoConvertido;
                        break;
                    }
                }
            }
           return resultado;    
 
        }


        public int CantidadDeTipos { get { return cantidadDeTipos; } }
        public  List<TipoVehiculo> ArregloDeTipos { get { return arregloDeTipos; } }

    }
}
