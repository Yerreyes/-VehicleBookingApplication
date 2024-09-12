using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Rentau
{
    public partial class ConsultarReservaForm : Form
    {
        Tarea1_YerlinReyes.Cliente cliente;

        public ConsultarReservaForm(Tarea1_YerlinReyes.Cliente cliente)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cliente = cliente;
            label3.Text = "Identificación: " + cliente.Identificacion.ToString();
            labelCliente1.Text = "Cliente: " + cliente.Nombre + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido;
        }

        private void buttonReservaciones_Click(object sender, EventArgs e)
        {
            List<ReservaVehiculo> lista = ClienteTCP.reservasDeCliente(cliente.Identificacion);
            if ( lista.Count > 0) {
                dataGridViewReservaciones.DataSource = lista;
            }else
            {
               
                MessageBox.Show("No tiene reservaciones");
                dataGridViewReservaciones.DataSource = null;
            }


        }

        private void buttonReservacion_Click(object sender, EventArgs e)
        {
            if (textBoxIdReserva.Text != "")
            {
                if (obtenerReservaXid(Convert.ToInt32(textBoxIdReserva.Text)).Count > 0)
                {
                    dataGridViewReservaciones.DataSource = "";
                    dataGridViewReservaciones.DataSource = obtenerReservaXid(Convert.ToInt32(textBoxIdReserva.Text));
                }
                else
                {
                    MessageBox.Show("Ese id de reservación no existe, para ese cliente");
                    dataGridViewReservaciones.DataSource = "";  
                }
            }
            else
            {
                dataGridViewReservaciones.DataSource = "";
                MessageBox.Show("Debe completar el id reserva");
            }

        }

        public List<ReservaVehiculo> obtenerReservaXid(int idReserva)
        {
            List<ReservaVehiculo> lista = new List<ReservaVehiculo>();
            lista.AddRange( ClienteTCP.reservasDeCliente(cliente.Identificacion));

            List<ReservaVehiculo> listaAux = new List<ReservaVehiculo>();
            listaAux.AddRange(lista);
            if (lista != null)
            {
                foreach (ReservaVehiculo reservaVehiculo in lista)
                {
                    if (reservaVehiculo.idReserva != idReserva)
                    {
                        listaAux.Remove(reservaVehiculo);
                    }
                }
            }
            return listaAux;
        }
    }
}
