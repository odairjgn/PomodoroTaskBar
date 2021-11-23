using CSDeskBand;
using CSDeskBand.Win;
using System.Runtime.InteropServices;

namespace PomodoroTaskBar
{
    [ComVisible(true)]

    [Guid("8E4CFFD1-02CB-43F9-960A-9108444047B7")]
    [CSDeskBandRegistration(Name = "Pomodoro Task Bar Timer")]
    public class PomodoroTimer : CSDeskBandWin
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip menuContexto;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem pausarContinuarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avançarEtapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redefinirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.Button button1;

        public PomodoroTimer()
        {
            Options.MinHorizontalSize = new Size(100, 30);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuContexto = new System.Windows.Forms.ContextMenuStrip();
            this.pausarContinuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avançarEtapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.redefinirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ContextMenuStrip = this.menuContexto;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuContexto
            // 
            this.menuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pausarContinuarToolStripMenuItem,
            this.avançarEtapaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.redefinirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.opçõesToolStripMenuItem});
            this.menuContexto.Name = "menuContexto";
            this.menuContexto.Size = new System.Drawing.Size(168, 104);
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
            // PomodoroTimer
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "PomodoroTimer";
            this.Size = new System.Drawing.Size(100, 30);
            this.menuContexto.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
