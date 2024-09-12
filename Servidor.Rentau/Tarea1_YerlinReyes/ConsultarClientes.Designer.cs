namespace Tarea1_YerlinReyes
{
    partial class ConsultarClientes
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
            this.Registrocliente = new System.Windows.Forms.Button();
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrocliente
            // 
            this.Registrocliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Registrocliente.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Registrocliente.Location = new System.Drawing.Point(814, 474);
            this.Registrocliente.Name = "Registrocliente";
            this.Registrocliente.Size = new System.Drawing.Size(123, 56);
            this.Registrocliente.TabIndex = 0;
            this.Registrocliente.Text = "Consultar";
            this.Registrocliente.UseVisualStyleBackColor = false;
            this.Registrocliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clientes.Location = new System.Drawing.Point(30, 56);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.RowTemplate.Height = 31;
            this.dataGridView_Clientes.Size = new System.Drawing.Size(925, 392);
            this.dataGridView_Clientes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes registrados:";
            // 
            // ConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(994, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Clientes);
            this.Controls.Add(this.Registrocliente);
            this.Name = "ConsultarClientes";
            this.Text = "Consultar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Registrocliente;
        private DataGridView dataGridView_Clientes;
        private Label label1;
    }
}