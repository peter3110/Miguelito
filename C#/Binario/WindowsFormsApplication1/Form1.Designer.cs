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
            this.txtBinarioaDecimal = new System.Windows.Forms.TextBox();
            this.btnBinarioaDecimal = new System.Windows.Forms.Button();
            this.btnDecimalaBinario = new System.Windows.Forms.Button();
            this.txtDecimalaBinario = new System.Windows.Forms.TextBox();
            this.btnBorrar0 = new System.Windows.Forms.Button();
            this.btnBorrar1 = new System.Windows.Forms.Button();
            this.lblBinarioADecimal = new System.Windows.Forms.Label();
            this.lblDecimalABinario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBinarioaDecimal
            // 
            this.txtBinarioaDecimal.Location = new System.Drawing.Point(35, 24);
            this.txtBinarioaDecimal.Name = "txtBinarioaDecimal";
            this.txtBinarioaDecimal.Size = new System.Drawing.Size(216, 20);
            this.txtBinarioaDecimal.TabIndex = 0;
            this.txtBinarioaDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinarioaDecimal_KeyPress);
            // 
            // btnBinarioaDecimal
            // 
            this.btnBinarioaDecimal.Location = new System.Drawing.Point(35, 50);
            this.btnBinarioaDecimal.Name = "btnBinarioaDecimal";
            this.btnBinarioaDecimal.Size = new System.Drawing.Size(97, 42);
            this.btnBinarioaDecimal.TabIndex = 1;
            this.btnBinarioaDecimal.Text = "DECIMAL!";
            this.btnBinarioaDecimal.UseVisualStyleBackColor = true;
            this.btnBinarioaDecimal.Click += new System.EventHandler(this.btnBinarioaDecimal_Click_1);
            // 
            // btnDecimalaBinario
            // 
            this.btnDecimalaBinario.Location = new System.Drawing.Point(35, 169);
            this.btnDecimalaBinario.Name = "btnDecimalaBinario";
            this.btnDecimalaBinario.Size = new System.Drawing.Size(97, 42);
            this.btnDecimalaBinario.TabIndex = 2;
            this.btnDecimalaBinario.Text = "BINARIO!";
            this.btnDecimalaBinario.UseVisualStyleBackColor = true;
            this.btnDecimalaBinario.Click += new System.EventHandler(this.btnDecimalaBinario_Click);
            // 
            // txtDecimalaBinario
            // 
            this.txtDecimalaBinario.Location = new System.Drawing.Point(35, 143);
            this.txtDecimalaBinario.Name = "txtDecimalaBinario";
            this.txtDecimalaBinario.Size = new System.Drawing.Size(216, 20);
            this.txtDecimalaBinario.TabIndex = 3;
            this.txtDecimalaBinario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimalaBinario_KeyPress);
            // 
            // btnBorrar0
            // 
            this.btnBorrar0.Location = new System.Drawing.Point(154, 50);
            this.btnBorrar0.Name = "btnBorrar0";
            this.btnBorrar0.Size = new System.Drawing.Size(97, 42);
            this.btnBorrar0.TabIndex = 4;
            this.btnBorrar0.Text = "BORRAR";
            this.btnBorrar0.UseVisualStyleBackColor = true;
            this.btnBorrar0.Click += new System.EventHandler(this.btnBorrar0_Click);
            // 
            // btnBorrar1
            // 
            this.btnBorrar1.Location = new System.Drawing.Point(154, 169);
            this.btnBorrar1.Name = "btnBorrar1";
            this.btnBorrar1.Size = new System.Drawing.Size(97, 42);
            this.btnBorrar1.TabIndex = 5;
            this.btnBorrar1.Text = "BORRAR";
            this.btnBorrar1.UseVisualStyleBackColor = true;
            this.btnBorrar1.Click += new System.EventHandler(this.btnBorrar1_Click);
            // 
            // lblBinarioADecimal
            // 
            this.lblBinarioADecimal.AutoSize = true;
            this.lblBinarioADecimal.Location = new System.Drawing.Point(32, 105);
            this.lblBinarioADecimal.Name = "lblBinarioADecimal";
            this.lblBinarioADecimal.Size = new System.Drawing.Size(0, 13);
            this.lblBinarioADecimal.TabIndex = 6;
            // 
            // lblDecimalABinario
            // 
            this.lblDecimalABinario.AutoSize = true;
            this.lblDecimalABinario.Location = new System.Drawing.Point(32, 228);
            this.lblDecimalABinario.Name = "lblDecimalABinario";
            this.lblDecimalABinario.Size = new System.Drawing.Size(0, 13);
            this.lblDecimalABinario.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblDecimalABinario);
            this.Controls.Add(this.lblBinarioADecimal);
            this.Controls.Add(this.btnBorrar1);
            this.Controls.Add(this.btnBorrar0);
            this.Controls.Add(this.txtDecimalaBinario);
            this.Controls.Add(this.btnDecimalaBinario);
            this.Controls.Add(this.btnBinarioaDecimal);
            this.Controls.Add(this.txtBinarioaDecimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinarioaDecimal;
        private System.Windows.Forms.Button btnBinarioaDecimal;
        private System.Windows.Forms.Button btnDecimalaBinario;
        private System.Windows.Forms.TextBox txtDecimalaBinario;
        private System.Windows.Forms.Button btnBorrar0;
        private System.Windows.Forms.Button btnBorrar1;
        private System.Windows.Forms.Label lblBinarioADecimal;
        private System.Windows.Forms.Label lblDecimalABinario;

    }
}

