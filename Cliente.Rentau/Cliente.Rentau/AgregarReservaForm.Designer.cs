namespace Cliente.Rentau
{
    partial class agregar_reserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonResumen = new System.Windows.Forms.Button();
            this.comboBoxSucursales = new System.Windows.Forms.ComboBox();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCoberturas = new System.Windows.Forms.ComboBox();
            this.buttonDisponibilidad = new System.Windows.Forms.Button();
            this.labelElejir = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxHacerReserva = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonConsultarReservaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxHacerReserva.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonResumen
            // 
            this.buttonResumen.BackColor = System.Drawing.Color.LightPink;
            this.buttonResumen.Enabled = false;
            this.buttonResumen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonResumen.Location = new System.Drawing.Point(179, 194);
            this.buttonResumen.Name = "buttonResumen";
            this.buttonResumen.Size = new System.Drawing.Size(186, 42);
            this.buttonResumen.TabIndex = 0;
            this.buttonResumen.Text = "Resumen Final";
            this.buttonResumen.UseVisualStyleBackColor = false;
            this.buttonResumen.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSucursales
            // 
            this.comboBoxSucursales.FormattingEnabled = true;
            this.comboBoxSucursales.Location = new System.Drawing.Point(36, 121);
            this.comboBoxSucursales.Name = "comboBoxSucursales";
            this.comboBoxSucursales.Size = new System.Drawing.Size(538, 29);
            this.comboBoxSucursales.TabIndex = 1;
            this.comboBoxSucursales.SelectedIndexChanged += new System.EventHandler(this.comboBoxSucursales_SelectedIndexChanged);
            // 
            // dataGridViewVehiculos
            // 
            this.dataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculos.Location = new System.Drawing.Point(36, 194);
            this.dataGridViewVehiculos.MultiSelect = false;
            this.dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            this.dataGridViewVehiculos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVehiculos.RowTemplate.Height = 31;
            this.dataGridViewVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVehiculos.Size = new System.Drawing.Size(643, 171);
            this.dataGridViewVehiculos.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 419);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 29);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(298, 419);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 29);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id de reserva:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Location = new System.Drawing.Point(840, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de cliente:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(17, 35);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(16, 21);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione la Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seleccione el vehículo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de fin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(857, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "-";
            // 
            // comboBoxCoberturas
            // 
            this.comboBoxCoberturas.Enabled = false;
            this.comboBoxCoberturas.FormattingEnabled = true;
            this.comboBoxCoberturas.Location = new System.Drawing.Point(25, 544);
            this.comboBoxCoberturas.Name = "comboBoxCoberturas";
            this.comboBoxCoberturas.Size = new System.Drawing.Size(679, 29);
            this.comboBoxCoberturas.TabIndex = 14;
            // 
            // buttonDisponibilidad
            // 
            this.buttonDisponibilidad.BackColor = System.Drawing.Color.LightPink;
            this.buttonDisponibilidad.Location = new System.Drawing.Point(490, 395);
            this.buttonDisponibilidad.Name = "buttonDisponibilidad";
            this.buttonDisponibilidad.Size = new System.Drawing.Size(189, 66);
            this.buttonDisponibilidad.TabIndex = 17;
            this.buttonDisponibilidad.Text = "Consultar Disponibilidad";
            this.buttonDisponibilidad.UseVisualStyleBackColor = false;
            this.buttonDisponibilidad.Click += new System.EventHandler(this.buttonDisponibilidad_Click);
            // 
            // labelElejir
            // 
            this.labelElejir.AutoSize = true;
            this.labelElejir.Enabled = false;
            this.labelElejir.Location = new System.Drawing.Point(42, 507);
            this.labelElejir.Name = "labelElejir";
            this.labelElejir.Size = new System.Drawing.Size(138, 21);
            this.labelElejir.TabIndex = 18;
            this.labelElejir.Text = "Elija la cobertura:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Debe completar los datos y dar Reserva Final"});
            this.listBox1.Location = new System.Drawing.Point(19, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(468, 151);
            this.listBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Location = new System.Drawing.Point(89, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Si desea generar la reserva presione:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSucursales);
            this.groupBox2.Controls.Add(this.dataGridViewVehiculos);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.buttonDisponibilidad);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 476);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Complete la siguiente infomación:";
            // 
            // groupBoxHacerReserva
            // 
            this.groupBoxHacerReserva.Controls.Add(this.label9);
            this.groupBoxHacerReserva.Controls.Add(this.button1);
            this.groupBoxHacerReserva.Enabled = false;
            this.groupBoxHacerReserva.Location = new System.Drawing.Point(870, 398);
            this.groupBoxHacerReserva.Name = "groupBoxHacerReserva";
            this.groupBoxHacerReserva.Size = new System.Drawing.Size(273, 130);
            this.groupBoxHacerReserva.TabIndex = 23;
            this.groupBoxHacerReserva.TabStop = false;
            this.groupBoxHacerReserva.Text = "Hacer reserva";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.buttonResumen);
            this.groupBox3.Location = new System.Drawing.Point(741, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 246);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen de reserva:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.labelElejir);
            this.groupBox4.Controls.Add(this.groupBoxHacerReserva);
            this.groupBox4.Controls.Add(this.comboBoxCoberturas);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(17, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1260, 605);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registro";
            // 
            // buttonConsultarReservaciones
            // 
            this.buttonConsultarReservaciones.BackColor = System.Drawing.Color.Thistle;
            this.buttonConsultarReservaciones.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConsultarReservaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConsultarReservaciones.Location = new System.Drawing.Point(918, 623);
            this.buttonConsultarReservaciones.Name = "buttonConsultarReservaciones";
            this.buttonConsultarReservaciones.Size = new System.Drawing.Size(242, 53);
            this.buttonConsultarReservaciones.TabIndex = 26;
            this.buttonConsultarReservaciones.Text = "Consultar Reservaciones";
            this.buttonConsultarReservaciones.UseVisualStyleBackColor = false;
            this.buttonConsultarReservaciones.Click += new System.EventHandler(this.buttonConsultarReservaciones_Click);
            // 
            // agregar_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1301, 686);
            this.Controls.Add(this.buttonConsultarReservaciones);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "agregar_reserva";
            this.Text = "Agregar Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxHacerReserva.ResumeLayout(false);
            this.groupBoxHacerReserva.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonResumen;
        private ComboBox comboBoxSucursales;
        private DataGridView dataGridViewVehiculos;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label labelCliente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxCoberturas;
        private Button buttonDisponibilidad;
        private Label labelElejir;
        private ListBox listBox1;
        private Button button1;
        private Label label9;
        private GroupBox groupBox2;
        private GroupBox groupBoxHacerReserva;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button buttonConsultarReservaciones;
    }
}