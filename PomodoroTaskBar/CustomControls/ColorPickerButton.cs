using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTaskBar.CustomControls
{
    public partial class ColorPickerButton : UserControl
    {
        public ColorPickerButton()
        {
            InitializeComponent();
        }

        public Color Cor
        {
            get => button1.BackColor;
            set
            {
                button1.BackColor = value;
                AtualizarVisual();
            }
        }

        private void AtualizarVisual()
        {
            button1.Text = $"#{Cor.R:X2}{Cor.G:X2}{Cor.B:X2}";
            var invertido = Color.FromArgb(byte.MaxValue - Cor.R, byte.MaxValue - Cor.G, byte.MaxValue - Cor.B);
            button1.ForeColor = invertido;
            button1.FlatAppearance.BorderColor = invertido;
        }

        protected override void OnClick(EventArgs e)
        {
            var colorp = new ColorDialog() { Color = Cor, FullOpen = true, SolidColorOnly = true };

            if(colorp.ShowDialog() == DialogResult.OK)
            {
                Cor = colorp.Color;
            }

            colorp.Dispose();

            base.OnClick(e);
        }
    }
}
