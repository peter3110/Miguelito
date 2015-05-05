namespace WindowsFormsApplication3
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
            this.rbtTriangulo = new System.Windows.Forms.RadioButton();
            this.rbtCirculo = new System.Windows.Forms.RadioButton();
            this.rbtRectangulo = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.txtBaseRectandulo = new System.Windows.Forms.TextBox();
            this.txtAlturaRectangulo = new System.Windows.Forms.TextBox();
            this.lblBaseRectangulo = new System.Windows.Forms.Label();
            this.lblBaseTriangulo = new System.Windows.Forms.Label();
            this.lblAlturaRectangulo = new System.Windows.Forms.Label();
            this.lblAlturaTriangulo = new System.Windows.Forms.Label();
            this.txtRadioCirculo = new System.Windows.Forms.TextBox();
            this.txtDiametroCirculo = new System.Windows.Forms.TextBox();
            this.lblRadioCirculo = new System.Windows.Forms.Label();
            this.lblDiametroCirculo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPerimetroTrResultado = new System.Windows.Forms.Label();
            this.lblPerimetroRecResultado = new System.Windows.Forms.Label();
            this.lblPerimetroCirResultado = new System.Windows.Forms.Label();
            this.lblSuperficieTrResultado = new System.Windows.Forms.Label();
            this.lblSuperficieRecResultado = new System.Windows.Forms.Label();
            this.lblSuperficieCirResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtTriangulo
            // 
            this.rbtTriangulo.AutoSize = true;
            this.rbtTriangulo.Location = new System.Drawing.Point(28, 31);
            this.rbtTriangulo.Name = "rbtTriangulo";
            this.rbtTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbtTriangulo.TabIndex = 0;
            this.rbtTriangulo.TabStop = true;
            this.rbtTriangulo.Text = "Triángulo";
            this.rbtTriangulo.UseVisualStyleBackColor = true;
            this.rbtTriangulo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtCirculo
            // 
            this.rbtCirculo.AutoSize = true;
            this.rbtCirculo.Location = new System.Drawing.Point(28, 288);
            this.rbtCirculo.Name = "rbtCirculo";
            this.rbtCirculo.Size = new System.Drawing.Size(57, 17);
            this.rbtCirculo.TabIndex = 1;
            this.rbtCirculo.TabStop = true;
            this.rbtCirculo.Text = "Circulo";
            this.rbtCirculo.UseVisualStyleBackColor = true;
            // 
            // rbtRectangulo
            // 
            this.rbtRectangulo.AutoSize = true;
            this.rbtRectangulo.Location = new System.Drawing.Point(28, 143);
            this.rbtRectangulo.Name = "rbtRectangulo";
            this.rbtRectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbtRectangulo.TabIndex = 2;
            this.rbtRectangulo.TabStop = true;
            this.rbtRectangulo.Text = "Rectangulo";
            this.rbtRectangulo.UseVisualStyleBackColor = true;
            this.rbtRectangulo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication3.Properties.Resources._1_2_circulo;
            this.pictureBox3.Location = new System.Drawing.Point(131, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication3.Properties.Resources.Cuantos_ejes_de_simetria_tiene_un_rectangulo1;
            this.pictureBox2.Location = new System.Drawing.Point(131, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources._180px_Regular_triangle_svg;
            this.pictureBox1.Location = new System.Drawing.Point(131, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Location = new System.Drawing.Point(315, 28);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(79, 20);
            this.txtBaseTriangulo.TabIndex = 6;
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(440, 28);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(79, 20);
            this.txtAlturaTriangulo.TabIndex = 7;
            // 
            // txtBaseRectandulo
            // 
            this.txtBaseRectandulo.Location = new System.Drawing.Point(315, 143);
            this.txtBaseRectandulo.Name = "txtBaseRectandulo";
            this.txtBaseRectandulo.Size = new System.Drawing.Size(79, 20);
            this.txtBaseRectandulo.TabIndex = 8;
            // 
            // txtAlturaRectangulo
            // 
            this.txtAlturaRectangulo.Location = new System.Drawing.Point(440, 143);
            this.txtAlturaRectangulo.Name = "txtAlturaRectangulo";
            this.txtAlturaRectangulo.Size = new System.Drawing.Size(79, 20);
            this.txtAlturaRectangulo.TabIndex = 9;
            // 
            // lblBaseRectangulo
            // 
            this.lblBaseRectangulo.AutoSize = true;
            this.lblBaseRectangulo.Location = new System.Drawing.Point(341, 127);
            this.lblBaseRectangulo.Name = "lblBaseRectangulo";
            this.lblBaseRectangulo.Size = new System.Drawing.Size(31, 13);
            this.lblBaseRectangulo.TabIndex = 10;
            this.lblBaseRectangulo.Text = "Base";
            // 
            // lblBaseTriangulo
            // 
            this.lblBaseTriangulo.AutoSize = true;
            this.lblBaseTriangulo.Location = new System.Drawing.Point(341, 9);
            this.lblBaseTriangulo.Name = "lblBaseTriangulo";
            this.lblBaseTriangulo.Size = new System.Drawing.Size(31, 13);
            this.lblBaseTriangulo.TabIndex = 11;
            this.lblBaseTriangulo.Text = "Base";
            // 
            // lblAlturaRectangulo
            // 
            this.lblAlturaRectangulo.AutoSize = true;
            this.lblAlturaRectangulo.Location = new System.Drawing.Point(463, 127);
            this.lblAlturaRectangulo.Name = "lblAlturaRectangulo";
            this.lblAlturaRectangulo.Size = new System.Drawing.Size(34, 13);
            this.lblAlturaRectangulo.TabIndex = 12;
            this.lblAlturaRectangulo.Text = "Altura";
            // 
            // lblAlturaTriangulo
            // 
            this.lblAlturaTriangulo.AutoSize = true;
            this.lblAlturaTriangulo.Location = new System.Drawing.Point(463, 9);
            this.lblAlturaTriangulo.Name = "lblAlturaTriangulo";
            this.lblAlturaTriangulo.Size = new System.Drawing.Size(34, 13);
            this.lblAlturaTriangulo.TabIndex = 13;
            this.lblAlturaTriangulo.Text = "Altura";
            // 
            // txtRadioCirculo
            // 
            this.txtRadioCirculo.Location = new System.Drawing.Point(315, 288);
            this.txtRadioCirculo.Name = "txtRadioCirculo";
            this.txtRadioCirculo.Size = new System.Drawing.Size(79, 20);
            this.txtRadioCirculo.TabIndex = 14;
            // 
            // txtDiametroCirculo
            // 
            this.txtDiametroCirculo.Location = new System.Drawing.Point(440, 288);
            this.txtDiametroCirculo.Name = "txtDiametroCirculo";
            this.txtDiametroCirculo.Size = new System.Drawing.Size(79, 20);
            this.txtDiametroCirculo.TabIndex = 15;
            // 
            // lblRadioCirculo
            // 
            this.lblRadioCirculo.AutoSize = true;
            this.lblRadioCirculo.Location = new System.Drawing.Point(337, 272);
            this.lblRadioCirculo.Name = "lblRadioCirculo";
            this.lblRadioCirculo.Size = new System.Drawing.Size(35, 13);
            this.lblRadioCirculo.TabIndex = 16;
            this.lblRadioCirculo.Text = "Radio";
            // 
            // lblDiametroCirculo
            // 
            this.lblDiametroCirculo.AutoSize = true;
            this.lblDiametroCirculo.Location = new System.Drawing.Point(457, 272);
            this.lblDiametroCirculo.Name = "lblDiametroCirculo";
            this.lblDiametroCirculo.Size = new System.Drawing.Size(49, 13);
            this.lblDiametroCirculo.TabIndex = 17;
            this.lblDiametroCirculo.Text = "Diámetro";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(390, 410);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 47);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPerimetroTrResultado
            // 
            this.lblPerimetroTrResultado.AutoSize = true;
            this.lblPerimetroTrResultado.Location = new System.Drawing.Point(312, 64);
            this.lblPerimetroTrResultado.Name = "lblPerimetroTrResultado";
            this.lblPerimetroTrResultado.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetroTrResultado.TabIndex = 19;
            this.lblPerimetroTrResultado.Click += new System.EventHandler(this.lblPerimetroTrResultado_Click);
            // 
            // lblPerimetroRecResultado
            // 
            this.lblPerimetroRecResultado.AutoSize = true;
            this.lblPerimetroRecResultado.Location = new System.Drawing.Point(312, 187);
            this.lblPerimetroRecResultado.Name = "lblPerimetroRecResultado";
            this.lblPerimetroRecResultado.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetroRecResultado.TabIndex = 20;
            // 
            // lblPerimetroCirResultado
            // 
            this.lblPerimetroCirResultado.AutoSize = true;
            this.lblPerimetroCirResultado.Location = new System.Drawing.Point(316, 338);
            this.lblPerimetroCirResultado.Name = "lblPerimetroCirResultado";
            this.lblPerimetroCirResultado.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetroCirResultado.TabIndex = 21;
            // 
            // lblSuperficieTrResultado
            // 
            this.lblSuperficieTrResultado.AutoSize = true;
            this.lblSuperficieTrResultado.Location = new System.Drawing.Point(312, 96);
            this.lblSuperficieTrResultado.Name = "lblSuperficieTrResultado";
            this.lblSuperficieTrResultado.Size = new System.Drawing.Size(0, 13);
            this.lblSuperficieTrResultado.TabIndex = 22;
            // 
            // lblSuperficieRecResultado
            // 
            this.lblSuperficieRecResultado.AutoSize = true;
            this.lblSuperficieRecResultado.Location = new System.Drawing.Point(312, 228);
            this.lblSuperficieRecResultado.Name = "lblSuperficieRecResultado";
            this.lblSuperficieRecResultado.Size = new System.Drawing.Size(0, 13);
            this.lblSuperficieRecResultado.TabIndex = 23;
            // 
            // lblSuperficieCirResultado
            // 
            this.lblSuperficieCirResultado.AutoSize = true;
            this.lblSuperficieCirResultado.Location = new System.Drawing.Point(316, 384);
            this.lblSuperficieCirResultado.Name = "lblSuperficieCirResultado";
            this.lblSuperficieCirResultado.Size = new System.Drawing.Size(0, 13);
            this.lblSuperficieCirResultado.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 469);
            this.Controls.Add(this.lblSuperficieCirResultado);
            this.Controls.Add(this.lblSuperficieRecResultado);
            this.Controls.Add(this.lblSuperficieTrResultado);
            this.Controls.Add(this.lblPerimetroCirResultado);
            this.Controls.Add(this.lblPerimetroRecResultado);
            this.Controls.Add(this.lblPerimetroTrResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDiametroCirculo);
            this.Controls.Add(this.lblRadioCirculo);
            this.Controls.Add(this.txtDiametroCirculo);
            this.Controls.Add(this.txtRadioCirculo);
            this.Controls.Add(this.lblAlturaTriangulo);
            this.Controls.Add(this.lblAlturaRectangulo);
            this.Controls.Add(this.lblBaseTriangulo);
            this.Controls.Add(this.lblBaseRectangulo);
            this.Controls.Add(this.txtAlturaRectangulo);
            this.Controls.Add(this.txtBaseRectandulo);
            this.Controls.Add(this.txtAlturaTriangulo);
            this.Controls.Add(this.txtBaseTriangulo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtRectangulo);
            this.Controls.Add(this.rbtCirculo);
            this.Controls.Add(this.rbtTriangulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtTriangulo;
        private System.Windows.Forms.RadioButton rbtCirculo;
        private System.Windows.Forms.RadioButton rbtRectangulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBaseTriangulo;
        private System.Windows.Forms.TextBox txtAlturaTriangulo;
        private System.Windows.Forms.TextBox txtBaseRectandulo;
        private System.Windows.Forms.TextBox txtAlturaRectangulo;
        private System.Windows.Forms.Label lblBaseRectangulo;
        private System.Windows.Forms.Label lblBaseTriangulo;
        private System.Windows.Forms.Label lblAlturaRectangulo;
        private System.Windows.Forms.Label lblAlturaTriangulo;
        private System.Windows.Forms.TextBox txtRadioCirculo;
        private System.Windows.Forms.TextBox txtDiametroCirculo;
        private System.Windows.Forms.Label lblRadioCirculo;
        private System.Windows.Forms.Label lblDiametroCirculo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPerimetroTrResultado;
        private System.Windows.Forms.Label lblPerimetroRecResultado;
        private System.Windows.Forms.Label lblPerimetroCirResultado;
        private System.Windows.Forms.Label lblSuperficieTrResultado;
        private System.Windows.Forms.Label lblSuperficieRecResultado;
        private System.Windows.Forms.Label lblSuperficieCirResultado;
    }
}

