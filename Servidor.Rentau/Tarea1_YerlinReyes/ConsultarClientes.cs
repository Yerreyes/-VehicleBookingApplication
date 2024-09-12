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
    public partial class ConsultarClientes : Form
    {

        Clientes clientesObjt;
        public ConsultarClientes(Clientes clientesObjt)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.clientesObjt = clientesObjt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clientesObjt.CantidadClientes > 0)
            {
                dataGridView_Clientes.DataSource = clientesObjt.ArregloClientes;
                if (dataGridView_Clientes.Columns.Count == 7)
                {
                    dataGridView_Clientes.Columns.Remove("Genero");
                }

                dataGridView_Clientes.AutoResizeColumns();
                dataGridView_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                MessageBox.Show("NO HAY CLIENTES REGISTRADOS");
            }
        }
    }
}
