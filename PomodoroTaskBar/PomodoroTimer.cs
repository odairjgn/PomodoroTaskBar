using CSDeskBand;
using CSDeskBand.Win;
using PomodoroTaskBar.ObjetosDeValor;
using PomodoroTaskBar.Service;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PomodoroTaskBar
{
    [ComVisible(true)]

    [Guid("8E4CFFD1-02CB-43F9-960A-9108444047B7")]
    [CSDeskBandRegistration(Name = "Pomodoro Task Bar Timer")]
    public class PomodoroTimer : CSDeskBandWin
    {
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.ContextMenuStrip menuContexto;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem pausarContinuarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avançarEtapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redefinirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private Service.Pomodoro pomodoro;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private RefreshDataArgs _current;
        private bool _mouse;

        public PomodoroTimer()
        {
            Options.MinHorizontalSize = new CSDeskBand.Size(100, 30);
            InitializeComponent();
            pomodoro.Reset();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTempo = new System.Windows.Forms.Label();
            this.menuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pausarContinuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avançarEtapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.redefinirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomodoro = new PomodoroTaskBar.Service.Pomodoro();
            this.menuContexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTempo
            // 
            this.lbTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTempo.BackColor = System.Drawing.Color.Transparent;
            this.lbTempo.ContextMenuStrip = this.menuContexto;
            this.lbTempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempo.ForeColor = System.Drawing.Color.White;
            this.lbTempo.Location = new System.Drawing.Point(3, 1);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(94, 28);
            this.lbTempo.TabIndex = 1;
            this.lbTempo.Text = "00:00";
            this.lbTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTempo.Click += new System.EventHandler(this.lbTempo_Click);
            this.lbTempo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTempo_MouseDown);
            this.lbTempo.MouseEnter += new System.EventHandler(this.lbTempo_MouseEnter);
            this.lbTempo.MouseLeave += new System.EventHandler(this.lbTempo_MouseLeave);
            this.lbTempo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTempo_MouseUp);
            // 
            // menuContexto
            // 
            this.menuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pausarContinuarToolStripMenuItem,
            this.avançarEtapaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.redefinirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.opçõesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sobreToolStripMenuItem});
            this.menuContexto.Name = "menuContexto";
            this.menuContexto.Size = new System.Drawing.Size(168, 132);
            // 
            // pausarContinuarToolStripMenuItem
            // 
            this.pausarContinuarToolStripMenuItem.Name = "pausarContinuarToolStripMenuItem";
            this.pausarContinuarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pausarContinuarToolStripMenuItem.Text = "Pausar/Continuar";
            // 
            // avançarEtapaToolStripMenuItem
            // 
            this.avançarEtapaToolStripMenuItem.Name = "avançarEtapaToolStripMenuItem";
            this.avançarEtapaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.avançarEtapaToolStripMenuItem.Text = "Avançar Etapa";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // redefinirToolStripMenuItem
            // 
            this.redefinirToolStripMenuItem.Name = "redefinirToolStripMenuItem";
            this.redefinirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.redefinirToolStripMenuItem.Text = "Redefinir";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 6);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // pomodoro
            // 
            this.pomodoro.Enabled = true;
            this.pomodoro.FimDoCiclo += new System.EventHandler(this.pomodoro_FimDoCiclo);
            this.pomodoro.FimEtapa += new System.EventHandler<PomodoroTaskBar.ObjetosDeValor.Etapa>(this.pomodoro_FimEtapa);
            this.pomodoro.RefreshData += new System.EventHandler<PomodoroTaskBar.ObjetosDeValor.RefreshDataArgs>(this.pomodoro_RefreshData);
            // 
            // PomodoroTimer
            // 
            this.Controls.Add(this.lbTempo);
            this.Name = "PomodoroTimer";
            this.Size = new System.Drawing.Size(100, 30);
            this.menuContexto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void pomodoro_FimDoCiclo(object sender, System.EventArgs e)
        {

        }

        private void pomodoro_FimEtapa(object sender, ObjetosDeValor.Etapa e)
        {
            if (Configuracoes.Instancia.AvancarEtapasAutomaticamente)
                pomodoro.Iniciar();
        }

        private void pomodoro_RefreshData(object sender, ObjetosDeValor.RefreshDataArgs e)
        {
            _current = e;

            string text;

            if (_mouse)
                text = _current.Etapa?.Rodando ?? false ? "Parar" : "Iniciar";
            else
                text = _current.Etapa == null ? "" : _current.Etapa.Restante.ToString("mm\\:ss");

            lbTempo.Text = text;
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_current.Etapa == null) return;

            var g = e.Graphics;
            var retangulo = this.Bounds;
            var newr = new RectangleF(retangulo.X, retangulo.Y, retangulo.Width * _current.Etapa.ProgressoInverso, retangulo.Height);
            g.FillRectangle(_current.Etapa.Tipo == TipoEtapa.Foco ? Brushes.Green : Brushes.CornflowerBlue, newr);

            var rectetaps = new Rectangle(retangulo.X + 1, retangulo.Height - 7, retangulo.Width - 2, 5);
            var f = rectetaps.Width / (float)_current.Count;
            float x = rectetaps.X;
            if (pomodoro.Etapas != null)
            {
                foreach (var et in pomodoro.Etapas)
                {
                    var re = new RectangleF(x, rectetaps.Y, f, rectetaps.Height);
                    x += f;

                    Brush pincel = null;

                    if (et.Concluida)
                    {
                        if (et.Tipo == TipoEtapa.Foco)
                            pincel = Brushes.GreenYellow;
                        else if (et.Tipo == TipoEtapa.DescancoBreve)
                            pincel = Brushes.AliceBlue;
                        else
                            pincel = Brushes.Gold;
                    }
                    else if (et.Rodando)
                        pincel = Brushes.Yellow;

                    if (pincel != null)
                    {
                        g.FillRectangle(pincel, re);
                    }

                    g.DrawRectangles(Pens.Gray, new[] { re });
                }
            }
        }

        private void lbTempo_Click(object sender, System.EventArgs e)
        {
            if (pomodoro.Rodando)
                pomodoro.Parar();
            else if (pomodoro.Finalizado)
            {
                pomodoro.Reset();
                pomodoro.Iniciar();
            }
            else
                pomodoro.Iniciar();
        }

        private void lbTempo_MouseEnter(object sender, System.EventArgs e)
        {
            _mouse = true;
        }

        private void lbTempo_MouseLeave(object sender, System.EventArgs e)
        {
            _mouse = false;
        }

        private void lbTempo_MouseDown(object sender, MouseEventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lbTempo_MouseUp(object sender, MouseEventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }
    }
}
