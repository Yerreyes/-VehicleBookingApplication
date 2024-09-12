namespace Tarea1_YerlinReyes
{
    partial class ConsultarAsociacion
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
            this.comboBox_Sucursales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Asociaciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Asociaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Sucursales
            // 
            this.comboBox_Sucursales.FormattingEnabled = true;
            this.comboBox_Sucursales.Location = new System.Drawing.Point(21, 59);
            this.comboBox_Sucursales.Name = "comboBox_Sucursales";
            this.comboBox_Sucursales.Size = new System.Drawing.Size(745, 29);
            this.comboBox_Sucursales.TabIndex = 2;
            this.comboBox_Sucursales.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la sucursal:";
            // 
            // dataGridView_Asociaciones
            // 
            this.dataGridView_Asociaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Asociaciones.Location = new System.Drawing.Point(21, 161);
            this.dataGridView_Asociaciones.Name = "dataGridView_Asociaciones";
            this.dataGridView_Asociaciones.RowTemplate.Height = 31;
            this.dataGridView_Asociaciones.Size = new System.Drawing.Size(1033, 327);
            this.dataGridView_Asociaciones.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "La asociaciones realizadas son las siguientes:";
            // 
            // ConsultarAsociacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1084, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Asociaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Sucursales);
            this.Name = "ConsultarAsociacion";
            this.Text = "Consultar Asociaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Asociaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBox_Sucursales;
        private Label label1;
        private DataGridView dataGridView_Asociaciones;
        private Label label2;
    }
}