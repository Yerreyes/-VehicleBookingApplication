


using CapaEntidades;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;

namespace Tarea1_YerlinReyes
{
    public partial class MenuPrincipal : Form
    {

        Sucursales sucursalesObjt = new Sucursales();
        Clientes clientesObjt = new Clientes();
        TiposdeVehiculos tiposdeVehiculosObjt = new TiposdeVehiculos();
        Vehiculos vehiculosObjt = new Vehiculos();
        VehiculoSucursales vehiculoSucursalesObjt = new VehiculoSucursales();
        Coberturas coberturasObjt = new Coberturas();
        ConexionBD conexion = new ConexionBD();
        precarga precarga1;

        public MenuPrincipal()
        {
            InitializeComponent();
            precargarDatos();
            modificarTextotxtBitacora = new EscribirEnTextboxDelegado(EscribirEnTextbox);
            modificarListBoxClientes = new ModificarListBoxDelegado(ModificarListBox);
            buttonColorRojo.BackColor = Color.Red;
        }

        //metodo que va instanciar la clase que precarga los datos
        public void precargarDatos()
        {
            precarga1 = new precarga(sucursalesObjt, clientesObjt, tiposdeVehiculosObjt, vehiculosObjt, vehiculoSucursalesObjt, coberturasObjt, conexion);
        }

        // Eventos de Sucursal
        private void resgistroSucursal_Click(object sender, EventArgs e)
        {
            RegistroSucursales ventanaRegistroSucursales = new RegistroSucursales(sucursalesObjt, conexion);
            ventanaRegistroSucursales.Show();
        }

        private void consultaSucursal_Click(object sender, EventArgs e)
        {
            ConsultarSucursales ventanaConsultaSucursal = new ConsultarSucursales(sucursalesObjt);
            ventanaConsultaSucursal.Show();
        }

        //Eventos de Cliente
        private void registroCliente_Click(object sender, EventArgs e)
        {
            RegistroClientes ventanaRegistroClientes = new RegistroClientes(clientesObjt, conexion);
            ventanaRegistroClientes.Show();
        }

        private void consultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarClientes ventanaConsultarClientes = new(clientesObjt);
            ventanaConsultarClientes.Show();
        }


        //Eventos de TipoDeVehiculo
        private void registroTipoVehiculo_Click(object sender, EventArgs e)
        {
            RegistroTipoVehiculo ventanaRegistroTipoVehiculo = new(tiposdeVehiculosObjt, conexion);
            ventanaRegistroTipoVehiculo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarTipoVehiculo ventanaConsultarTipoVehiculo = new(tiposdeVehiculosObjt);
            ventanaConsultarTipoVehiculo.Show();
        }

