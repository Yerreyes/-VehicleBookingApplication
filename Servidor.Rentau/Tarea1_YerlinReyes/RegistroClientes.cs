using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_YerlinReyes
{
    public partial class RegistroClientes : Form
    {
        DateTime nacimiento = new DateTime();
   
        private Clientes clientesObjt;
        ConexionBD conexion;

        public RegistroClientes(Clientes clientesObjt, ConexionBD conexion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.clientesObjt = clientesObjt;
            this.conexion = conexion;   
        }


        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            ingresarCliente();

        }


        char genero = 'n';
        public void ingresarCliente()
        {
            if (idCliente.Text != "" && nombre.Text != "" && priemrApellido.Text != "" && segundoApellido.Text != "" && generoCB.SelectedIndex >= 0)
            {             
                genero = Convert.ToChar(generoCB.SelectedItem);
                if (!conexion.repetidoCliente(idCliente.Text))
                {
                    // guarda clientenuevo en memoria temporal
                   
                    Cliente clienteNuevo = new Cliente(idCliente.Text, nombre.Text, priemrApellido.Text, segundoApellido.Text, dateTimePicker1.Value, genero);
                    clientesObjt.ingresarCliente(clienteNuevo);

                    // guarda nuevo cliente en base de datos
                 
                    conexion.insertarClienteBD(idCliente.Text, nombre.Text, priemrApellido.Text, segundoApellido.Text, dateTimePicker1.Value, genero);

                    label7.Text = "Se agregó un nuevo cliente";
                    label8.Text = "Cantidad de clientes:" + clientesObjt.CantidadClientes;

                }
                else
                {
                    MessageBox.Show("Dicho cliente ya está registrado!");
                }
              
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }

    }
    }
