namespace Tarea1_YerlinReyes
{
    partial class RegistroSucursales
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
            this.idSucursal = new System.Windows.Forms.TextBox();
            this.nombreSucursal = new System.Windows.Forms.TextBox();
            this.direccionSucursal = new System.Windows.Forms.TextBox();
            this.telefonoSucursal = new System.Windows.Forms.TextBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_Activo = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // idSucursal
            // 
            this.idSucursal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idSucursal.Location = new System.Drawing.Point(366, 43);
            this.idSucursal.Name = "idSucursal";
            this.idSucursal.Size = new System.Drawing.Size(452, 32);
            this.idSucursal.TabIndex = 0;
            // 
            // nombreSucursal
            // 
            this.nombreSucursal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreSucursal.Location = new System.Drawing.Point(366, 120);
            this.nombreSucursal.Name = "nombreSucursal";
            this.nombreSucursal.Size = new System.Drawing.Size(452, 32);
            this.nombreSucursal.TabIndex = 1;
            // 
            // direccionSucursal
            // 
            this.direccionSucursal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.direccionSucursal.Location = new System.Drawing.Point(366, 197);
            this.direccionSucursal.Multiline = true;
            this.direccionSucursal.Name = "direccionSucursal";
            this.direccionSucursal.Size = new System.Drawing.Size(452, 52);
            this.direccionSucursal.TabIndex = 2;
            // 
            // telefonoSucursal
            // 
            this.telefonoSucursal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefonoSucursal.Location = new System.Drawing.Point(366, 353);
            this.telefonoSucursal.Name = "telefonoSucursal";
            this.telefonoSucursal.Size = new System.Drawing.Size(344, 32);
            this.telefonoSucursal.TabIndex = 3;
            // 
            // button_Agregar
            // 
            this.button_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Agregar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Agregar.Location = new System.Drawing.Point(649, 432);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(125, 73);
            this.button_Agregar.TabIndex = 6;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = false;
            this.button_Agregar.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Identificación de la Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de la Sucursal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dirección de la Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estado de la Sucursal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número de télefono:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.Maroon;
            this.label.Location = new System.Drawing.Point(84, 422);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 23);
            this.label.TabIndex = 14;
            this.label.Text = "-                  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(84, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "-";
            // 
            // checkBox_Activo
            // 
            this.checkBox_Activo.AutoSize = true;
            this.checkBox_Activo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Activo.Location = new System.Drawing.Point(366, 285);
            this.checkBox_Activo.Name = "checkBox_Activo";
            this.checkBox_Activo.Size = new System.Drawing.Size(84, 27);
            this.checkBox_Activo.TabIndex = 17;
            this.checkBox_Activo.TabStop = true;
            this.checkBox_Activo.Text = "Activo";
            this.checkBox_Activo.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(483, 285);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 27);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inactivo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RegistroSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(845, 534);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox_Activo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.telefonoSucursal);
            this.Controls.Add(this.direccionSucursal);
            this.Controls.Add(this.nombreSucursal);
            this.Controls.Add(this.idSucursal);
            this.Name = "RegistroSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox idSucursal;
        private TextBox nombreSucursal;
        private TextBox direccionSucursal;
        private TextBox telefonoSucursal;
        private Button button_Agregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public Label label;
        private Label label7;
        private RadioButton checkBox_Activo;
        private RadioButton radioButton1;
    }
}