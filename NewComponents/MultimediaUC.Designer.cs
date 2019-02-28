namespace NewComponents
{
    partial class MultimediaUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultimediaUC));
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.BackgroundImage")));
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayPause.Location = new System.Drawing.Point(19, 14);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(93, 93);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // MultimediaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlayPause);
            this.Name = "MultimediaUC";
            this.Size = new System.Drawing.Size(130, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayPause;
    }
}
