using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class Vehiculos
    {

        List<Vehiculo> arregloDeVehiculos;
        int cantidadDevehiculos = 0;


        public Vehiculos()
        {
            arregloDeVehiculos = new List<Vehiculo>();
        }   


        public void registrar(Vehiculo vehiculoxregistrar)
        {
            arregloDeVehiculos.Add(vehiculoxregistrar);
            cantidadDevehiculos = cantidadDevehiculos + 1;
        }

        public bool verificarRepetido(Vehiculo vehiculoXregistrar)
        {
            bool repetido = false;
            foreach (Vehiculo vehiculo1 in arregloDeVehiculos)
            {
                if (vehiculo1 != null)
                {
                    if (vehiculo1.Placa == vehiculoXregistrar.Placa)
                    {
                        repetido = true;
                    }
                    else
                    {
                        repetido = false;
                    }
                } else
                {
                    break;
                }      
            }
            return repetido;
        }


        public Vehiculo sacarVehiculo(string placa) // funcion que permite sacar el vehiculo de acuerdo con un indice establecido pasado por parametro// la uso en asociar
        {
            Vehiculo vehiculoEncontrado = new Vehiculo(); 
            foreach (Vehiculo vehiculo1 in arregloDeVehiculos)
            {
                if (vehiculo1 != null)
                {
                    if (vehiculo1.Placa == placa)
                    {
                        vehiculoEncontrado= vehiculo1;
                        
                        break;
                    }
                }
            }  
            return vehiculoEncontrado;  
        }


        public string mostrarVehiculos(Vehiculo vehiculoxmostrar)
        {
            return vehiculoxmostrar.Placa + ", " + vehiculoxmostrar.Marca + ", " + vehiculoxmostrar.Modelo + ", " + vehiculoxmostrar.IdTipoVehiculo + ", " + vehiculoxmostrar.Costo + ", " + vehiculoxmostrar.Kilometraje;
        }


        public int CantidadDeVehiculos { get { return cantidadDevehiculos; } }
        public List<Vehiculo> ArregloDeVehiculos { get { return arregloDeVehiculos; } }


    }
}
