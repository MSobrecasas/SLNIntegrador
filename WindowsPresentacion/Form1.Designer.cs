namespace WindowsPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwMedicos = new System.Windows.Forms.DataGridView();
            this.listBoxMedicos = new System.Windows.Forms.ListBox();
            this.lblCantidadMedicos = new System.Windows.Forms.Label();
            this.listBoxHabitaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMedicos
            // 
            this.dgwMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedicos.Location = new System.Drawing.Point(12, 29);
            this.dgwMedicos.Name = "dgwMedicos";
            this.dgwMedicos.Size = new System.Drawing.Size(754, 175);
            this.dgwMedicos.TabIndex = 0;
            // 
            // listBoxMedicos
            // 
            this.listBoxMedicos.FormattingEnabled = true;
            this.listBoxMedicos.Location = new System.Drawing.Point(12, 255);
            this.listBoxMedicos.Name = "listBoxMedicos";
            this.listBoxMedicos.Size = new System.Drawing.Size(168, 147);
            this.listBoxMedicos.TabIndex = 1;
            // 
            // lblCantidadMedicos
            // 
            this.lblCantidadMedicos.AutoSize = true;
            this.lblCantidadMedicos.Location = new System.Drawing.Point(222, 255);
            this.lblCantidadMedicos.Name = "lblCantidadMedicos";
            this.lblCantidadMedicos.Size = new System.Drawing.Size(35, 13);
            this.lblCantidadMedicos.TabIndex = 2;
            this.lblCantidadMedicos.Text = "label1";
            // 
            // listBoxHabitaciones
            // 
            this.listBoxHabitaciones.FormattingEnabled = true;
            this.listBoxHabitaciones.Location = new System.Drawing.Point(509, 255);
            this.listBoxHabitaciones.Name = "listBoxHabitaciones";
            this.listBoxHabitaciones.Size = new System.Drawing.Size(183, 147);
            this.listBoxHabitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxHabitaciones);
            this.Controls.Add(this.lblCantidadMedicos);
            this.Controls.Add(this.listBoxMedicos);
            this.Controls.Add(this.dgwMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMedicos;
        private System.Windows.Forms.ListBox listBoxMedicos;
        private System.Windows.Forms.Label lblCantidadMedicos;
        private System.Windows.Forms.ListBox listBoxHabitaciones;
    }
}

