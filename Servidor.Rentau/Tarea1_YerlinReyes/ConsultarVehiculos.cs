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
    public partial class ConsultarVehiculos : Form
    {

        Vehiculos vehiculosObjt;
        TiposdeVehiculos tiposVehiculosObjet;
        private DataTable dt;
        DataGridView data;


        //Contructor
        public ConsultarVehiculos(Vehiculos vehiculosObjt, TiposdeVehiculos tiposVehiculosObjet )
        {
            this.vehiculosObjt = vehiculosObjt;
            this.tiposVehiculosObjet = tiposVehiculosObjet;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            data = dataGridView_Vehiculos;
            
            
        }

        public ConsultarVehiculos(Vehiculos vehiculosObjt, DataGridView data, TiposdeVehiculos tiposVehiculosObjet)
        {
            this.vehiculosObjt = vehiculosObjt;
            this.data = data;
            this.tiposVehiculosObjet = tiposVehiculosObjet;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarVehiculos();
        }

        public void mostrarVehiculos() // no lo cambia a datasource solamente porque sino tengo que cambiar toda la logica ya qu el cargar vehiculo lo uso en varias parte
        {
           
            if (vehiculosObjt.CantidadDeVehiculos > 0)
            {
                data.DataSource = vehiculosObjt.ArregloDeVehiculos;
                data.AutoResizeColumns();
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                if (data.Columns.Count > 6) // si le presiona mas de una vez el boton ya no borre y se de una exception
                {
                    data.Columns.Remove("NumeroDeAsignacion");
                }
            }
            else
            {
                MessageBox.Show("NO HAY VEHICULOS REGISTRADOS");
            }
        }
    }
}
