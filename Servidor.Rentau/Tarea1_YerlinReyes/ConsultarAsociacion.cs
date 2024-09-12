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
    public partial class ConsultarAsociacion : Form
    {

        VehiculoSucursales vehiculoSucursalesObjt;
        Sucursales sucursales;

        private DataTable dt;
        Sucursal sucursalSeleccionada;
        precarga precarga;
        public ConsultarAsociacion(VehiculoSucursales vehiculoSucursalesObjt, Sucursales sucursales, ConexionBD conexion, Vehiculos vehiculos)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.vehiculoSucursalesObjt = vehiculoSucursalesObjt;
            this.sucursales = sucursales;
            cargarSucursales();
            
            precarga = new precarga(conexion, vehiculos, sucursales);

        }


  
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_Asociaciones.DataSource = "";
            mostrarAsociaciones();
           
        }

        public void cargarSucursales()
        {
            if (sucursales.CantidadSucursales != 0) // metodo que carga las sucursales para ser seleccionadas
            {
                foreach (Sucursal sucursal in sucursales.ArregloSucursal)
                {
                    if (sucursal != null && sucursal.Estado == true)
                    {
                        comboBox_Sucursales.Items.Add("IdSucursal:  " + sucursal.IdSucursal + " |   Nombre:  " + sucursal.Nombre + "  |  Dirección:  " + sucursal.Direccion);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay sucursales registradas");
            }
        }


        public void mostrarAsociaciones()
        {
            
            Boolean tieneAsociacion = false;
            if (eleccionSucursal() == true)
            {
               
                dataGridView_Asociaciones.DataSource =  precarga.CargarVehiculosSucursales(sucursalSeleccionada.IdSucursal);
                dataGridView_Asociaciones.AutoResizeColumns();
                dataGridView_Asociaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                tieneAsociacion = true;
                if (dataGridView_Asociaciones.Columns.Count == 5)
                {
                    dataGridView_Asociaciones.Columns.Remove("CantidadDeVehiculosEnSucursal");
                }  
            }
            if (dataGridView_Asociaciones.Rows.Count == 0)
            {
                MessageBox.Show("Esta sucursal no tiene vehiculos asociados");
            }
        }

        public Boolean eleccionSucursal() //  saca el tipo de vehículo seleccionado, retorna false en caso de que el usuario no seleccionara tipo, llo que hace que mostrar coverturas no se ejecute
        {
            int indiceCbSucursal = comboBox_Sucursales.SelectedIndex;
            if (indiceCbSucursal >= 0)
            { 
                sucursalSeleccionada = sucursales.ArregloSucursal[indiceCbSucursal];
                return true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de vehículo");
                return false;
            }
        }

       

    }
}
