using PomodoroTaskBar.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PomodoroTaskBar.Forms
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();

            cbTipoAlertaSonoro.ValueMember = cbTipoAlertaVisual.ValueMember = "Value";
            cbTipoAlertaSonoro.DisplayMember = cbTipoAlertaVisual.DisplayMember = "Name";

            cbTipoAlertaSonoro.DataSource = ComboHelper.CriarDataSource<TipoAlertaSonoro>().ToList();
            cbTipoAlertaVisual.DataSource = ComboHelper.CriarDataSource<TipoAlertaVisual>().ToList();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            Carregar();
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo redefinir as configurações para o padrão?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Resetar();
            Salvar();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }

        private void Carregar()
        {
            nTempoFoco.Value = (decimal)Configuracoes.Instancia.TempoFoco.Value.TotalMinutes;
            nPausaBreve.Value = (decimal)Configuracoes.Instancia.TempoIntervaloCurto.Value.TotalMinutes;
            nPausaLonga.Value = (decimal)Configuracoes.Instancia.TempoIntervaloLongo.Value.TotalMinutes;
            nQtdPmodoros.Value = Configuracoes.Instancia.PomodorosPorSessao;
            cCorRefFundo.Cor = Configuracoes.Instancia.CorReferenciaFundo;
            cPeriodoFoco.Cor = Configuracoes.Instancia.CorTextoFoco;
            cPausaLonga.Cor = Configuracoes.Instancia.CorTextoPausaLonga;
            cPausaBreve.Cor = Configuracoes.Instancia.CorTextoPausaBreve;
            ckProxEtapaAuto.Checked = Configuracoes.Instancia.AvancarEtapasAutomaticamente;
            ckReiniciarAuto.Checked = Configuracoes.Instancia.RecomecarCicloAutomaticamente;
            ckNotificacao.Checked = Configuracoes.Instancia.Notificacao;
            ckAlertaVisual.Checked = Configuracoes.Instancia.AlertaVisual;
            ckAlertaSonoro.Checked = Configuracoes.Instancia.AlertaSonoro;
            txtAlertaSonoroCustom.Text = Configuracoes.Instancia.AlertaSonoroCustom;
            cbTipoAlertaSonoro.SelectedValue = Configuracoes.Instancia.TipoAlertaSonoro.Value;
            cbTipoAlertaVisual.SelectedValue = Configuracoes.Instancia.TipoAlertaVisual.Value;
        }

        private void Salvar()
        {
            Configuracoes.Instancia.TempoFoco.Value = TimeSpan.FromMinutes((double)nTempoFoco.Value);
            Configuracoes.Instancia.TempoIntervaloCurto.Value = TimeSpan.FromMinutes((double)nPausaBreve.Value);
            Configuracoes.Instancia.TempoIntervaloLongo.Value = TimeSpan.FromMinutes((double)nPausaLonga.Value);
            Configuracoes.Instancia.PomodorosPorSessao.Value = (int)nQtdPmodoros.Value;
            Configuracoes.Instancia.CorReferenciaFundo.Value = cCorRefFundo.Cor;
            Configuracoes.Instancia.CorTextoFoco.Value = cPeriodoFoco.Cor;
            Configuracoes.Instancia.CorTextoPausaLonga.Value = cPausaLonga.Cor;
            Configuracoes.Instancia.CorTextoPausaBreve.Value = cPausaBreve.Cor;
            Configuracoes.Instancia.AvancarEtapasAutomaticamente.Value = ckProxEtapaAuto.Checked;
            Configuracoes.Instancia.RecomecarCicloAutomaticamente.Value = ckReiniciarAuto.Checked;
            Configuracoes.Instancia.Notificacao.Value = ckNotificacao.Checked;
            Configuracoes.Instancia.AlertaVisual.Value = ckAlertaVisual.Checked;
            Configuracoes.Instancia.AlertaSonoro.Value = ckAlertaSonoro.Checked;
            Configuracoes.Instancia.AlertaSonoroCustom.Value = txtAlertaSonoroCustom.Text;
            Configuracoes.Instancia.TipoAlertaSonoro.Value = (TipoAlertaSonoro)cbTipoAlertaSonoro.SelectedValue;
            Configuracoes.Instancia.TipoAlertaVisual.Value = (TipoAlertaVisual)cbTipoAlertaVisual.SelectedValue;

            Configuracoes.TriggarEventoConfiguracaoAlterada();
        }

        private void Resetar()
        {
            Configuracoes.Instancia.Resetar();
            Carregar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = txtAlertaSonoroCustom.Text;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            txtAlertaSonoroCustom.Text = openFileDialog1.FileName;
        }

        private void ckAlertaSonoro_CheckedChanged(object sender, EventArgs e)
        {
            cbTipoAlertaSonoro.Enabled = ckAlertaSonoro.Checked;
            btnSelFile.Enabled = ckAlertaSonoro.Checked && (TipoAlertaSonoro)cbTipoAlertaSonoro.SelectedValue == TipoAlertaSonoro.Custom;
        }

        private void cbTipoAlertaSonoro_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelFile.Enabled = ckAlertaSonoro.Checked && (TipoAlertaSonoro)cbTipoAlertaSonoro.SelectedValue == TipoAlertaSonoro.Custom;
        }

        private void ckAlertaVisual_CheckedChanged(object sender, EventArgs e)
        {
            cbTipoAlertaVisual.Enabled = ckAlertaVisual.Checked;
        }
    }
}
