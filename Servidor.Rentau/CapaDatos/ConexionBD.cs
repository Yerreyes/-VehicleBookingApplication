using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;

// Los metodos fueron basados y adaptados del el ejemplo de biblioteca del profesor tutor Juan Plablo Navarro
namespace Tarea1_YerlinReyes
{
    public class ConexionBD
    {

        string cadenaConexion;
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dr;

        public ConexionBD()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionRentau"].ConnectionString;
            conexion  = new SqlConnection(cadenaConexion);
        }

       public SqlConnection Conexion() { return conexion; }


        // metodos de manipulacion de todos los datos

        public void insertarClienteBD(string idCliente, String nombre, string apellido1, string apellido2, DateTime fecha, Char genero)
        {
            
            string cadena = "INSERT INTO Cliente VALUES (@IdCliente ,@Nombre , @PrimerApellido , @SegundoApellido, @FechaNacimiento ,@Genero) ";
           
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.Add(new SqlParameter("@IdCliente", idCliente));
            comando.Parameters.Add(new SqlParameter("@Nombre", nombre));
            comando.Parameters.Add(new SqlParameter("@PrimerApellido", apellido1));
            comando.Parameters.Add(new SqlParameter("@SegundoApellido", apellido2));
            comando.Parameters.Add(new SqlParameter("@FechaNacimiento", fecha));
            comando.Parameters.Add(new SqlParameter("@Genero", genero));

            
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public void insertarSucursalBD(int idSucursal, String nombre, String direccion, bool activo, string telefono)
        {

            string cadena = "INSERT INTO [dbo].[Sucursal] ([IdSucursal] ,[Nombre] ,[Direccion] ,[Estado] ,[Telefono]) " +
            " VALUES('" + idSucursal + "', '" + nombre + "', '" + direccion + "', '" + activo + "', '" + telefono + "')";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void insertarTipoVehiculoBD(int id, String descripcion, bool activo)
        {
            string cadena = " INSERT INTO[dbo].[TipoVehiculo] ([IdTipo],[Descripcion],[Estado]) " +
            " VALUES('" + id + "', '" + descripcion + "',  '" + activo + "')";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public void insertarVehiucloBD(int id, String marca, String modelo, int idTipoVehiculo, int costo, int kilometraje)
        {
            string cadena = " INSERT INTO [dbo].[Vehiculo] ([IdPlaca],[Marca] ,[Modelo] ,[IdTipoVehiculo] ,[CostoAlquilerDia],[Kilometraje]) " +
            " VALUES('" + id + "', '" + marca + "', '" + modelo + "', '" + idTipoVehiculo + "', '" + costo + "',  '" + kilometraje + "')";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void insertarCobertura(int idCobertura, String descripcion, int idTipoVehiculo, bool activo, int monto)
        {
            string cadena = "  INSERT INTO[dbo].[CoberturaSeguro] ([IdCobertura],[Descripcion],[IdTipoVehiculo],[Estado],[Monto]) " +
            " VALUES('" + idCobertura + "', '" + descripcion + "', '" + idTipoVehiculo + "', '" + activo + "', '" + monto + "')";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
 

        public void insertarVehiculoSucursalBD(int idAsignacion, int idSucursal, String idPlaca, DateTime fecha)
        {
            string cadena = " INSERT INTO [dbo].[VehiculoSucursal] Values (@IdAsignacion ,@IdSucursal ,@IdPlaca ,@fechaAsignacion)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            
            comando.Parameters.Add(new SqlParameter("@IdAsignacion", idAsignacion));
            comando.Parameters.Add(new SqlParameter("@IdSucursal", idSucursal));
            comando.Parameters.Add(new SqlParameter("@IdPlaca", idPlaca));
            comando.Parameters.Add(new SqlParameter("@FechaAsignacion", fecha));

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void insertarReserva( ReservaVehiculo reserva)
        {
            string cadena = " INSERT INTO [dbo].[Reserva] Values (@IdReserva , @IdCliente, @IdPlaca, @FechaReserva, @FechaInicio, @FechaFin, @MontoReserva)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.Add(new SqlParameter("@IdReserva", reserva.idReserva));
            comando.Parameters.Add(new SqlParameter("@IdCliente", reserva.idCliente));
            comando.Parameters.Add(new SqlParameter("@IdPlaca", reserva.Placa));
            comando.Parameters.Add(new SqlParameter("@FechaReserva", reserva.fechaReserva));
            comando.Parameters.Add(new SqlParameter("@FechaInicio", reserva.fechaInicio));
            comando.Parameters.Add(new SqlParameter("@FechaFin", reserva.fechafinal));
            comando.Parameters.Add(new SqlParameter("@MontoReserva", reserva.montoReserva));
          
            comando.ExecuteNonQuery();
            conexion.Close();
           
        }
        // metodos para verificar repetido


        public Boolean repetidoSucursal(int idSucursal)
        {
            Boolean encontrado = false;
            string query = "Select * from [dbo].[Sucursal] where IdSucursal = '" + idSucursal + "'  ";

            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                encontrado = true;
            }
            dr.Close();

            conexion.Close();
            return encontrado;
        }

        public Boolean repetidoCliente(String idCliente)
        {
            Boolean encontrado = false;
            string query = "Select * from Cliente where IdCLiente = '" + idCliente + "'  ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                encontrado = true;
            }
            dr.Close();
            conexion.Close();
            return encontrado;
        }

        public Boolean repetidoTipoVehiculo(int idTipo)
        {
            Boolean encontrado = false;
            string query = "Select * from [dbo].[TipoVehiculo] where IdTipo = '" + idTipo + "'  ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                encontrado = true;
            }
            dr.Close();
            conexion.Close ();
            return encontrado;
        }

        public Boolean repetidoVehiculo(int idPlaca)
        {
            Boolean encontrado = false;
            string query = "Select * from [dbo].[Vehiculo] where IdPlaca = '" + idPlaca + "'  ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                encontrado = true;
                break;
            }
            dr.Close();
            conexion.Close();
            return encontrado;
        }

        public Boolean repetidoVehiculoSucursal(int idAsignacion)
        {
            Boolean encontrado = false;
            string query = "Select * from [dbo].[VehiculoSucursal] where [IdAsignacion] = '" + idAsignacion + "'  ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                encontrado = true;
                break;
            }
            dr.Close();
            conexion.Close();
            return encontrado;
        }

        public Boolean repetidoCobertura(int idCobertura)
        {
            Boolean encontrado = false;
            string query = "Select * from [dbo].[CoberturaSeguro] where [IdCobertura] = '" + idCobertura + "'  ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                encontrado = true;
                break;
            }
            dr.Close();
            conexion.Close();
            return encontrado;
        }

