namespace Cliente.Rentau
{
    partial class ConsultarReservaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCliente1 = new System.Windows.Forms.Label();
            this.buttonReservaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIdReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReservacion = new System.Windows.Forms.Button();
            this.dataGridViewReservaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelCliente1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(36, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 80);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            // 
            // labelCliente1
            // 
            this.labelCliente1.AutoSize = true;
            this.labelCliente1.Location = new System.Drawing.Point(19, 56);
            this.labelCliente1.Name = "labelCliente1";
            this.labelCliente1.Size = new System.Drawing.Size(16, 21);
            this.labelCliente1.TabIndex = 0;
            this.labelCliente1.Text = "-";
            // 
            // buttonReservaciones
            // 
            this.buttonReservaciones.BackColor = System.Drawing.Color.Pink;
            this.buttonReservaciones.Location = new System.Drawing.Point(78, 59);
            this.buttonReservaciones.Name = "buttonReservaciones";
            this.buttonReservaciones.Size = new System.Drawing.Size(222, 42);
            this.buttonReservaciones.TabIndex = 9;
            this.buttonReservaciones.Text = "Reservaciones";
            this.buttonReservaciones.UseVisualStyleBackColor = false;
            this.buttonReservaciones.Click += new System.EventHandler(this.buttonReservaciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consultar todas las reservaciones de este cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonReservaciones);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(36, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 146);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxIdReserva);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.buttonReservacion);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(502, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 146);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // textBoxIdReserva
            // 
            this.textBoxIdReserva.Location = new System.Drawing.Point(44, 63);
            this.textBoxIdReserva.Name = "textBoxIdReserva";
            this.textBoxIdReserva.Size = new System.Drawing.Size(291, 29);
            this.textBoxIdReserva.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Consultar reservaciones por Id Reservacion:";
            // 
            // buttonReservacion
            // 
            this.buttonReservacion.BackColor = System.Drawing.Color.Pink;
            this.buttonReservacion.Location = new System.Drawing.Point(78, 98);
            this.buttonReservacion.Name = "buttonReservacion";
            this.buttonReservacion.Size = new System.Drawing.Size(222, 42);
            this.buttonReservacion.TabIndex = 9;
            this.buttonReservacion.Text = "Reservación";
            this.buttonReservacion.UseVisualStyleBackColor = false;
            this.buttonReservacion.Click += new System.EventHandler(this.buttonReservacion_Click);
            // 
            // dataGridViewReservaciones
            // 
            this.dataGridViewReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservaciones.Location = new System.Drawing.Point(36, 272);
            this.dataGridViewReservaciones.Name = "dataGridViewReservaciones";
            this.dataGridViewReservaciones.RowTemplate.Height = 31;
            this.dataGridViewReservaciones.Size = new System.Drawing.Size(901, 224);
            this.dataGridViewReservaciones.TabIndex = 13;
            // 
            // ConsultarReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(989, 546);
            this.Controls.Add(this.dataGridViewReservaciones);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ConsultarReservaForm";
            this.Text = "Consultar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label labelCliente1;
        private Button buttonReservaciones;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxIdReserva;
        private Label label2;
        private Button buttonReservacion;
        private DataGridView dataGridViewReservaciones;
        private Label label3;
    }
}