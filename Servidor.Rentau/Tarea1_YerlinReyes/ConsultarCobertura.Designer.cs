namespace Tarea1_YerlinReyes
{
    partial class ConsultarCobertura
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
            this.comboBox_TiposVehiculos = new System.Windows.Forms.ComboBox();
            this.dataGridView_Cobertura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cobertura)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_TiposVehiculos
            // 
            this.comboBox_TiposVehiculos.FormattingEnabled = true;
            this.comboBox_TiposVehiculos.Location = new System.Drawing.Point(22, 59);
            this.comboBox_TiposVehiculos.Name = "comboBox_TiposVehiculos";
            this.comboBox_TiposVehiculos.Size = new System.Drawing.Size(565, 29);
            this.comboBox_TiposVehiculos.TabIndex = 1;
            this.comboBox_TiposVehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBox_TiposVehiculos_SelectedIndexChanged);
            // 
            // dataGridView_Cobertura
            // 
            this.dataGridView_Cobertura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cobertura.Location = new System.Drawing.Point(22, 151);
            this.dataGridView_Cobertura.Name = "dataGridView_Cobertura";
            this.dataGridView_Cobertura.RowTemplate.Height = 31;
            this.dataGridView_Cobertura.Size = new System.Drawing.Size(937, 366);
            this.dataGridView_Cobertura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el Tipo de vehiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coberturas registradas:";
            // 
            // ConsultarCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(981, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Cobertura);
            this.Controls.Add(this.comboBox_TiposVehiculos);
            this.Name = "ConsultarCobertura";
            this.Text = "Consultar Cobertura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cobertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBox_TiposVehiculos;
        private DataGridView dataGridView_Cobertura;
        private Label label1;
        private Label label2;
    }
}