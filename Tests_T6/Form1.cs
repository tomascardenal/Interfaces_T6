using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests_T6
{
    public partial class Form1 : Form
    {
        private NewComponents.eMarca[] marcas = {NewComponents.eMarca.Circulo, NewComponents.eMarca.Cruz, NewComponents.eMarca.Imagen, NewComponents.eMarca.Nada };
        private int indiceMarca;

        public Form1()
        {
            InitializeComponent();
            etiquetaAviso1.AutoSize = true;
            for(int i = 0; i < marcas.Length; i++)
            {
                if(etiquetaAviso1.Marca == marcas[i])
                {
                    indiceMarca = i;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
            MessageBox.Show("Marca clickeada");
        }

        private void btnRotaMarca_Click(object sender, EventArgs e)
        {
            indiceMarca++;
            if (indiceMarca == marcas.Length)
            {
                indiceMarca = 0;
            }
            etiquetaAviso1.Marca = marcas[indiceMarca];
        }
    }
}
