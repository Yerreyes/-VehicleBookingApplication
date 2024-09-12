using System.Collections;

namespace Tarea1_YerlinReyes
{
    public class VehiculoSucursal
    {

        DateTime fechaAsignacion;
        Sucursal surcursal;
        private List<Vehiculo> arregloConVehiculos;
        private int cantidadDeVehiculosEnSucursal = 0;

        Vehiculos vehiculos;
        ArrayList arregloAux;
        Vehiculo vehiculo;
        int idAsignacion;

        public VehiculoSucursal(int id, Sucursal surcursal, Vehiculo vehiculo, Vehiculos vehiculos, DateTime fecha)
        {
            arregloAux = new ArrayList();
            arregloConVehiculos = new List<Vehiculo>();
            this.vehiculo = vehiculo;
            this.surcursal = surcursal;
            this.vehiculos = vehiculos;
            this.fechaAsignacion = fecha;
            this.idAsignacion = id;
            vehiculo.NumeroDeAsignacion = id;
            ingresarVehiculo(vehiculo);
        }
        public VehiculoSucursal(int id, Sucursal surcursal, Vehiculo vehiculo,  DateTime fecha)
        {
            this.idAsignacion= id;
            this.surcursal = surcursal;
            this.vehiculo = vehiculo;
            this.fechaAsignacion= fecha;
            
        }

        public VehiculoSucursal()
        {
        }

       
        public void ingresarVehiculo(Vehiculo vehiculo) // metodo que ingresa vehiculo a arreglo de vehiculos para esa sucursal
        {
            arregloConVehiculos.Add(vehiculo);
            cantidadDeVehiculosEnSucursal++;
        }

        public void quitarVehiculo(String placaAux)
        {
            foreach (Vehiculo vehiculo in arregloAux)
            {
                if (vehiculo != null)
                {
                    if (vehiculo.Placa == placaAux)
                    {
                        arregloAux.Remove(vehiculo);
                        break;
                    }
                }
            }
        }

        public String mostrarDatos()
        {
            return idAsignacion.ToString() + ", " + (String)surcursal.Tostring();
        }

        public int IdAsignacion { get { return idAsignacion; } set { idAsignacion = value; } }
        public DateTime FechaAsignacion { get { return fechaAsignacion; } set { fechaAsignacion = value; } }
        public Sucursal Sucursal { get { return surcursal; } set { surcursal = value; } }
        public List<Vehiculo> ArregloConVehiculos { get { return arregloConVehiculos; } set { arregloConVehiculos = value; } }
        public int CantidadDeVehiculosEnSucursal { get { return cantidadDeVehiculosEnSucursal; } set { cantidadDeVehiculosEnSucursal = value; } }
        public ArrayList ArregloAux { get { return arregloAux; } set { arregloAux = value; } }
        public Vehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }
    }
}
