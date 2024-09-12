
using System.Data.SqlClient;
using System.Windows;

// Los metodos fueron basados y adaptados del ejemplo de biblioteca del profesor tutor Juan Plablo Navarro
namespace Tarea1_YerlinReyes
{
    public class precarga { // clase que tiene la función de precargar los valores a los arreglos para manipularlos y mostrarlos en la interfaz.

        
        Sucursales sucursalesObjt;
        Clientes clientesObjt;
        TiposdeVehiculos tiposdeVehiculosObjt;
        Vehiculos vehiculosObjt;
        VehiculoSucursales vehiculoSucursalesObjt;
        Coberturas coberturasObjt;
        ConexionBD conexion;
        SqlCommand comando;
        SqlDataReader dr;


        public precarga(Sucursales sucursalesObjt, Clientes clientesObjt, TiposdeVehiculos tiposdeVehiculosObjt, Vehiculos vehiculosObjt, VehiculoSucursales vehiculoSucursalesObjt, Coberturas coberturasObjt, ConexionBD conexion)
        {
            this.sucursalesObjt = sucursalesObjt;
            this.clientesObjt = clientesObjt;
            this.tiposdeVehiculosObjt = tiposdeVehiculosObjt;
            this.vehiculosObjt = vehiculosObjt;
            this.vehiculoSucursalesObjt = vehiculoSucursalesObjt;
            this.coberturasObjt = coberturasObjt;
            this.conexion = conexion;

            precargarSucursales();
            precargarClientes();
            precargarTipos();
            precargarVehiculos();
            precargarVehiculosSucursal();
            PregarcarCoberturas();

        }

        public precarga( ConexionBD conexion, Vehiculos vehiculosObjt, Sucursales sucursalesObjt)
        {
            this.sucursalesObjt = sucursalesObjt;
            this.vehiculosObjt = vehiculosObjt; 
            this.conexion = conexion;
        }

        // Sucursales
        public void precargarSucursales() //méetodo que cargará los datos que se encuentren en el
        {
            conexion.Conexion().Open();
            string query = @"Select * from [dbo].[Sucursal]";

            comando = new SqlCommand(query, conexion.Conexion());
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                sucursalesObjt.ingresarSucursal(ConvertirSucursal(dr));
            }
            dr.Close();
            conexion.Conexion().Close();
        }

        private Sucursal ConvertirSucursal(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            Sucursal nuevaSucursal = new Sucursal(Convert.ToInt32(dr["IdSucursal"]), Convert.ToString(dr["Nombre"]), Convert.ToString(dr["Direccion"]), Convert.ToBoolean(dr["Estado"]), Convert.ToString(dr["Telefono"]));
            return nuevaSucursal;
        }
        //fin Sucursales

