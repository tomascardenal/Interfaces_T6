﻿namespace T6_Ejer2_Prueba
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
            this.multimediaUC1 = new NewComponents.MultimediaUC();
            this.SuspendLayout();
            // 
            // multimediaUC1
            // 
            this.multimediaUC1.AutoSize = true;
            this.multimediaUC1.Location = new System.Drawing.Point(134, 24);
            this.multimediaUC1.Minutes = ((uint)(0u));
            this.multimediaUC1.Name = "multimediaUC1";
            this.multimediaUC1.Playing = false;
            this.multimediaUC1.Seconds = ((uint)(0u));
            this.multimediaUC1.Size = new System.Drawing.Size(183, 203);
            this.multimediaUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 510);
            this.Controls.Add(this.multimediaUC1);
            this.Name = "Form1";
            this.Text = "Test Multimedia Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NewComponents.MultimediaUC multimediaUC1;
    }
}

