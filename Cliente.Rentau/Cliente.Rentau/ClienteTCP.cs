

using CapaEntidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Tarea1_YerlinReyes;

namespace Cliente.Rentau
{
    public class ClienteTCP
    {
        // Los metodos fueron basados y adaptados del el ejemplo de biblioteca del profesor tutor Juan Plablo Navarro
        private static IPAddress ipdelServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;



        public static bool encendido; // me va ayudar a controlar si ese usuario esta conectado y si si cuando cierre el form general desconectara todo y cierra y ya esta descoenctado no pasa nada;
        public static bool Conectar(string pIdentificadorCliente)
        {
            try
            {
                ipdelServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipdelServidor, 14100);
                cliente.Connect(serverEndPoint);
                MensajeSocket<string> mensajeConectar = new MensajeSocket<string> { Metodo = "Conectar", Entidad = pIdentificadorCliente };
                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                clienteStreamWriter.Flush();
                encendido = true;
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
            return true;
        }

        public static bool Desconectar(string pIdentificadorCliente)
        {
            try
            {
                MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = pIdentificadorCliente };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
                clienteStreamWriter.Flush();
                //Se cierra la conexión del cliente
                cliente.Close();
                encendido = false;
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
            return true;
        }

        public static bool AgregarReserva(ReservaVehiculo reserva)
        {
            bool agregadoconexito = false;   
            MensajeSocket<ReservaVehiculo> mensajeReserva = new MensajeSocket<ReservaVehiculo> { Metodo = "AgregarReserva", Entidad = reserva };
            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeReserva));
            clienteStreamWriter.Flush();
            agregadoconexito= true;   
            return true;
        }

          
        public static List<Sucursal> ObtenerSucursales()
        {
            List<Sucursal> lsitaSucursales = new List<Sucursal>();

            try
            {
                MensajeSocket<string> mensajeSacarSucursales = new MensajeSocket<string> { Metodo = "ConsultarSucursales" };

                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeSacarSucursales));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                
                lsitaSucursales = JsonConvert.DeserializeObject<List<Sucursal>>(mensaje);

                return lsitaSucursales;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public static List<VehiculoSucursal> ObtenerVehiculoSucursal()
        {
            List<VehiculoSucursal> listaVehiculoXsucursal = new List<VehiculoSucursal>();

            MensajeSocket<string> mensajeSacarSucursales = new MensajeSocket<string> { Metodo = "ConsultarVehiculoSucursal" };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeSacarSucursales));
            clienteStreamWriter.Flush();

            var mensaje = clienteStreamReader.ReadLine();
   
            listaVehiculoXsucursal = JsonConvert.DeserializeObject<List<VehiculoSucursal>>(mensaje);
            return listaVehiculoXsucursal;   
        }

        public static bool validarCliente(int idCliente) // metodo que usa el clienteStreamWriter para indicarle al servido el medotoco por hacer, en este caso validarClien
        {
            Boolean existe = false;

            MensajeSocket<int> mensajeValidarCliente = new MensajeSocket<int> { Metodo = "ValidarCliente", Entidad = idCliente };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeValidarCliente));
            clienteStreamWriter.Flush();

            var mensaje = clienteStreamReader.ReadLine();

            existe = JsonConvert.DeserializeObject<Boolean>(mensaje);
            return existe;
        }

        public static Tarea1_YerlinReyes.Cliente sacarCliente(int idCliente)
        {
            Tarea1_YerlinReyes.Cliente existe ;
            
            MensajeSocket<int> mensajeCliente = new MensajeSocket<int> { Metodo = "SacarCliente", Entidad = idCliente };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeCliente));
            clienteStreamWriter.Flush();

            var mensaje = clienteStreamReader.ReadLine();

            existe = JsonConvert.DeserializeObject<Tarea1_YerlinReyes.Cliente>(mensaje);
            return existe;
        }


        public static bool RangoReservaciones(ReservaVehiculo reservaXregistrar)
        {
            bool existe = false;
            try
            {
                 MensajeSocket<ReservaVehiculo> mensajeRango = new MensajeSocket<ReservaVehiculo> { Metodo = "verificarRango", Entidad = reservaXregistrar };

                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeRango));
                clienteStreamWriter.Flush();
                
                var mensaje1 = clienteStreamReader.ReadLine();

                 existe = JsonConvert.DeserializeObject<Boolean>(mensaje1);
                return existe;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Cobertura> cargarCoberturas()
        {
            List<Cobertura> lista = new List<Cobertura>();
            try
            {
                MensajeSocket<int> mensajeCobertura = new MensajeSocket<int> { Metodo = "coberturasxtipo"};
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeCobertura));
                clienteStreamWriter.Flush();

                var mensaje1 = clienteStreamReader.ReadLine();
                lista.AddRange(JsonConvert.DeserializeObject<List<Cobertura>>(mensaje1));
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<ReservaVehiculo> reservasDeCliente(string idCliente)
        {
            List<ReservaVehiculo> lista = new List<ReservaVehiculo>();
            try
            {
                MensajeSocket<string> mensajeReserva = new MensajeSocket<string> { Metodo = "reservaDeCliente", Entidad = idCliente };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeReserva));
                clienteStreamWriter.Flush();

                var mensaje1 = clienteStreamReader.ReadLine();
                lista.AddRange(JsonConvert.DeserializeObject<List<ReservaVehiculo>>(mensaje1));
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
    
}
