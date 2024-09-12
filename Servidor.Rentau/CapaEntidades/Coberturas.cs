using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class Coberturas
    {
        private List <Cobertura> arregloCoberturas;
        private int cantidadCoberturas = 0;

        public Coberturas()
        {
            this.arregloCoberturas = new List<Cobertura>();
        }

        //Metodos

        public void ingresarCobertura(Cobertura coberturaNueva) // metodo que recibe un objeto de tipo sucursal
        {          
            arregloCoberturas.Add(coberturaNueva);
            cantidadCoberturas = cantidadCoberturas + 1;
        }

        public string mostrarCoberturas(Cobertura coberturaXmostrar)
        {
            return coberturaXmostrar.IdCobertura + " , " + coberturaXmostrar.Descripcion + " , " + coberturaXmostrar.EstadoAux + " , " + coberturaXmostrar.Monto;
        }


        
        public bool encontrarCobertura(String id)
        {
            bool repetido = false;
            foreach (Cobertura coberturaAux in arregloCoberturas)
            {
                if (coberturaAux != null) //debe verificar porque llega a nulo por ser un arreglo estatico
                {
                    if (coberturaAux.IdCobertura == int.Parse(id))
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
        //getter and setter

        public List<Cobertura> ArregloCoberturas { get { return arregloCoberturas; } set { arregloCoberturas = value; } }

        public int CantidadCoberturas { get { return cantidadCoberturas; } }
    }
}
