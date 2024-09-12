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
    public partial class ConsultarCobertura : Form
    {

        Coberturas converturasObjt;
        TiposdeVehiculos tiposdeVehiculosoObjt;   
        TipoVehiculo tipoVehiculoSleccionado;

        public ConsultarCobertura(Coberturas converturas, TiposdeVehiculos tiposdeVehiculos)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.tiposdeVehiculosoObjt = tiposdeVehiculos;
            this.converturasObjt = converturas;
            cargarDatos(comboBox_TiposVehiculos); 
        }

        List<TipoVehiculo> listAiux = new List<TipoVehiculo>();
        public void cargarDatos(ComboBox comboBox)
        {
             
             foreach (TipoVehiculo tipo in tiposdeVehiculosoObjt.ArregloDeTipos) // Recorre el array de sucursales 
            {
                if (tipo != null && tipo.Estado == true)
                {
                    comboBox.Items.Add(tiposdeVehiculosoObjt.mostrarTipos(tipo));
                    listAiux.Add(tipo);
                }
            }
        }

        public Boolean obtenerTipoVehiculo() //  saca el tipo de vehículo seleccionado, retorna false en caso de que el usuario no seleccionara tipo, llo que hace que mostrar coverturas no se ejecute
        {
            int indice;
            indice = comboBox_TiposVehiculos.SelectedIndex;
            if (indice >= 0) {
                tipoVehiculoSleccionado = listAiux[indice];
                return true;
            }else
            {
                MessageBox.Show("Debe seleccionar el tipo de vehículo");
                return false;
            }
        }

        public void  mostrarCoberturas()
        {
            List<Cobertura> listacoberturas = new List<Cobertura>();
            Boolean siTieneCobertura = false;
            if (obtenerTipoVehiculo() )
            {
                foreach (Cobertura cobertura in converturasObjt.ArregloCoberturas) // si la paso a datasourse tengo que ver como enseñar bien el tipo de veihulo [orque viene como objeto entonces se muestra yerli.tiposdevehiculos
                {   
                    if (cobertura != null)
                    {
                           if (cobertura.TipoVehiculo.Id.Equals(tipoVehiculoSleccionado.Id)) // me saca las coberturas pero solo para ese tipo de vehiculo seleccionado
                        {
                           listacoberturas.Add(cobertura);  
                           siTieneCobertura = true;
                        }
                    }
                }
                if (!siTieneCobertura)
                {
                    MessageBox.Show("Ese tipo de vehículo no tiene coberturas");
                }else
                {
                    dataGridView_Cobertura.DataSource = listacoberturas;
                    dataGridView_Cobertura.AutoResizeColumns();
                    dataGridView_Cobertura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    if (dataGridView_Cobertura.Columns.Count == 6)
                    {
                        dataGridView_Cobertura.Columns.Remove("IsEstado");
                    }
                }
            }

        }


        private void comboBox_TiposVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_Cobertura.DataSource = "";
            mostrarCoberturas();
        }
    }
}
