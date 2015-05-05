namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.btnHacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(45, 25);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(186, 20);
            this.txtBinario.TabIndex = 0;
            // 
            // btnHacer
            // 
            this.btnHacer.Location = new System.Drawing.Point(94, 134);
            this.btnHacer.Name = "btnHacer";
            this.btnHacer.Size = new System.Drawing.Size(116, 70);
            this.btnHacer.TabIndex = 1;
            this.btnHacer.Text = "Magia";
            this.btnHacer.UseVisualStyleBackColor = true;
            this.btnHacer.Click += new System.EventHandler(this.btnHacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnHacer);
            this.Controls.Add(this.txtBinario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Button btnHacer;

    }
}

