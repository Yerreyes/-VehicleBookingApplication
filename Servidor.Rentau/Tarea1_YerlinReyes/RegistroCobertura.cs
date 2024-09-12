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
    public partial class RegistroCobertura : Form
    {

        TiposdeVehiculos tiposdeVehiculosObjt;
        Coberturas coberturasObjt;
        ConexionBD conexion;

        public RegistroCobertura(  Coberturas coberturasObjt, TiposdeVehiculos tiposdeVehiculosObjt, ConexionBD conexion)
        {
            this.tiposdeVehiculosObjt=tiposdeVehiculosObjt;
            this.coberturasObjt=coberturasObjt;
            this.conexion = conexion;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargarDatos();
        }

        private void cargarDatos()
        {
            foreach (TipoVehiculo tipo in tiposdeVehiculosObjt.ArregloDeTipos) // Recorre el array de sucursales 
            {
                if (tipo != null)
                {
                    comboBox_TipoVehiculo.Items.Add(tiposdeVehiculosObjt.mostrarTipos(tipo));
                }
                else
                {
                    break;
                }
            }
        }

        public TipoVehiculo obtenerTipoVehiculo()
        {
            int indice;
            indice = comboBox_TipoVehiculo.SelectedIndex;
            return tiposdeVehiculosObjt.ArregloDeTipos[indice];
        }




        /// <summary>
        /// reglar que si el tipo de vehiculo hay uno inactiibo el indice no coincide
        /// </summary>



        public void guardarCobertura()
        {
            if (comboBox_TipoVehiculo.SelectedIndex >=0)
            {
                try
                {
                    Cobertura coberturaNueva = new Cobertura(int.Parse(textBox_idCobertura.Text), textBox_Descripcion.Text, obtenerTipoVehiculo(), checkBox_Activo.Checked, int.Parse(textBox_Monto.Text));

                    if (conexion.repetidoCobertura(int.Parse(textBox_idCobertura.Text)) == false)
                    {
                        conexion.insertarCobertura(coberturaNueva.IdCobertura, coberturaNueva.Descripcion, int.Parse(coberturaNueva.TipoVehiculo.Id), coberturaNueva.IsEstado, coberturaNueva.Monto);

                        coberturasObjt.ingresarCobertura(coberturaNueva);

                        label6.Text = "Se agregó una nueva cobertura!!!";                    }
                    else
                    { MessageBox.Show("Dicha cobertura ya está registrada!"); }


                }
                catch
                {
                    MessageBox.Show("Dados incompletos, considere que id debe ser un número");
                }
                
            }
            else { MessageBox.Show("No seleccionó ningún tipo de vehículo "); }
            
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            guardarCobertura();
        }
    }
}
