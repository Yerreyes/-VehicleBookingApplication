namespace Cliente.Rentau
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConectar = new System.Windows.Forms.Button();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.buttonAgregarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DesconectadoLabel = new System.Windows.Forms.Label();
            this.labelAviso = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConectar.Location = new System.Drawing.Point(30, 196);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(128, 60);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click_1);
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(170, 65);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(177, 32);
            this.textBoxIdCliente.TabIndex = 1;
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDesconectar.Enabled = false;
            this.buttonDesconectar.Location = new System.Drawing.Point(218, 196);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(129, 60);
            this.buttonDesconectar.TabIndex = 2;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = false;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // buttonAgregarReserva
            // 
            this.buttonAgregarReserva.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonAgregarReserva.Enabled = false;
            this.buttonAgregarReserva.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregarReserva.Location = new System.Drawing.Point(196, 417);
            this.buttonAgregarReserva.Name = "buttonAgregarReserva";
            this.buttonAgregarReserva.Size = new System.Drawing.Size(146, 56);
            this.buttonAgregarReserva.TabIndex = 3;
            this.buttonAgregarReserva.Text = "Agregar Reservación";
            this.buttonAgregarReserva.UseVisualStyleBackColor = false;
            this.buttonAgregarReserva.Click += new System.EventHandler(this.buttonAgregarReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Por favor complete a información:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Para agregar una reserva debe conectarse:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonConectar);
            this.groupBox1.Controls.Add(this.textBoxIdCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDesconectar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(73, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DesconectadoLabel);
            this.groupBox2.Location = new System.Drawing.Point(421, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 171);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "-";
            // 
            // DesconectadoLabel
            // 
            this.DesconectadoLabel.AutoSize = true;
            this.DesconectadoLabel.Location = new System.Drawing.Point(34, 51);
            this.DesconectadoLabel.Name = "DesconectadoLabel";
            this.DesconectadoLabel.Size = new System.Drawing.Size(126, 23);
            this.DesconectadoLabel.TabIndex = 0;
            this.DesconectadoLabel.Text = "Desconectado";
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAviso.Location = new System.Drawing.Point(308, 378);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(237, 23);
            this.labelAviso.TabIndex = 8;
            this.labelAviso.Text = "!!Primero debe conectarse!!";
            this.labelAviso.Click += new System.EventHandler(this.labelAviso_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonConsultar.Enabled = false;
            this.buttonConsultar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConsultar.Location = new System.Drawing.Point(485, 417);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(146, 56);
            this.buttonConsultar.TabIndex = 9;
            this.buttonConsultar.Text = "Consultar Reservación";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(870, 517);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAgregarReserva);
            this.Name = "MenuForm";
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConectar;
        private TextBox textBoxIdCliente;
        private Button buttonDesconectar;
        private Button buttonAgregarReserva;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label DesconectadoLabel;
        private Label labelAviso;
        private Label label4;
        private Button buttonConsultar;
    }
}