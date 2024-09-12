namespace Tarea1_YerlinReyes
{
    partial class RegistroClientes
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
            System.Windows.Forms.Button AgregarBtn;
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.segundoApellido = new System.Windows.Forms.TextBox();
            this.priemrApellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.idCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.generoCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            AgregarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarBtn
            // 
            AgregarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            AgregarBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AgregarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            AgregarBtn.Location = new System.Drawing.Point(606, 474);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new System.Drawing.Size(107, 74);
            AgregarBtn.TabIndex = 19;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseCompatibleTextRendering = true;
            AgregarBtn.UseVisualStyleBackColor = false;
            AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Primer apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Identificación del cliente:";
            // 
            // segundoApellido
            // 
            this.segundoApellido.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.segundoApellido.Location = new System.Drawing.Point(328, 268);
            this.segundoApellido.Name = "segundoApellido";
            this.segundoApellido.Size = new System.Drawing.Size(368, 32);
            this.segundoApellido.TabIndex = 16;
            // 
            // priemrApellido
            // 
            this.priemrApellido.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priemrApellido.Location = new System.Drawing.Point(328, 188);
            this.priemrApellido.Name = "priemrApellido";
            this.priemrApellido.Size = new System.Drawing.Size(368, 32);
            this.priemrApellido.TabIndex = 15;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombre.Location = new System.Drawing.Point(328, 116);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(368, 32);
            this.nombre.TabIndex = 14;
            // 
            // idCliente
            // 
            this.idCliente.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idCliente.Location = new System.Drawing.Point(328, 40);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(368, 32);
            this.idCliente.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(61, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha nacimiento:";
            // 
            // generoCB
            // 
            this.generoCB.FormattingEnabled = true;
            this.generoCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.generoCB.Items.AddRange(new object[] {
            "F",
            "M"});
            this.generoCB.Location = new System.Drawing.Point(328, 403);
            this.generoCB.Name = "generoCB";
            this.generoCB.Size = new System.Drawing.Size(200, 29);
            this.generoCB.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "-";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 341);
            this.dateTimePicker1.MinDate = new System.DateTime(1969, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(368, 32);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 560);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.generoCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(AgregarBtn);
            this.Controls.Add(this.segundoApellido);
            this.Controls.Add(this.priemrApellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.idCliente);
            this.Name = "RegistroClientes";
            this.Text = "Registro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button AgregarBtn;
        private TextBox segundoApellido;
        private TextBox priemrApellido;
        private TextBox nombre;
        private TextBox idCliente;
        private Label label6;
        private ComboBox generoCB;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}