        //Clientes
        public void precargarClientes() //méetodo que cargará los datos que se encuentren en el
        {

            string query = @"Select * from Cliente";
            conexion.Conexion().Open();
            comando = new SqlCommand(query, conexion.Conexion());
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                clientesObjt.ingresarCliente(ConvertirCliente(dr));
            }
            dr.Close();
            conexion.Conexion().Close();
        }
       
        private Cliente ConvertirCliente(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            Cliente cliente = new Cliente(Convert.ToString(dr["IdCliente"]), Convert.ToString(dr["Nombre"]), Convert.ToString(dr["PrimerApellido"]), Convert.ToString(dr["SegundoApellido"]), Convert.ToDateTime(dr["FechaNacimiento"]), Convert.ToChar(dr["Genero"]));
            return cliente;
        }
        //fin clientes

        //TiposVehiculos
        public void precargarTipos() //méetodo que cargará los datos que se encuentren en el
        {
            string query = @"Select * from TipoVehiculo";
            conexion.Conexion().Open();
            comando = new SqlCommand(query, conexion.Conexion());
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra
            while (dr.Read())
            {  
                tiposdeVehiculosObjt.registrarTipo(ConvertirTipo(dr));
            }
            dr.Close();
            conexion.Conexion().Close();
        }

        private TipoVehiculo ConvertirTipo(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            int valor = Convert.ToInt32(dr["IdTipo"]);
            TipoVehiculo tipo = new TipoVehiculo(Convert.ToString(valor), Convert.ToString(dr["Descripcion"]), Convert.ToBoolean(dr["Estado"]));
            return tipo;
        }
        //fin tipos

        //TiposVehiculos
        public void precargarVehiculos() //méetodo que cargará los datos que se encuentren en el
        {
            string query = @"Select * from Vehiculo";
            conexion.Conexion().Open();
            comando = new SqlCommand(query, conexion.Conexion());
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra
            while (dr.Read())
            {
                vehiculosObjt.registrar(ConvertirVehiculo(dr));
            }
            dr.Close();
            conexion.Conexion().Close();
        }


        private Vehiculo ConvertirVehiculo(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = Convert.ToString(dr["IdPlaca"]);
            vehiculo.Marca = Convert.ToString(dr["Marca"]);
            vehiculo.Modelo = Convert.ToString(dr["Modelo"]);
            vehiculo.Costo = Convert.ToInt32(dr["CostoAlquilerDia"]);
            vehiculo.Kilometraje = Convert.ToInt32(dr["Kilometraje"]);
            vehiculo.IdTipoVehiculo = Convert.ToInt32(dr["IdTipoVehiculo"]);
            return vehiculo;
        }
        //fin tipos

        public void precargarVehiculosSucursal() //méetodo que cargará los datos que se encuentren en el
        {
            string query = @"Select * from VehiculoSucursal";
            conexion.Conexion().Open();
            comando = new SqlCommand(query, conexion.Conexion());
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra
            while (dr.Read())
            {
                vehiculoSucursalesObjt.ingresarVehiculoSucursal(ConvertirVehiculoSucursal(dr)); 
            }
            dr.Close();
            conexion.Conexion().Close();
        }

        private VehiculoSucursal ConvertirVehiculoSucursal(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            Vehiculo vehiculo;
            vehiculo = sacarVehiculo(Convert.ToString(dr["IdPlaca"]));
            vehiculo.NumeroDeAsignacion = Convert.ToInt32(dr["IdAsignacion"]);
            VehiculoSucursal vehiculoSucursal = new VehiculoSucursal(Convert.ToInt32(dr["IdAsignacion"]), sacarSucursal(Convert.ToInt32(dr["IdSucursal"])), vehiculo, vehiculosObjt, Convert.ToDateTime(dr["FechaAsignacion"]));
            return vehiculoSucursal;
        }

        public void PregarcarCoberturas()
        {
            string query = @"Select * from CoberturaSeguro";
            conexion.Conexion().Open();
            comando = new SqlCommand(query, conexion.Conexion());
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                coberturasObjt.ingresarCobertura(convertirCobertura(dr)); //asi se puede hacer mandando el arreglo desde menuprincipal y no desde una clase
            }
            dr.Close();
            conexion.Conexion().Close();
        }

        private Cobertura convertirCobertura(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            TipoVehiculo tipo;
            tipo = sacarTipo(Convert.ToString(dr["IdTipoVehiculo"]));
            Cobertura cobertura = new Cobertura(Convert.ToInt32(dr["IdCobertura"]), Convert.ToString(dr["Descripcion"]), tipo, Convert.ToBoolean(dr["Estado"]), Convert.ToInt32(dr["Monto"]));
            return cobertura;
        }

        public Vehiculo sacarVehiculo(string placa) // funcion que permite sacar el vehiculo de acuerdo con un indice establecido pasado por parametro// la uso en asociar
        {
            Vehiculo vehiculoEncontrado = new Vehiculo();
            foreach (Vehiculo vehiculo1 in vehiculosObjt.ArregloDeVehiculos)
            {
                if (vehiculo1 != null)
                {
                    if (vehiculo1.Placa == placa)
                    {
                        vehiculoEncontrado = vehiculo1;
                        break;
                    }
                }
            }
            return vehiculoEncontrado;
        }

        public TipoVehiculo sacarTipo(string id) // funcion que permite sacar el vehiculo de acuerdo con un indice establecido pasado por parametro// la uso en asociar
        {
            TipoVehiculo tipoEncontrado = new TipoVehiculo();
            foreach (TipoVehiculo tipo1 in tiposdeVehiculosObjt.ArregloDeTipos)
            {
                if (tipo1 != null)
                {
                    if (tipo1.Id == id)
                    {
                        tipoEncontrado = tipo1;
                        break;
                    }
                }
            }
            return tipoEncontrado;
        }

        public Sucursal sacarSucursal(int idsucursal)
        {
            Sucursal sucursalEncontrada = new Sucursal();
            foreach (Sucursal sucursalAux in sucursalesObjt.ArregloSucursal)
            {
                if (sucursalAux != null) //debe verificar porque llega a nulo por ser un arreglo estatico
                {
                    if (sucursalAux.IdSucursal == idsucursal)
                    {
                        sucursalEncontrada = sucursalAux;
                    }
                }
            }
            return sucursalEncontrada;
        }


        public List<VehiculoSucursal> precargarVehiculosSucursal1() //méetodo que cargará los datos que se encuentren en el
        {
            List<VehiculoSucursal> lista = new List<VehiculoSucursal>();
            string query = @"Select * from VehiculoSucursal";
            conexion.Conexion().Open();
            comando = new SqlCommand(query, conexion.Conexion());
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra
           while (dr.Read())
            {
               lista.Add((ConvertirVehiculoSucursal(dr)));

            }
            dr.Close();
            conexion.Conexion().Close();
            return lista;
        }


        public List<VehiculoSucursal> CargarVehiculosSucursales(int idSucursal) //méetodo que cargará los datos que se encuentren en el
        {
            int id = Convert.ToInt32(idSucursal);
            List<VehiculoSucursal> listVehiculoSucursal = new List<VehiculoSucursal>();
            string query = @"Select * from VehiculoSucursal where [IdSucursal] = '" + id + "' ";
            conexion.Conexion().Open();
            comando = new SqlCommand(query, conexion.Conexion());
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra
            while (dr.Read())
            {
                listVehiculoSucursal.Add(ConvertirVehiculoSucursal1(dr));

            }
            dr.Close();
            conexion.Conexion().Close();
            return listVehiculoSucursal;
        }

        private VehiculoSucursal ConvertirVehiculoSucursal1(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            Vehiculo vehiculo;
            vehiculo = sacarVehiculo(Convert.ToString(dr["IdPlaca"]));
            VehiculoSucursal vehiculoSucursal = new VehiculoSucursal(Convert.ToInt32(dr["IdAsignacion"]), sacarSucursal(Convert.ToInt32(dr["IdSucursal"])), vehiculo, Convert.ToDateTime(dr["FechaAsignacion"]));
            return vehiculoSucursal;
        }
    }
}
