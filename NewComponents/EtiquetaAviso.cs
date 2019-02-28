using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewComponents
{
    /// <summary>
    /// Enumera los posibles tipos de marca para la EtiquetaAviso
    /// </summary>
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }

    /// <summary>
    /// Etiqueta con un campo de texto y una pequeña marca asociada
    /// </summary>
    public partial class EtiquetaAviso : Control
    {
        /// <summary>
        /// La marca asociada al campo de texto
        /// </summary>
        private eMarca marca = eMarca.Nada;
        /// <summary>
        /// Indica si hay gradiente en esta EtiquetaAviso
        /// </summary>
        private bool gradiente;
        /// <summary>
        /// Color inicial del gradiente
        /// </summary>
        private Color colorInicial;
        /// <summary>
        /// Color final del gradiente
        /// </summary>
        private Color colorFinal;
        /// <summary>
        /// Imagen para la marca, si es necesaria
        /// </summary>
        private Image imagenMarca;
        /// <summary>
        /// Rectángulo para detectar clicks sobre la marca
        /// </summary>
        private Rectangle marcaRect;
        /// <summary>
        /// Propiedad de autoescalado
        /// </summary>
        public override bool AutoSize { set; get; } = true;

        /// <summary>
        /// Tipo de eMarca de la etiqueta de aviso
        /// </summary>
        [Category("Design")]
        [Description("Indica el tipo de marca de la etiqueta de aviso")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        /// <summary>
        /// Indicador de si hay o no gradiente
        /// </summary>
        [Category("Design")]
        [Description("Indica si se muestra o no un gradiente de color")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }

        /// <summary>
        /// Color inicial del gradiente
        /// </summary>
        [Category("Design")]
        [Description("Indica el color inicial del gradiente de color")]
        public Color ColorInicial
        {
            set
            {
                colorInicial = value;
                this.Refresh();
            }
            get
            {
                return colorInicial;
            }
        }

        /// <summary>
        /// Color final del gradiente
        /// </summary>
        [Category("Design")]
        [Description("Indica el color final del gradiente de color")]
        public Color ColorFinal
        {
            set
            {
                colorFinal = value;
                this.Refresh();
            }
            get
            {
                return colorFinal;
            }
        }

        [Category("Design")]
        [Description("Indica la imagen de la marca")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }

        /// <summary>
        /// Evento para click en la marca
        /// </summary>
        public event EventHandler ClickEnMarca;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestiona las acciones cuando se dibuja este componente
        /// </summary>
        /// <param name="pe">los argumentos del evento de pintado</param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = CreateGraphics();
            g.Clear(DefaultBackColor);

            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (Gradiente)
            {
                LinearGradientBrush gradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(this.ClientSize.Width, this.ClientSize.Height), ColorInicial, colorFinal);
                g.FillRectangle(gradientBrush, 0, 0, this.Width, this.Height);
                gradientBrush.Dispose();
            }
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 5;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    marcaRect = new Rectangle(grosor / 2, grosor / 2, this.Font.Height + grosor, this.Font.Height + grosor);
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height, this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    marcaRect = new Rectangle(grosor / 2, grosor / 2, this.Font.Height, this.Font.Height);
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (imagenMarca == null)
                    {
                        goto case eMarca.Nada;
                    }
                    g.DrawImage(imagenMarca, 0, 0, this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height;
                    offsetY = 0;
                    marcaRect = new Rectangle(0, 0, this.Font.Height, this.Font.Height);
                    break;
                case eMarca.Nada:
                    //Placeholder por si en un futuro queremos hacer algo con este caso
                    break;
            }
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            if (AutoSize)
            {
                Size updateSize = g.MeasureString(this.Text, this.Font).ToSize();
                switch (marca)
                {
                    case eMarca.Circulo:
                    case eMarca.Cruz:
                        this.Size = new Size(updateSize.Width + offsetX + grosor, updateSize.Height + offsetY * 2);
                        break;
                    case eMarca.Imagen:
                        this.Size = new Size(updateSize.Width + this.FontHeight, updateSize.Height);
                        break;
                    case eMarca.Nada:
                        this.Size = new Size(updateSize.Width, updateSize.Height);
                        break;
                }
            }
            g.Dispose();
            b.Dispose();
        }

        /// <summary>
        /// Gestiona las acciones cuando se cambia el texto
        /// </summary>
        /// <param name="e">Los argumentos del evento</param>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        /// <summary>
        /// Gestiona los eventos cuando se realiza un click de ratón
        /// </summary>
        /// <param name="e">Los argumentos del evento</param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (marcaRect.Contains(e.Location) && marca != eMarca.Nada)
            {
                /*if (ClickEnMarca != null)
                {
                    ClickEnMarca(this, e);
                }*/
                ClickEnMarca?.Invoke(this, e);
            }
        }
    }
}
