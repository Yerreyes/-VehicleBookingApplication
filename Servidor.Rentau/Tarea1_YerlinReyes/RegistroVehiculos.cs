using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_YerlinReyes
{
    public partial class RegistroVehiculos : Form
    {
        TiposdeVehiculos tiposdeVehiculosObjt;
        Vehiculos vehiculosObjt;



        ConexionBD conexion;
        public RegistroVehiculos(TiposdeVehiculos tiposdeVehiculos, Vehiculos vehiculos, ConexionBD conexion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.vehiculosObjt = vehiculos;
            this.tiposdeVehiculosObjt = tiposdeVehiculos;
            cargarDatos(comboBox1);  // cuando inicia el form recorre el arreglo de tipos y sacar al combobox los datos
            this.conexion = conexion;
        }


        //Crea el objeto con los datos. Verifica que no este repetido. y agrega el nuevo objeto al arreglo
        private void AgregarBtn_Click(object sender, EventArgs e) 
        {
            try
            {
                int indiceCB = comboBox1.SelectedIndex; // guarda cuál es la pocisión en la que se encuentra el tipo de vehículo seleccionado

                if (idPlacaTxt.Text != "" && marcaTxt.Text != "" && modeloTxt.Text != "" && costoTxt.Text != "" && kiometrajeTxt.Text != "")
                {
                    Vehiculo vehiculoxregistar = new Vehiculo( idPlacaTxt.Text, marcaTxt.Text, modeloTxt.Text, int.Parse(costoTxt.Text), int.Parse(kiometrajeTxt.Text), int.Parse(tiposdeVehiculosObjt.ArregloDeTipos[indiceCB].Id));

                    if (!conexion.repetidoVehiculo(int.Parse(idPlacaTxt.Text)))
                    {   //me agrega los datos al arreglo
                        vehiculosObjt.registrar(vehiculoxregistar);

                        //agrega los datos a la BD
                        conexion.insertarVehiucloBD(int.Parse(idPlacaTxt.Text), marcaTxt.Text, modeloTxt.Text, Convert.ToInt32(tiposdeVehiculosObjt.ArregloDeTipos[indiceCB].Id), int.Parse(costoTxt.Text), int.Parse(kiometrajeTxt.Text));
                        
                        label3.Text = "Se agregó un nuevo vehículo!!!";
                       label6.Text = "Cantidad de vehículos registrados : " + vehiculosObjt.CantidadDeVehiculos;
                    }
                    else
                    {
                        MessageBox.Show("Dicho vehículo ya está registrado!");
                    }
                }else
                {
                    MessageBox.Show("!!Datos incompletos!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("!!Considerar que costo y kilometraje no pueden ser valores de cadena!!" + ex.ToString());
            }
        }

        public void cargarDatos(ComboBox comboBox)
        {
            foreach (TipoVehiculo tipo in tiposdeVehiculosObjt.ArregloDeTipos ) // Recorre el array de sucursales 
            {
                if (tipo != null && tipo.Estado == true)
                {
                    comboBox.Items.Add(tiposdeVehiculosObjt.mostrarTipos(tipo));
                }
            }
        }
    }
}
