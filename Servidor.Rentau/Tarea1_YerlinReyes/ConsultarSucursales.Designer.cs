namespace Tarea1_YerlinReyes
{
    partial class ConsultarSucursales
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
            this.components = new System.ComponentModel.Container();
            this.consultarBtn = new System.Windows.Forms.Button();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_Sucursales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // consultarBtn
            // 
            this.consultarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.consultarBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultarBtn.Location = new System.Drawing.Point(803, 481);
            this.consultarBtn.Name = "consultarBtn";
            this.consultarBtn.Size = new System.Drawing.Size(129, 60);
            this.consultarBtn.TabIndex = 0;
            this.consultarBtn.Text = "Consultar";
            this.consultarBtn.UseVisualStyleBackColor = false;
            this.consultarBtn.Click += new System.EventHandler(this.consultarBtn_Click);
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(Tarea1_YerlinReyes.Sucursal);
            // 
            // dataGridView_Sucursales
            // 
            this.dataGridView_Sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sucursales.Location = new System.Drawing.Point(34, 64);
            this.dataGridView_Sucursales.Name = "dataGridView_Sucursales";
            this.dataGridView_Sucursales.RowTemplate.Height = 31;
            this.dataGridView_Sucursales.Size = new System.Drawing.Size(898, 411);
            this.dataGridView_Sucursales.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sucursales registradas:";
            // 
            // ConsultarSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(967, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Sucursales);
            this.Controls.Add(this.consultarBtn);
            this.Name = "ConsultarSucursales";
            this.Text = "Consultar Registros de Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button consultarBtn;
        private BindingSource sucursalBindingSource;
        private DataGridView dataGridView_Sucursales;
        private Label label1;
    }
}