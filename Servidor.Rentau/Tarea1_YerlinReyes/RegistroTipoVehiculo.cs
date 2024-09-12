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
    public partial class RegistroTipoVehiculo : Form
    {


        TiposdeVehiculos tiposdeVehiculosObjt;
        ConexionBD conexion;

        public RegistroTipoVehiculo(TiposdeVehiculos tiposdeVehiculosObjt, ConexionBD conexion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.tiposdeVehiculosObjt = tiposdeVehiculosObjt;
            this.conexion = conexion;  
        }


        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTipoVehiculo.Text != "" && DescripcionTipoVehiculo.Text != "")
                {
                    TipoVehiculo tipoVehiculoXregistrar = new TipoVehiculo(idTipoVehiculo.Text, DescripcionTipoVehiculo.Text, activoRB.Checked);

                    if (!conexion.repetidoTipoVehiculo(int.Parse(idTipoVehiculo.Text)))
                    {
                        tiposdeVehiculosObjt.registrarTipo(tipoVehiculoXregistrar);

                        conexion.insertarTipoVehiculoBD(int.Parse(idTipoVehiculo.Text), DescripcionTipoVehiculo.Text, activoRB.Checked);

                        label3.Text = "Se agregó un nuevo tipo de vehículo!!!";
                        label5.Text = "Cantidad de tipos de vehículo = " + tiposdeVehiculosObjt.CantidadDeTipos;
                    }
                    else
                    {
                        MessageBox.Show("Dicho tipo de vehículo ya está registrada!");
                    }
                }
                else
                {
                    MessageBox.Show("!!Datos incompletos!!");
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("La id de Sucursal debe ser un número entero");
            }
        }
    }
}
