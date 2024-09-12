using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class VehiculoSucursales
    {
        private List<VehiculoSucursal> arregloVS;
        private int cantidadVehiculoSucursal = 0;
        private int cantidadVehiculosAsociados = 0;

        public VehiculoSucursales() {
            arregloVS = new List<VehiculoSucursal>();
        }
        
        public bool ingresarVehiculoSucursal(VehiculoSucursal vehiculoparasucursal) // metodo que recibe un objeto de tipo vehiculoSucursal
        {
            bool ingresado = false;
            
            if (existenciaSucursal1(vehiculoparasucursal.Sucursal.IdSucursal) == false)
            {
                arregloVS.Add(vehiculoparasucursal);
                cantidadVehiculoSucursal = cantidadVehiculoSucursal + 1;
                cantidadVehiculosAsociados = cantidadVehiculoSucursal + 1;
                ingresado = true;
                

            } else
            {
                annadirVehiculoAsucursal(vehiculoparasucursal.IdAsignacion,vehiculoparasucursal.Sucursal, vehiculoparasucursal.Vehiculo);
                ingresado = true;
            } 
           
            return ingresado;
        }

        public void annadirVehiculoAsucursal(int id ,Sucursal sucursal, Vehiculo vehiculo)
        {
            foreach (VehiculoSucursal vehiculoSucursal in arregloVS)
            {
                if (vehiculoSucursal != null)
                {
                    if (vehiculoSucursal.Sucursal.IdSucursal == sucursal.IdSucursal)
                    {
                        vehiculo.NumeroDeAsignacion = id;
                        vehiculoSucursal.ingresarVehiculo(vehiculo);
                        cantidadVehiculosAsociados = cantidadVehiculosAsociados + 1;
                    }
                }
            }
        }

        public VehiculoSucursal existenciaSucursal2(int idSucursal) {
            VehiculoSucursal existe;
            existe = null;
            foreach (VehiculoSucursal vehiculoSucursal in arregloVS)
            {   
                if (vehiculoSucursal != null)
                {
                    if (vehiculoSucursal.Sucursal.IdSucursal == idSucursal)
                    {     
                        existe = vehiculoSucursal;
                        break;
                    }
                    
                } 
            }
            return existe;
        }

        public bool existenciaSucursal1(int idSucursal)
        {
            bool existe = false;
            foreach (VehiculoSucursal vehiculoSucursal in arregloVS)
            {
                if (vehiculoSucursal != null)
                {
                    if (vehiculoSucursal.Sucursal.IdSucursal == idSucursal)
                    {
                        existe = true;
                        break;
                    }

                }       
            }
            return existe;
        }

        public List<VehiculoSucursal>  ArregloVS { get { return arregloVS; } }

        public int CantidadVehiculoSucursal { get { return cantidadVehiculoSucursal; } set { cantidadVehiculoSucursal = value; } }

        public int CantidadVehiculosAsociados { get { return cantidadVehiculosAsociados; } }

    }
}
