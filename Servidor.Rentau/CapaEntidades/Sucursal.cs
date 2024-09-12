using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class Sucursal // Clase para los objetos 
    {
        // Atributos
        private int idSucursal = 0;
        private string nombre = "";
        private string direccion = "";
        private bool estado = false;
        private string telefono = "";
        String estadoAux;


        //constructores

        public Sucursal(int idSucursal, string nombre, string direccion, bool estado, string telefono)
        {
            this.idSucursal = idSucursal;
            this.nombre = nombre;
            this.direccion = direccion;
            this.estado = estado;
            this.telefono = telefono;
            transformarDatos();
        }

        public Sucursal() { }

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

        public String Tostring()
        {
            return " Id: | " + idSucursal.ToString() + " | Nombre: "  + nombre + "| Direccion: "  + direccion;
        }

        //getter and setter
        public int IdSucursal { get { return idSucursal; } set { idSucursal = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }
        public string Estado_ { get { return estadoAux; } }
        public override string ToString()
        {
            return " Id: | " + IdSucursal + " | Nombre: " + Nombre + " | Direccion: " + Direccion;
        }
    }
}

