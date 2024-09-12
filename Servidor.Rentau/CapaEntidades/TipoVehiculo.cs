using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class TipoVehiculo
    {
        string id = "";
        string descripcion = "";
        bool estado;
        
        String estadoAux;

        public TipoVehiculo(string id, string descripcion, bool estado)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.estado = estado;
            transformarDatos();
        }

        public TipoVehiculo()
        {

        }

        public void transformarDatos()
        {
            if (estado)
            {
                estadoAux = "Activo";
            }
            else
            {
                estadoAux = "Inactivo";
            }
        }

        public String MostrarDatos()
        {
            return "[ Id: "+  id + " | Descripción:  " + descripcion + " | Estado:  " + Estado_ + "]";
        }

        public string Id { get { return id; } set { id = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }
        public string Estado_ { get { return estadoAux; } set { estadoAux = value; } }
       
        public override string ToString()
        {
            return Id + " | " + descripcion +" | " + Estado_;
        }
    }
}
