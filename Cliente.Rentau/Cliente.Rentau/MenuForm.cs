namespace Cliente.Rentau
{
    public  partial class MenuForm : Form
    {
        bool clienteconectado = false;
        Tarea1_YerlinReyes.Cliente cliente;
        public MenuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {

            if (ClienteTCP.Desconectar(textBoxIdCliente.Text))
             {
                DesconectadoLabel.Text = "Desconectado";
                label4.Text = "Identificación: " + (textBoxIdCliente.Text);
                DesconectadoLabel.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                buttonAgregarReserva.Enabled = false;
                labelAviso.Text = "Debe conectarse para hacer reserva";
                buttonDesconectar.Enabled = false; ;
                buttonConectar.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Error, en la desconexion");
            }
        }

        private void buttonConectar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ClienteTCP.Conectar(textBoxIdCliente.Text)) // abre comunicacion con el servidor  y se conecta para poder acceder a la base de datos
                {
                    if (ClienteTCP.validarCliente(Convert.ToInt32(textBoxIdCliente.Text))) // solicita al servidor por medio del TCP que verifique que el cliente exista
                    {
                        DesconectadoLabel.Text = "Conectado";
                        DesconectadoLabel.ForeColor = Color.Green;
                        label4.ForeColor = Color.Green;
                        buttonAgregarReserva.Enabled = true;
                        labelAviso.Text = "Listo, puede realizar la reserva";
                        buttonDesconectar.Enabled = true;
                        buttonConectar.Enabled = false;
                        buttonConsultar.Enabled = true;


                        cliente = ClienteTCP.sacarCliente(Convert.ToInt32(textBoxIdCliente.Text));

                        label4.Text = "Cliente : " + cliente.Nombre + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido;
                    }
                    else
                    {
                        DesconectadoLabel.Text = "Desconectado";
                        label4.Text = "No existe ese Cliente";
                        label4.ForeColor = Color.Red;
                        DesconectadoLabel.ForeColor = Color.Red;
                        ClienteTCP.Desconectar("No existe cliente: " + textBoxIdCliente.Text + "por lo que  ");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que el servidor éste conectado");
                }
            }catch
            {
                //captura en caso de querer converitr un string a int y no se pueda
                ClienteTCP.Desconectar("Cedula no numerica  " + "por lo que  ");
                MessageBox.Show("La identificación debe ser un número");
            }
            
        }

        private void buttonAgregarReserva_Click(object sender, EventArgs e)
        {
            agregar_reserva a = new agregar_reserva(cliente);
            a.Show();
        }

        private void labelAviso_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarReservaForm consultar = new ConsultarReservaForm(cliente);
            consultar.Show();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClienteTCP.encendido == true)
            {
                if (ClienteTCP.Desconectar(textBoxIdCliente.Text))
                {
                    // hay una variable static bool en cliente tcp
                    //cuando el cliente esta conectado vale true
                    //si esta desconectado es false entonces al cerrar this, ya esta  desconectado
                   ////se desconecta y sale en servidor 
                }
                
            }
        }
    }
}