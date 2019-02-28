namespace Tests_T6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRotaMarca = new System.Windows.Forms.Button();
            this.multimediaUC1 = new NewComponents.MultimediaUC();
            this.labelTextBox1 = new NewComponents.LabelTextBox();
            this.multimediaPlayer1 = new NewComponents.MultimediaPlayer();
            this.etiquetaAviso1 = new NewComponents.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // btnRotaMarca
            // 
            this.btnRotaMarca.Location = new System.Drawing.Point(12, 98);
            this.btnRotaMarca.Name = "btnRotaMarca";
            this.btnRotaMarca.Size = new System.Drawing.Size(75, 23);
            this.btnRotaMarca.TabIndex = 5;
            this.btnRotaMarca.Text = "Rota marca";
            this.btnRotaMarca.UseVisualStyleBackColor = true;
            this.btnRotaMarca.Click += new System.EventHandler(this.btnRotaMarca_Click);
            // 
            // multimediaUC1
            // 
            this.multimediaUC1.Location = new System.Drawing.Point(321, 54);
            this.multimediaUC1.Name = "multimediaUC1";
            this.multimediaUC1.Size = new System.Drawing.Size(105, 115);
            this.multimediaUC1.TabIndex = 8;
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.AutoSize = true;
            this.labelTextBox1.Location = new System.Drawing.Point(304, 136);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Position = NewComponents.ePosition.LEFT;
            this.labelTextBox1.Separation = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(3468, 20);
            this.labelTextBox1.TabIndex = 7;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            // 
            // multimediaPlayer1
            // 
            this.multimediaPlayer1.Location = new System.Drawing.Point(48, 118);
            this.multimediaPlayer1.Name = "multimediaPlayer1";
            this.multimediaPlayer1.Size = new System.Drawing.Size(96, 92);
            this.multimediaPlayer1.TabIndex = 6;
            this.multimediaPlayer1.Text = "multimediaPlayer1";
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorFinal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.etiquetaAviso1.ColorInicial = System.Drawing.Color.Blue;
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.Gradiente = true;
            this.etiquetaAviso1.ImagenMarca = global::Tests_T6.Properties.Resources.unavaiableImage;
            this.etiquetaAviso1.Location = new System.Drawing.Point(12, 12);
            this.etiquetaAviso1.Marca = NewComponents.eMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(821, 80);
            this.etiquetaAviso1.TabIndex = 4;
            this.etiquetaAviso1.Text = "Etiqueta aviso de prueba";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 222);
            this.Controls.Add(this.multimediaUC1);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.multimediaPlayer1);
            this.Controls.Add(this.btnRotaMarca);
            this.Controls.Add(this.etiquetaAviso1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Testing new components!";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRotaMarca;
        private NewComponents.EtiquetaAviso etiquetaAviso1;
        private NewComponents.MultimediaPlayer multimediaPlayer1;
        private NewComponents.LabelTextBox labelTextBox1;
        private NewComponents.MultimediaUC multimediaUC1;
    }
}

