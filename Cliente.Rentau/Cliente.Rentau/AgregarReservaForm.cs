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
using Tarea1_YerlinReyes;

namespace Cliente.Rentau
{
    public partial class agregar_reserva : Form
    {
        Tarea1_YerlinReyes.Cliente cliente;

        public agregar_reserva(Tarea1_YerlinReyes.Cliente cliente)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            visualiarSucursales(); // muesrtra las sucursales activas en el combobox
            this.cliente= cliente;
            labelCliente.Text = "Cliente: " + cliente.Nombre + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido;
            label7.Text = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarReservacionTotal();
            groupBoxHacerReserva.Enabled = true;
        }

        ReservaVehiculo nuevaReserva;
        private void buttonDisponibilidad_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                 nuevaReserva= new ReservaVehiculo();

                //Asigno Valores
                nuevaReserva.idReserva = Convert.ToInt32(textBox1.Text);
                nuevaReserva.Placa = obtenerVehiculoSleccionado();
                nuevaReserva.idCliente = cliente.Identificacion;
                nuevaReserva.fechaReserva = DateTime.Now;
                nuevaReserva.fechaInicio = dateTimePicker1.Value;
                nuevaReserva.fechafinal = dateTimePicker2.Value;
                nuevaReserva.montoReserva = 0;
                


                //Se agrega la sucursal mediante la conexión tcp

              

                if (!ClienteTCP.RangoReservaciones(nuevaReserva)) // si es false es porque en esas fechas aún no esta en uso. 
                {
                    obtenerCobertura();
                    comboBoxCoberturas.Enabled = true;
                    labelElejir.Enabled = true;
                    buttonResumen.Enabled = true;   
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(" Debe completar los datos y dar Reserva Final");
                    comboBoxCoberturas.Enabled = false;
                    labelElejir.Enabled = false;
                    buttonResumen.Enabled = false;
                    comboBoxCoberturas.Items.Clear();
                    MessageBox.Show("Para esas fechas el vehiculo ya se encuentra reservado");
                }
              
            }
            else
            {
                MessageBox.Show("Debe llenar id reserva");
            }
        }

        public int obtenerSucursalElegida()
        {
            int sacar = -1;
            sacar = ClienteTCP.ObtenerSucursales()[comboBoxSucursales.SelectedIndex].IdSucursal;
            return sacar;
        }

        public void visualiarSucursales()
        {
            foreach (Sucursal sucursal in ClienteTCP.ObtenerSucursales()) // consulta mediante tcp
            {
                if (sucursal != null)
                {
                    comboBoxSucursales.Items.Add(sucursal.Tostring());
                }
                else
                {
                    MessageBox.Show("no hay sucursales");
                }
            }
        }

        List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public void visualizarVehiculo()
        {
            foreach (VehiculoSucursal VS in ClienteTCP.ObtenerVehiculoSucursal())
            {
                if (VS != null)
                {
                    if (VS.Sucursal.IdSucursal == obtenerSucursalElegida())
                    {
                        dataGridViewVehiculos.Columns.Clear();
                        dataGridViewVehiculos.DataSource = VS.ArregloConVehiculos;
                        if (VS.ArregloConVehiculos != null) { 
                        listaVehiculos.AddRange(VS.ArregloConVehiculos);
                        } 
                    }
                }
            }
        }

        private void comboBoxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            visualizarVehiculo();
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
        

        public string obtenerVehiculoSleccionado()
        {
            string idVehiculo = "";
            DataGridViewSelectedRowCollection Seleccionados =  dataGridViewVehiculos.SelectedRows;
            foreach (DataGridViewRow item in Seleccionados)
            {
                idVehiculo = item.Cells[0].Value.ToString();
               
            }
          return idVehiculo;
        }

        List<Cobertura> listaConCoberturas = new List<Cobertura>();
        public void obtenerCobertura()
        {
            
            int idTipo = 0;
            DataGridViewSelectedRowCollection Seleccionados = dataGridViewVehiculos.SelectedRows;
            foreach (DataGridViewRow item in Seleccionados)
            {
                idTipo = Convert.ToInt32( item.Cells[5].Value.ToString());
               
            }

            bool existe = false;
           foreach ( Cobertura cobertura in ClienteTCP.cargarCoberturas())
            {
                if (Convert.ToInt32(cobertura.TipoVehiculo.Id) == idTipo && cobertura.IsEstado == true)
                {
                    comboBoxCoberturas.Items.Clear();
                    comboBoxCoberturas.Items.Add(cobertura.ToString());
                    existe = true;
                    listaConCoberturas.Add(cobertura);
                }
            }

           if (!existe )
            {
                comboBoxCoberturas.Items.Add("No tiene coberturas");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void dataGridViewVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Enabled=true;
            dateTimePicker2.Enabled=true;
        }

        private void consultarReservacionTotal()
        {
            Vehiculo vehiculo1 = new Vehiculo();
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                if (vehiculo.Placa == obtenerVehiculoSleccionado())
                {
                    vehiculo1 = vehiculo;
                }
            }

            double diasTotal = (dateTimePicker2.Value - dateTimePicker1.Value).TotalDays;
            int montoAlquilerDias = (int) Math.Round((diasTotal +1) * vehiculo1.Costo);
            int montoCoberturaDias =0;
           
           
            listBox1.Items.Clear();
            listBox1.Items.Add( vehiculo1.mostrar());
            listBox1.Items.Add("Fechas de reservación | Inicio: "  +  dateTimePicker1.Value.Date.ToShortDateString() + " |Final : " + dateTimePicker2.Value.Date.ToShortDateString() +"");
            listBox1.Items.Add("Costo alquiler vehículo | Por día: " + vehiculo1.Costo + " |Total: " + montoAlquilerDias);

            if (listaConCoberturas.Count > 0)
            {
                comboBoxCoberturas.SelectedIndex = 0;
                montoCoberturaDias = (int)Math.Round((diasTotal + 1) * listaConCoberturas[comboBoxCoberturas.SelectedIndex].Monto);
                listBox1.Items.Add("Costo de coberturas | Por día: " + listaConCoberturas[comboBoxCoberturas.SelectedIndex].Monto + " |Total: " + montoCoberturaDias);
            }
            else
            {
                listBox1.Items.Add("No hay coberturas, el monto es cero");
            }
           
            listBox1.Items.Add("Monto total: " + montoAlquilerDias + montoCoberturaDias);
            nuevaReserva.montoReserva = montoAlquilerDias + montoCoberturaDias;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool agregarReserva = false;
            agregarReserva = ClienteTCP.AgregarReserva(nuevaReserva);
           
            if (agregarReserva)
            {
                label7.Text = "La reserva se agregó correctamente";
            }
        }

        private void buttonConsultarReservaciones_Click(object sender, EventArgs e)
        {
            ConsultarReservaForm formConsultar = new ConsultarReservaForm(cliente);
            formConsultar.Show();
        }

    }
}