        //Eventos de Vehiculo
        private void registroVehiculo_Click(object sender, EventArgs e)
        {
            if (tiposdeVehiculosObjt.CantidadDeTipos != 0)
            {
                RegistroVehiculos ventanaRegistroVehiculos = new(tiposdeVehiculosObjt, vehiculosObjt, conexion);
                ventanaRegistroVehiculos.Show();
            }
            else
            {
                MessageBox.Show("Debes registrar el tipo de vehículo para poder continuar");
                RegistroTipoVehiculo ventanaRegistroTipoVehiculo = new(tiposdeVehiculosObjt, conexion);
                ventanaRegistroTipoVehiculo.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarVehiculos ventanaConsultarVehiculos = new(vehiculosObjt, tiposdeVehiculosObjt);
            ventanaConsultarVehiculos.Show();
        }

        // Eventos de VehiculoSucursal
        private void RegistroVehiculoSucursal_Click(object sender, EventArgs e)
        {
            //envío vehiculos y susucrsales, para que el arreglo se muestre en el combo. Ademas del vehiculoSucursales 
            RegistroVehiculoSucursal ventanaRegistroVehiculoSucursal = new(vehiculosObjt, sucursalesObjt, vehiculoSucursalesObjt, tiposdeVehiculosObjt, conexion);
            ventanaRegistroVehiculoSucursal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarAsociacion ventanaConsultarAsociacion = new(vehiculoSucursalesObjt, sucursalesObjt, conexion, vehiculosObjt);
            ventanaConsultarAsociacion.Show();
        }

        private void button_registarCobertura_Click(object sender, EventArgs e)
        {
            RegistroCobertura ventanaregistarCobertura = new(coberturasObjt, tiposdeVehiculosObjt, conexion);
            ventanaregistarCobertura.Show();
        }

        private void button_consultarCobertura_Click(object sender, EventArgs e)
        {
            ConsultarCobertura ventanaConsultarCobertura = new ConsultarCobertura(coberturasObjt, tiposdeVehiculosObjt);
            ventanaConsultarCobertura.Show();
        }

        // Manipulacion de todo lo de cliente servidor
        ///*********///
        ///             


        // Los metodos fueron basados y adaptados del el ejemplo de biblioteca del profesor tutor Juan Plablo Navarro
        TcpListener tcpListener;
        Thread subprocesoEscuchaClientes;
        EscribirEnTextboxDelegado modificarTextotxtBitacora;
        ModificarListBoxDelegado modificarListBoxClientes;

        bool servidorIniciado;


        //Delegado, permite que se pueda ejecutar otros en la interfaz hilos sin interrumpir o caer el hilo principal de la interfaz
        private delegate void EscribirEnTextboxDelegado(string texto);
        private delegate void ModificarListBoxDelegado(string texto, bool agregar);

        //Método utilizado por el delegado para modificar la interfaz gráfica desde un subproceso
        private void EscribirEnTextbox(string texto)
        {
            textBoxBitacora.AppendText(DateTime.Now.ToString() + " -  " + texto);
            textBoxBitacora.AppendText(Environment.NewLine);
        }

        //Método utilizado por el delegado para modificar la interfaz gráfica desde un subproceso
        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                listBoxClientesConectados.Items.Add(texto);
            }
            else
            {
                listBoxClientesConectados.Items.Remove(texto);
            }
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1"); //es localhost, aca es donde recibe la conexion
            tcpListener = new TcpListener(local, 14100); // 

