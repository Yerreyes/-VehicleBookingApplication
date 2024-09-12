namespace Tarea1_YerlinReyes
{
    partial class RegistroTipoVehiculo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.DescripcionTipoVehiculo = new System.Windows.Forms.TextBox();
            this.idTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inactivoRB = new System.Windows.Forms.RadioButton();
            this.activoRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id del tipo de vehículo:";
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AgregarBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgregarBtn.Location = new System.Drawing.Point(642, 235);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(106, 60);
            this.AgregarBtn.TabIndex = 32;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // DescripcionTipoVehiculo
            // 
            this.DescripcionTipoVehiculo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionTipoVehiculo.Location = new System.Drawing.Point(289, 122);
            this.DescripcionTipoVehiculo.Multiline = true;
            this.DescripcionTipoVehiculo.Name = "DescripcionTipoVehiculo";
            this.DescripcionTipoVehiculo.Size = new System.Drawing.Size(499, 80);
            this.DescripcionTipoVehiculo.TabIndex = 29;
            // 
            // idTipoVehiculo
            // 
            this.idTipoVehiculo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTipoVehiculo.Location = new System.Drawing.Point(289, 46);
            this.idTipoVehiculo.Name = "idTipoVehiculo";
            this.idTipoVehiculo.Size = new System.Drawing.Size(154, 32);
            this.idTipoVehiculo.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Estado :";
            // 
            // inactivoRB
            // 
            this.inactivoRB.AutoSize = true;
            this.inactivoRB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inactivoRB.Location = new System.Drawing.Point(430, 233);
            this.inactivoRB.Name = "inactivoRB";
            this.inactivoRB.Size = new System.Drawing.Size(95, 27);
            this.inactivoRB.TabIndex = 36;
            this.inactivoRB.TabStop = true;
            this.inactivoRB.Text = "Inactivo";
            this.inactivoRB.UseVisualStyleBackColor = true;
            // 
            // activoRB
            // 
            this.activoRB.AutoSize = true;
            this.activoRB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activoRB.Location = new System.Drawing.Point(289, 233);
            this.activoRB.Name = "activoRB";
            this.activoRB.Size = new System.Drawing.Size(84, 27);
            this.activoRB.TabIndex = 35;
            this.activoRB.TabStop = true;
            this.activoRB.Text = "Activo";
            this.activoRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 39;
            // 
            // RegistroTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(822, 364);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inactivoRB);
            this.Controls.Add(this.activoRB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.DescripcionTipoVehiculo);
            this.Controls.Add(this.idTipoVehiculo);
            this.Name = "RegistroTipoVehiculo";
            this.Text = "Registro del Tipo Vehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Button AgregarBtn;
        private TextBox DescripcionTipoVehiculo;
        private TextBox idTipoVehiculo;
        private Label label4;
        private RadioButton inactivoRB;
        private RadioButton activoRB;
        private Label label3;
        private Label label5;
    }
}