namespace Tarea1_YerlinReyes
{
    partial class ConsultarTipoVehiculo
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_TipoDeVehiculo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TipoDeVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(632, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_TipoDeVehiculo
            // 
            this.dataGridView_TipoDeVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TipoDeVehiculo.Location = new System.Drawing.Point(23, 53);
            this.dataGridView_TipoDeVehiculo.Name = "dataGridView_TipoDeVehiculo";
            this.dataGridView_TipoDeVehiculo.RowTemplate.Height = 31;
            this.dataGridView_TipoDeVehiculo.Size = new System.Drawing.Size(784, 411);
            this.dataGridView_TipoDeVehiculo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipos de Vehículos registrados:";
            // 
            // ConsultarTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(838, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_TipoDeVehiculo);
            this.Controls.Add(this.button1);
            this.Name = "ConsultarTipoVehiculo";
            this.Text = "Consultar Tipo de Vehículo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TipoDeVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView_TipoDeVehiculo;
        private Label label1;
    }
}