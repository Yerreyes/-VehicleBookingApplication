using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class Sucursales
    {
        
        private int cantidadSucursales = 0;

        private List<Sucursal> arregloSucursal ;

        public Sucursales()
        {
            this.arregloSucursal  = new List<Sucursal>();
        }

        //Metodos

        public void ingresarSucursal(Sucursal sucursal) // metodo que recibe un objeto de tipo sucursal
        {
            if (verificarRepetido(sucursal) == false)
            {    
                arregloSucursal.Add(sucursal);
                cantidadSucursales = arregloSucursal.Count;
            }
          
        }

        public bool verificarRepetido(Sucursal sucursal)
        {
            bool repetido = false;
            foreach (Sucursal sucursalAux in arregloSucursal)
            {
                if (sucursalAux != null) //debe verificar porque llega a nulo por ser un arreglo estatico
                {
                    if (sucursalAux.IdSucursal == sucursal.IdSucursal)
                    {
                        repetido = true;
                        break;
                    }
                    else
                    {
                        repetido = false;
                    }
                }
            }
         return repetido;
        }

        public string mostrarSucursales(Sucursal sucursalXmostrar)
        {
            string estadoConvertido = "";
            if (sucursalXmostrar.Estado != false)
            {
                estadoConvertido = "Activo";
            }
            else
            {
                estadoConvertido = "Inactivo";
            }
            return sucursalXmostrar.IdSucursal + " , " + sucursalXmostrar.Nombre + " , " + estadoConvertido + " , " + sucursalXmostrar.Telefono;
        }



        //getter and setter


        public List<Sucursal> ArregloSucursal { get { return arregloSucursal; } set { arregloSucursal = value; } }

        public int CantidadSucursales { get { return cantidadSucursales; } }


    }
}
