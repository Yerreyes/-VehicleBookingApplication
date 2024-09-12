using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_YerlinReyes
{
    public partial class RegistroSucursales : Form
    {

        private Sucursales sucursalesObjt; // necesito instanciar un objeto de clase Sucursales para que contenga la lista del contexto principal (menuPrincial), ver**

        private ConexionBD conexion;
        //Constructores

        public RegistroSucursales(Sucursales sucursalesObjt, ConexionBD conexion) // **acá guardo ese objeto
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.sucursalesObjt = sucursalesObjt;
            this.conexion = conexion;
        }

        //metodos y eventos

        public void AgregarBtn_Click(object sender, EventArgs e)
        {
            AgregarDatos();
        }


        public void AgregarDatos()
        {
            try
            {
                if (idSucursal.Text != "" && nombreSucursal.Text != "" && direccionSucursal.Text != "" && telefonoSucursal.Text != "" )
                {
                     Sucursal sucursalNueva = new Sucursal(int.Parse(idSucursal.Text), nombreSucursal.Text, direccionSucursal.Text, checkBox_Activo.Checked, telefonoSucursal.Text);
                     sucursalesObjt.ingresarSucursal(sucursalNueva);
                    
                    if (!conexion.repetidoSucursal(int.Parse(idSucursal.Text)))
                    {
                        conexion.insertarSucursalBD(int.Parse(idSucursal.Text), nombreSucursal.Text, direccionSucursal.Text, checkBox_Activo.Checked, telefonoSucursal.Text);
                        label.Text = "!! Sucursal ingresada con éxito!! ";
                        label7.Text = "Cantidad de Sucursales = " + sucursalesObjt.CantidadSucursales;
            
                    }else
                    {
                        label.Text = "!!Incorrecto, la sucursal ya está almacenada";
                    }
                }
                else
                {
                    MessageBox.Show("Hay datos incompletos!");
                }
            }
            catch(System.FormatException ex)
            {
                MessageBox.Show("La id de Sucursal debe ser un número entero");
            }
        }


      
    }
}
