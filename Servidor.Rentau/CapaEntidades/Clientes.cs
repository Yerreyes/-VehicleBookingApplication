
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class Clientes

    {
        List<Cliente> arregloClientes; 
        private  int cantidadClientes = 0;

        //Constructor
        public Clientes()
        {
            this.arregloClientes = new List<Cliente>();
        }

        public void ingresarCliente(Cliente cliente) // metodo que recibe un objeto de tipo cliente
        {
            arregloClientes.Add(cliente);
            cantidadClientes++; 
        }

        public bool verificarRepetido(Cliente cliente)
        {
            bool repetido = false;
            foreach (Cliente cliente1 in arregloClientes)
            {
                if (cliente1 != null)
                {
                    if (cliente1.Identificacion == cliente.Identificacion)
                    {
                        repetido = true;
                    }
                    else
                    {
                        repetido = false;
                    }
                }
            }
            return repetido;
        }

        public string mostrarCliente(Cliente clienteXmostrar)
        {
            return clienteXmostrar.Identificacion + ", " + clienteXmostrar.Nombre + ", " + clienteXmostrar.PrimerApellido + ", " + clienteXmostrar.SegundoApellido + ", " + clienteXmostrar.Nacimiento + ", " + clienteXmostrar.Genero;
        }

        public List<Cliente> ArregloClientes { get { return arregloClientes; } set { arregloClientes = value; } }

        public int CantidadClientes { get { return cantidadClientes; } }
    }
}
