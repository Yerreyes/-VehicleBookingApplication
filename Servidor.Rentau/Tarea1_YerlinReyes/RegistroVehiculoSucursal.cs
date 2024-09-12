using System;
using System.Collections;
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
    public partial class RegistroVehiculoSucursal : Form
    {

        Sucursales sucursalesObjt;
        Vehiculos vehiculosObjt;
        VehiculoSucursales vehiculoSucursalesObjt;
        DataTable dt1;
       
        ConsultarVehiculos formConsultarVehiculos;
        TiposdeVehiculos tiposVehiculosObjt;
        Sucursal sucursalSeleccionada;
        private ConexionBD conexion;
        DateTime fechaAsignacion = DateTime.Now;

    
        List<Sucursal> listaAux = new List<Sucursal>(); // lista que solo tiene sucursales activas
   

        public RegistroVehiculoSucursal(Vehiculos vehiculos, Sucursales sucursales, VehiculoSucursales vehiculoSucursales, TiposdeVehiculos tiposdeVehiculosObjt, ConexionBD conexion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.sucursalesObjt = sucursales;
            this.vehiculosObjt = vehiculos;
            this.vehiculoSucursalesObjt = vehiculoSucursales;
            this.tiposVehiculosObjt = tiposdeVehiculosObjt;
            cargarSucursales();
            this.conexion = conexion;

        }

        public void cargarSucursales()
        {
            listaAux.AddRange(sucursalesObjt.ArregloSucursal) ; // lista que va a guardar solo las sucursales activas para luego consultar cual es la sucursal seleccionada
            if (sucursalesObjt.CantidadSucursales != 0) // metodo que carga las sucursales para ser seleccionadas
            {
                foreach (Sucursal sucursal in sucursalesObjt.ArregloSucursal)
                    if (sucursal != null )
                    {
                        if (sucursal.Estado == true)
                        {
                            comboBox1.Items.Add("IdSucursal:  " + sucursal.IdSucursal + " |   Nombre:  " + sucursal.Nombre + "  |  Dirección:  " + sucursal.Direccion);
                        }else
                        {
                            listaAux.Remove(sucursal);                          
                        }
                    }
            }
            else
            {
                MessageBox.Show("No hay sucursales registradas");
            }
        }


       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // carga los vehiculos deacurdo con la sucursal seleccionada
        {

            sucursalSeleccionada = obtenerSucursalSeleccionada();
            if (!sucursalTieneAsociacion())
            {
                formConsultarVehiculos = new ConsultarVehiculos(vehiculosObjt, dataGridView_mostrarVehiculos, tiposVehiculosObjt);
                formConsultarVehiculos.mostrarVehiculos();
                mostrarVehiculosAsociados();  // como no hay la sucursal no tiene asociacion entocens no muestra nada, solo actualiza datos
            }
            else
            {
                mostrarVehiculosDisponibles();
                mostrarVehiculosAsociados();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                asociar();
                mostrarVehiculosDisponibles();
                mostrarVehiculosAsociados();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la sucursal");
            }  
        }


        public Sucursal obtenerSucursalSeleccionada()
        {
            int indiceCbSucursal = comboBox1.SelectedIndex;
            sucursalSeleccionada = listaAux[indiceCbSucursal];
            return sucursalSeleccionada;
        }



        public void asociar()
        {
            try {
                Vehiculo vehiculoSeleccionado;
                DataGridViewSelectedRowCollection Seleccionados = dataGridView_mostrarVehiculos.SelectedRows;

                foreach (DataGridViewRow item in Seleccionados)
                {
                    // cuestion grafica
                    string idVehiculo = item.Cells[0].Value.ToString(); // obtiene cual fue el el id de la fila elegida, es decir, saca el id que esta en la columna 0 de esa fila(item)
                    vehiculoSeleccionado = vehiculosObjt.sacarVehiculo(idVehiculo); // a partir del id saca el vehiculo del arreglo

                    int id = crearIdAsignacion();

                   
                    VehiculoSucursal vehiculoSucursalNuevo = new VehiculoSucursal(id,sucursalSeleccionada, vehiculoSeleccionado, vehiculosObjt, fechaAsignacion);

                    if (!ubicarVehiculo(sucursalSeleccionada, vehiculoSucursalNuevo))
                    {
                        vehiculoSucursalesObjt.ingresarVehiculoSucursal(vehiculoSucursalNuevo);
                        VehiculoSucursal vehiculoSucursalExiste; // comprueba si esa sucursal existe en el arreglo de vehiculosucursal para crear ese campo para la sucursal o sino nada mas añade vehículos
                        vehiculoSucursalExiste = vehiculoSucursalesObjt.existenciaSucursal2(sucursalSeleccionada.IdSucursal);

                        if (vehiculoSucursalExiste != null)
                        {
                            vehiculoSucursalExiste.quitarVehiculo(idVehiculo);
                        }

                        label4.Text = "!!Asociación realizada!!";
                        conexion.insertarVehiculoSucursalBD(id, sucursalSeleccionada.IdSucursal, vehiculoSeleccionado.Placa, fechaAsignacion);
                    } else
                    {
                        MessageBox.Show("Esa sucursal ya tiene ese vehiculo asociado");
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Debe seleccionar un vehiculo no asociado");
            }
        }

        public void mostrarVehiculosAsociados()
        {
            List<Vehiculo> vehiculoList = new List<Vehiculo>();
            bool ubicarAsociacion;
            foreach (VehiculoSucursal vehiculoSucursal in vehiculoSucursalesObjt.ArregloVS) // Recorre el array de vehiculoSucursales 
            {
                if (vehiculoSucursal != null) // if que valida que la vehiculoSucursal no sea nula. Recordar que es un arreglo sencillo con 20 espacios de memoria establecidos con o sin objetos
                {
                    ubicarAsociacion = vehiculoSucursal.Sucursal.IdSucursal.Equals(sucursalSeleccionada.IdSucursal); // deacuerdo con la sucursal seleccionada busca si está almacenada en el arreglo de VehiculoSucursal

                    if (ubicarAsociacion)
                    {
                        vehiculoList.AddRange(vehiculoSucursal.ArregloConVehiculos);
                    }
                }
            }
            dataGridView_VehiculosAsociados.DataSource = vehiculoList;
        }

        public void mostrarVehiculosDisponibles()
        {
            List<Vehiculo>  listaVehiculosDisponibles = new List<Vehiculo>();
            listaVehiculosDisponibles.AddRange(vehiculosObjt.ArregloDeVehiculos); //contiene todos los vehiculos que se pueden asociar

            bool ubicarAsociacion;
            foreach (VehiculoSucursal vehiculoSucursal in vehiculoSucursalesObjt.ArregloVS) // Recorre el array de vehiculoSucursales 
            {
                if (vehiculoSucursal != null) // if que valida que la vehiculoSucursal no sea nula.objet
                {
                    ubicarAsociacion = vehiculoSucursal.Sucursal.IdSucursal.Equals(sucursalSeleccionada.IdSucursal); // deacuerdo con la sucursal seleccionada busca si está almacenada en el arreglo de VehiculoSucursal

                    if (ubicarAsociacion)
                    {
                        
                        for (int i = 0; i < vehiculoSucursal.ArregloConVehiculos.Count;) {
                            
                            listaVehiculosDisponibles.Remove(vehiculoSucursal.ArregloConVehiculos[i]); //Para obtener los vehiculos disponibles, elimino de todos los registrados, los que ya estan asociados en el arreglo de esa sucursal
                            i++;
                        }
                       
                    }
                }
            }
         

            dataGridView_mostrarVehiculos.DataSource = null;
            dataGridView_mostrarVehiculos.DataSource = listaVehiculosDisponibles;   
        }



        public Boolean sucursalTieneAsociacion()
        {
            Boolean existeAsociacion = false;
            foreach (VehiculoSucursal vehiculoSucursal in vehiculoSucursalesObjt.ArregloVS) // Recorre el array de vehiculoSucursales 
            {
                if (vehiculoSucursal != null) 
                {    
                    if (vehiculoSucursal.Sucursal.IdSucursal == sucursalSeleccionada.IdSucursal)
                    {
                        existeAsociacion = true;
                    }
                }
            }
            return existeAsociacion;
        }

        public Boolean ubicarVehiculo(Sucursal scursal, VehiculoSucursal vehiculoSucursal) 
            //  metodo que valida que esa sucursal ya no tenga asignado ese vehiculo
            //al hacer precarga salen todos los vehiculos
        {
         
            bool ubicarAsociacion = false;
            foreach (VehiculoSucursal vehiculoSucursalAux in vehiculoSucursalesObjt.ArregloVS) // Recorre el array de vehiculoSucursales 
            {
                if (vehiculoSucursal != null)
                {
                    if (vehiculoSucursalAux.Sucursal.IdSucursal == sucursalSeleccionada.IdSucursal)
                    {
                      
                        foreach (Vehiculo vehiculo in vehiculoSucursalAux.ArregloConVehiculos)
                        {
                            if (vehiculo != null)
                            {
                                if (vehiculo.Placa.Equals(vehiculoSucursal.Vehiculo.Placa))
                                {
                                    return ubicarAsociacion = true;
                                   
                                }
                            }
                        }
                    }
                }
            }
            return ubicarAsociacion;
        }


        public int crearIdAsignacion()
        {

            Random r = new Random();
            int id = r.Next(2200, 4400);
            foreach (VehiculoSucursal vehiculoSucursal in vehiculoSucursalesObjt.ArregloVS) // Recorre el array de vehiculoSucursales para validar que el id asignacion que se asiganra no este repetido 
            {
                if (vehiculoSucursal != null)
                {
                    while (vehiculoSucursal.IdAsignacion == id)
                    {
                        r = new Random();
                        id = r.Next(2200, 4400);
                    }
                }
            }

            return id;
        }
        //final de la clase
    }
}