        //Consultas

        public List<Sucursal> cargarSucursales() //méetodo que cargará los datos que se encuentren de sucursales
        {
            List<Sucursal> listaSucursales = new List<Sucursal>();
            string query = @"Select * from [dbo].[Sucursal] where   [Estado] = '" + 1 + "'  ";
            conexion.Open();
            comando = new SqlCommand(query, conexion);
            dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                listaSucursales.Add(ConvertirSucursal(dr));
            }
            dr.Close();
            conexion.Close();
            return listaSucursales;
         }


        private Sucursal ConvertirSucursal(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            Sucursal nuevaSucursal = new Sucursal(Convert.ToInt32(dr["IdSucursal"]), Convert.ToString(dr["Nombre"]), Convert.ToString(dr["Direccion"]), Convert.ToBoolean(dr["Estado"]), Convert.ToString(dr["Telefono"]));
            return nuevaSucursal;
        }


        ///********
        public Cliente sacarCliente(int idCliente) // obtiene el cliente y lo retorna
        {
            Cliente encontrado = new Cliente();
            string query = "Select * from [dbo].[Cliente] where IdCliente = '" + idCliente + "'  ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();

            // va a recorrer el data reader si hay uno que cumple eso entonces es porque si se encuentra

            while (dr.Read())
            {
                encontrado = ConvertirCliente(dr);
                break;
            }
            dr.Close();
            conexion.Close();
            return encontrado;
        } 

        private Cliente ConvertirCliente(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            Cliente cliente = new Cliente(Convert.ToString(dr["IdCliente"]), Convert.ToString(dr["Nombre"]), Convert.ToString(dr["PrimerApellido"]), Convert.ToString(dr["SegundoApellido"]), Convert.ToDateTime(dr["FechaNacimiento"]), Convert.ToChar(dr["Genero"]));
            return cliente;
        }

        //**********////
        

        public List<ReservaVehiculo> ObtenerReserva( ReservaVehiculo reserva)
        {
            List<ReservaVehiculo> listaReserva = new List<ReservaVehiculo>();

            string query = "Select * from [dbo].[Reserva] where IdPlaca = '" + reserva.Placa + "'  ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
             dr = comando.ExecuteReader(); //aca quite el declarar;

            while (dr.Read())
            {
                listaReserva.Add(ConvertirReserva(dr));
                ew++;
            }
            dr.Close();
            conexion.Close();
            return listaReserva;
        }

        private ReservaVehiculo ConvertirReserva(SqlDataReader dr) //http://ltuttini.blogspot.com/2011/02/winforms-edicion-empleados-grabar.html
        {
            ReservaVehiculo reservaVehiculo = new ReservaVehiculo(Convert.ToInt32(dr["IdReserva"]), Convert.ToString(dr["IdPlaca"]), Convert.ToString(dr["IdCliente"]),  Convert.ToDateTime(dr["FechaReserva"]), Convert.ToDateTime(dr["FechaInicio"]), Convert.ToDateTime(dr["FechaFin"]), Convert.ToInt32(dr["MontoReserva"]));
            return reservaVehiculo;
        }
        public static int ew =0;

        public List<ReservaVehiculo> ObtenerReservaDeCliente(string idCliente)
        {

            List<ReservaVehiculo> listaReserva = new List<ReservaVehiculo>();

            string query = "Select * from [dbo].[Reserva] where [IdCliente] = '" + idCliente + "'  ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            dr = comando.ExecuteReader(); //aca quite el declarar;

            while (dr.Read())
            {
                listaReserva.Add(ConvertirReserva(dr));
            }
            dr.Close();
            conexion.Close();
            return listaReserva;
        }


    }
}
