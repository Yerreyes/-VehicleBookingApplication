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
    public partial class ConsultarTipoVehiculo : Form
    {
        TiposdeVehiculos tiposdeVehiculos;
        private DataTable dt;

        public ConsultarTipoVehiculo(TiposdeVehiculos tiposdeVehiculos)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.tiposdeVehiculos = tiposdeVehiculos;
            
        }

        //Métodos
       
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarTipoVehiculo();
        }

        public void mostrarTipoVehiculo()
        {
          
            if (tiposdeVehiculos.CantidadDeTipos > 0)
            {
                dataGridView_TipoDeVehiculo.DataSource = tiposdeVehiculos.ArregloDeTipos;
                dataGridView_TipoDeVehiculo.AutoResizeColumns();
                dataGridView_TipoDeVehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                MessageBox.Show("NO HAY TIPOS DE VEHICULOS REGISTRADOS");

            }
            
        }

    }
}
