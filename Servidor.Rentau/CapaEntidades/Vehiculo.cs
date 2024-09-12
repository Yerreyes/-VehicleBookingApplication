using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class Vehiculo
    {
        string placa;
        string marca;
        string modelo;
        int costo;
        int kilometraje;
        int idTipoVehiculo;
        int numeroDeAsignacion;
      
        public Vehiculo( string placa, string marca, string modelo, int costo, int kilometraje, int idTipoVehiculo)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo; 
            this.costo = costo;
            this.kilometraje = kilometraje;
            this.idTipoVehiculo = idTipoVehiculo;
        }

        public Vehiculo() { }

        public String ToString1()
        {
            return  "[Vehículo:" + placa + ",  " + marca + ",  " + modelo + ",  " + idTipoVehiculo + ", " + costo + ",  "  + kilometraje + " ], ";
        }

        public String mostrar()
        {
            return "Vehículo | Id: " + placa + " |Marca:  " + marca + " |Modelo: " + modelo + "  ";
        }


        public string Placa { get { return placa; } set { placa = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public int Costo { get { return costo; } set { costo = value; } }
        public int Kilometraje { get { return kilometraje; } set { kilometraje = value; } }
        public int IdTipoVehiculo { get { return idTipoVehiculo; } set { idTipoVehiculo = value; } }
        public int NumeroDeAsignacion { get { return numeroDeAsignacion; } set { numeroDeAsignacion = value; } }
      
        public override string ToString()
        {
            return "| Id: " +  Placa + " |Marca:  " + marca + " |Modelo: " + modelo;
        }
    }
}
