namespace Tarea1_YerlinReyes
{
    partial class RegistroVehiculoSucursal
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_mostrarVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridView_VehiculosAsociados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mostrarVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VehiculosAsociados)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(846, 31);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la sucursal de interés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione los vehículos que desea asociar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(483, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Asociación";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_mostrarVehiculos
            // 
            this.dataGridView_mostrarVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mostrarVehiculos.Location = new System.Drawing.Point(81, 214);
            this.dataGridView_mostrarVehiculos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_mostrarVehiculos.Name = "dataGridView_mostrarVehiculos";
            this.dataGridView_mostrarVehiculos.ReadOnly = true;
            this.dataGridView_mostrarVehiculos.RowTemplate.Height = 31;
            this.dataGridView_mostrarVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_mostrarVehiculos.Size = new System.Drawing.Size(1003, 192);
            this.dataGridView_mostrarVehiculos.TabIndex = 5;
            // 
            // dataGridView_VehiculosAsociados
            // 
            this.dataGridView_VehiculosAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_VehiculosAsociados.Location = new System.Drawing.Point(81, 503);
            this.dataGridView_VehiculosAsociados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_VehiculosAsociados.MultiSelect = false;
            this.dataGridView_VehiculosAsociados.Name = "dataGridView_VehiculosAsociados";
            this.dataGridView_VehiculosAsociados.ReadOnly = true;
            this.dataGridView_VehiculosAsociados.RowTemplate.Height = 31;
            this.dataGridView_VehiculosAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_VehiculosAsociados.Size = new System.Drawing.Size(1003, 192);
            this.dataGridView_VehiculosAsociados.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vehículos Asociados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(439, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Por asociación puede seleccionar varios vehículos o solo uno.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(976, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 38);
            this.label7.TabIndex = 11;
            this.label7.Text = "La fecha y el Id de Asiganción\r\nse generan automaticamente.";
            // 
            // RegistroVehiculoSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 702);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_VehiculosAsociados);
            this.Controls.Add(this.dataGridView_mostrarVehiculos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistroVehiculoSucursal";
            this.Text = "RegistarVehiculoSucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mostrarVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VehiculosAsociados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView_mostrarVehiculos;
        private DataGridView dataGridView_VehiculosAsociados;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
    }
}