            servidorIniciado = true;
            subprocesoEscuchaClientes = new Thread(new ThreadStart(EscucharClientes));
            subprocesoEscuchaClientes.Start();
            subprocesoEscuchaClientes.IsBackground = true;
            textBoxBitacora.Text = "El servidor iniciado... en (127.0.0.1, 10400)";
            textBoxBitacora.AppendText(Environment.NewLine);
            buttonColorRojo.BackColor = Color.Transparent;
            buttonColorVerde.BackColor = Color.GreenYellow;
            this.buttonConectar.Enabled = false;
            buttonDesconectar.Enabled = true;
            buttonDesconectar.BackColor = Color.LightPink;
            buttonConectar.BackColor = Color.LightGray;
        }

        private void EscucharClientes() //metodo que me va iniciar la escucha de llamdas de clientes
        {
            tcpListener.Start();
            try
            {
                while (servidorIniciado) // mientras el servidior este conectado el va a inicar el tcp listener que va a estar pendiente de un nuevo cliente
                {
                    //se mantienen bloqueado, en el momento que llega una conexion la acepta
                    TcpClient clientenuevo = tcpListener.AcceptTcpClient();
                    /*Se crea un nuevo hilo para manejar la comunicación con los clientes que se conectan al servidor*/
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clientThread.Start(clientenuevo);
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        private void ComunicacionCliente(object cliente) //metodo intermedio que funciona para ver que es lo que trae los paquetes esa llamada al servidor, entonces serializa
        {
            TcpClient tcCliente = (TcpClient)cliente;
            StreamReader reader = new StreamReader(tcCliente.GetStream()); // agarra el objeto que se paso que veiene en bytes y lo convierte con el getstream
            StreamWriter servidorStreamWriter = new StreamWriter(tcCliente.GetStream());//El StreamWriter debe ser único por subproceso y por cliente por eso se pasa por referencia

            while (servidorIniciado) 
            {
                try
                {
                    //Esta sección se bloquea hasta que el cliente envíe unmensaje
                    var mensaje = reader.ReadLine();
                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje);//Se deserializa el objeto recibido mediante json
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorStreamWriter); //determina que es lo que quiere hacer
                }
                catch (Exception e)
                {
                    // el mensaja que envia el usuario  por el socket  no es correcto entonce no hace nada
                    break;
                }
            }
            tcCliente.Close(); // cuando ya el servidor se apaga, se termina el cliente;
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            buttonConectar.Enabled = true;
            servidorIniciado = false;
            tcpListener.Stop(); // cierra la espera de clientes;
            buttonColorRojo.BackColor = Color.Red;
            buttonColorVerde.BackColor = Color.Transparent;
            buttonDesconectar.Enabled = false;
            buttonDesconectar.BackColor = Color.LightSlateGray;
            buttonConectar.BackColor = Color.LightPink;
            
        }

        public void SeleccionarMetodo(String metodo, string mensaje, ref StreamWriter servidorStreamWriter)
        {
            switch (metodo)
            {
                case "Conectar":
                    MensajeSocket<string> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);// Se deserializa el objeto recibido mediante json
                    Conectar(mensajeConectar.Entidad);
                    break;

                case "Desconectar":
                    MensajeSocket<string> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);// Se deserializa el objeto recibido mediante json
                    Desconectar(mensajeDesconectar.Entidad);
                    break;

                case "AgregarReserva":
                    MensajeSocket<ReservaVehiculo> mensajeCrearAutor = JsonConvert.DeserializeObject<MensajeSocket<ReservaVehiculo>>(mensaje);// Se deserializa el objeto recibido mediante json   
                    AgregarReserva1(mensajeCrearAutor.Entidad);
                
                    break;

                case "ConsultarSucursales":
                    MensajeSocket<ReservaVehiculo> mensajeConsultarS = JsonConvert.DeserializeObject<MensajeSocket<ReservaVehiculo>>(mensaje);// Se deserializa el objeto recibido mediante json
                    consultarSucursales(ref servidorStreamWriter);
                    break;

                case "ConsultarVehiculoSucursal":                    
                    MensajeSocket<string> mensajeConsultarVS = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);// Se deserializa el objeto recibido mediante json
                    consultarVehiculoSucursal1(ref servidorStreamWriter);     
                    break;

                case "ValidarCliente":
                    MensajeSocket<string> mensajeValidarCliente = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);// Se deserializa el objeto recibido mediante json
                    validarCliente(mensajeValidarCliente.Entidad,ref servidorStreamWriter);
                    break;

                case "SacarCliente":
                    MensajeSocket<string> mensajeSacarCliente = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);// Se deserializa el objeto recibido mediante json
                    sacarCliente(mensajeSacarCliente.Entidad, ref servidorStreamWriter);
                    break;
                case "verificarRango":
                    MensajeSocket<ReservaVehiculo> mensajeverificar = JsonConvert.DeserializeObject<MensajeSocket<ReservaVehiculo>>(mensaje);// Se deserializa el objeto recibido mediante json
                    verificaRango(mensajeverificar.Entidad, ref servidorStreamWriter);
                    break;
                case "coberturasxtipo":
                    MensajeSocket<int> mensajeCoberturas = JsonConvert.DeserializeObject<MensajeSocket<int>>(mensaje);// Se deserializa el objeto recibido mediante json
                    consultarCobertura( ref servidorStreamWriter);
                    break;
                case "reservaDeCliente":
                    MensajeSocket<string> mensajeReservas = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);// Se deserializa el objeto recibido mediante json
                    consultarReserva(mensajeReservas.Entidad, ref servidorStreamWriter);
                    break;

                default:
                    break;
            }
          }



        //Control de region critica 
        private static object control = new object();
       

        private void AgregarReserva1(ReservaVehiculo reservaVehiculo)
        {

            lock (control)
            {
                conexion.insertarReserva(reservaVehiculo);
                textBoxBitacora.Invoke(modificarTextotxtBitacora, new object[] { reservaVehiculo.idCliente + " agrego una reserva" });
            }
        }

        private void consultarSucursales(ref StreamWriter servidorStreamWriter) // llama a la BD y saca la lista de sucursales
        {
            lock (control) {
                List<Sucursal> listaSucursal = new List<Sucursal>();

                listaSucursal = conexion.cargarSucursales();

                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaSucursal));
                servidorStreamWriter.Flush();
            }
        }

        public void Conectar(string pid)
        {
            lock (control)
            {
                textBoxBitacora.Invoke(modificarTextotxtBitacora, new object[] { pid + " se ha conectado..." });
                listBoxClientesConectados.Invoke(modificarListBoxClientes, new object[] { pid, true });
            }
        } // se usa el invoke porque es algo que viene desde diferentes clientes

        private void Desconectar(string pid)
        {
            textBoxBitacora.Invoke(modificarTextotxtBitacora, new object[] { pid + " se ha desconectado!" });
            listBoxClientesConectados.Invoke(modificarListBoxClientes, new object[] { pid, false });
        }

        private void consultarVehiculoSucursal1(ref StreamWriter servidorStreamWriter)
        {
            lock (control)
            {
                List<VehiculoSucursal> listaVehiculoSucursal = new List<VehiculoSucursal>();
                listaVehiculoSucursal = vehiculoSucursalesObjt.ArregloVS;

                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaVehiculoSucursal));
                servidorStreamWriter.Flush();
            }
        }

        public void validarCliente(String idCliente,ref StreamWriter servidorStreamWriter)
        {
            lock (control)
            {
                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(conexion.repetidoCliente(idCliente)));
                servidorStreamWriter.Flush();
            }
        }

        public void sacarCliente(String idCliente, ref StreamWriter servidorStreamWriter)
        {
            lock (control)
            {
                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(conexion.sacarCliente(Convert.ToInt32(idCliente))));
                servidorStreamWriter.Flush();
            }
        
        }

        public void verificaRango(ReservaVehiculo reserva,ref StreamWriter servidorStreamWriter)
        {
            lock (control)
            {
                Boolean existe = false;
                existe = Verificar(reserva);
                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(existe));
                servidorStreamWriter.Flush();
            }
        }



        private Boolean Verificar(ReservaVehiculo reserva) //metodo que va obtener la lista con las reservaciones que tiene ese vehiculo en comun
        {    lock (control)
            {
                Boolean veridifcado = false;
                List<ReservaVehiculo> listaconvehiculos = new List<ReservaVehiculo>();
                listaconvehiculos.AddRange(conexion.ObtenerReserva(reserva));

                foreach (ReservaVehiculo reservaAux in listaconvehiculos)
                {
                    //casos posibles de que ya ese rango de fechas este reservado

                    if (reservaAux.fechaInicio.Date == reserva.fechaInicio.Date || reservaAux.fechafinal.Date == reserva.fechafinal.Date) // primer caso
                    {
                        //  MessageBox.Show("ese dia ya");
                        return true;
                    }
                    if (reservaAux.fechaInicio < reserva.fechaInicio && reservaAux.fechafinal > reserva.fechafinal)
                    {
                        // MessageBox.Show("caso 1" + "inicio consulta:" + reservaAux.fechaInicio +"  "+ reservaAux.fechafinal);
                        return true;
                    }

                    if (reservaAux.fechaInicio > reserva.fechaInicio && reservaAux.fechafinal > reserva.fechafinal && reservaAux.fechaInicio < reserva.fechafinal)

                    {
                        // MessageBox.Show("caso 2" + "inicio consulta:" + reservaAux.fechaInicio + "  " + reservaAux.fechafinal);
                        return true;
                    }

                    if (reservaAux.fechaInicio > reserva.fechaInicio && reservaAux.fechafinal < reserva.fechafinal)
                    {
                        // MessageBox.Show("caso 3 " + "inicio consulta:" + reservaAux.fechaInicio + "  " + reservaAux.fechafinal);
                        return true;
                    }

                    if (reservaAux.fechaInicio < reserva.fechaInicio && reservaAux.fechafinal < reserva.fechafinal && reserva.fechaInicio < reservaAux.fechafinal)
                    {
                        // MessageBox.Show("caso 4 " + "inicio consulta:" + reservaAux.fechaInicio + "  " + reservaAux.fechafinal);
                        return true;
                    }



                }
                return veridifcado;
            }
        }

        private List<Cobertura> consultarCobertura(ref StreamWriter servidorStreamWriter)
        {
            lock(control){
                List<Cobertura> listaCobertura = new List<Cobertura>();
                listaCobertura = coberturasObjt.ArregloCoberturas;
                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaCobertura));
                servidorStreamWriter.Flush();
                return listaCobertura;
            }
        }

        private List<ReservaVehiculo> consultarReserva(String idliente,ref StreamWriter servidorStreamWriter)
        {
            lock (control)
            {
                List<ReservaVehiculo> lista = new List<ReservaVehiculo>();
                lista = conexion.ObtenerReservaDeCliente(idliente);
                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(lista));
                servidorStreamWriter.Flush();

                textBoxBitacora.Invoke(modificarTextotxtBitacora, new object[] { idliente + " Consulto las reservas" });
                return lista;
            }
        }
    }
}