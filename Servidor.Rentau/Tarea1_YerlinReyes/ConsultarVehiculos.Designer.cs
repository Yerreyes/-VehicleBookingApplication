namespace Tarea1_YerlinReyes
{
    partial class ConsultarVehiculos
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
            this.consultarBTN = new System.Windows.Forms.Button();
            this.dataGridView_Vehiculos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // consultarBTN
            // 
            this.consultarBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.consultarBTN.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultarBTN.Location = new System.Drawing.Point(790, 472);
            this.consultarBTN.Name = "consultarBTN";
            this.consultarBTN.Size = new System.Drawing.Size(126, 58);
            this.consultarBTN.TabIndex = 0;
            this.consultarBTN.Text = "Consultar";
            this.consultarBTN.UseVisualStyleBackColor = false;
            this.consultarBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Vehiculos
            // 
            this.dataGridView_Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vehiculos.Location = new System.Drawing.Point(12, 57);
            this.dataGridView_Vehiculos.Name = "dataGridView_Vehiculos";
            this.dataGridView_Vehiculos.RowTemplate.Height = 31;
            this.dataGridView_Vehiculos.Size = new System.Drawing.Size(916, 409);
            this.dataGridView_Vehiculos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehiculos registrados:";
            // 
            // ConsultarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(967, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Vehiculos);
            this.Controls.Add(this.consultarBTN);
            this.Name = "ConsultarVehiculos";
            this.Text = "Consultar Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button consultarBTN;
        private DataGridView dataGridView_Vehiculos;
        private Label label1;
    }
}