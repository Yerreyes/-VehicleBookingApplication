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
    public partial class ConsultarSucursales : Form
    {
        //Atributos
        private Sucursales listaSucursales;
  
       
        //Constructor
        public ConsultarSucursales(Sucursales listaSucursales)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.listaSucursales = listaSucursales;
           
        }


        //Métodos

        public void mostrarSucursales()
        {
            
            if (listaSucursales.CantidadSucursales > 0) {  //en caso de que cantidadDeSucursales sea = = es porque no hay regsitradas


                dataGridView_Sucursales.DataSource = listaSucursales.ArregloSucursal;
                if (dataGridView_Sucursales.Columns.Count ==6) {
                    dataGridView_Sucursales.Columns.Remove("Estado"); 
                }
                dataGridView_Sucursales.AutoResizeColumns();
                dataGridView_Sucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            } else
            {
                MessageBox.Show("No existen sucursales registradas");
            }
            
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            mostrarSucursales();
        }

    }
}
