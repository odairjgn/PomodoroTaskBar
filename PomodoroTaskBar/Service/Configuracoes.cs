using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTaskBar.Service
{
    public class Configuracoes
    {
        private static Configuracoes _instancia;
        public static Configuracoes Instancia => _instancia ?? (_instancia = new Configuracoes());

        private Configuracoes()
        {
            _inicializado = new ConfigValue<bool>(nameof(_inicializado));
            AvancarEtapasAutomaticamente = new ConfigValue<bool>(nameof(AvancarEtapasAutomaticamente));
            RecomecarCicloAutomaticamente = new ConfigValue<bool>(nameof(RecomecarCicloAutomaticamente));
            TempoIntervaloCurto = new ConfigValue<TimeSpan>(nameof(TempoIntervaloCurto));
            TempoIntervaloLongo = new ConfigValue<TimeSpan>(nameof(TempoIntervaloLongo));
            TempoFoco = new ConfigValue<TimeSpan>(nameof(TempoFoco));
            PomodorosPorSessao = new ConfigValue<int>(nameof(PomodorosPorSessao));
            CorReferenciaFundo = new ConfigValue<Color>(nameof(CorReferenciaFundo));
            CorTextoFoco = new ConfigValue<Color>(nameof(CorTextoFoco));
            CorTextoPausaBreve = new ConfigValue<Color>(nameof(CorTextoPausaBreve));
            CorTextoPausaLonga = new ConfigValue<Color>(nameof(CorTextoPausaLonga));
            Notificacao = new ConfigValue<bool>(nameof(Notificacao));
            AlertaVisual = new ConfigValue<bool>(nameof(AlertaVisual));
            AlertaSonoro = new ConfigValue<bool>(nameof(AlertaSonoro));
            TipoAlertaVisual = new ConfigValue<TipoAlertaVisual>(nameof(TipoAlertaSonoro));
            TipoAlertaSonoro = new ConfigValue<TipoAlertaSonoro>(nameof(TipoAlertaSonoro));
            AlertaSonoroCustom = new ConfigValue<string>(nameof(AlertaSonoroCustom));

            if (!_inicializado)
            {
                Resetar();
                _inicializado.Value = true;
            }
        }

        private ConfigValue<bool> _inicializado;

        public ConfigValue<bool> AvancarEtapasAutomaticamente { get; private set; }
        public ConfigValue<bool> RecomecarCicloAutomaticamente { get; private set; }
        public ConfigValue<TimeSpan> TempoIntervaloCurto { get; private set; }
        public ConfigValue<TimeSpan> TempoIntervaloLongo { get; private set; }
        public ConfigValue<TimeSpan> TempoFoco { get; private set; }
        public ConfigValue<int> PomodorosPorSessao { get; private set; }
        public ConfigValue<Color> CorReferenciaFundo { get; private set; }
        public ConfigValue<Color> CorTextoFoco { get; private set; }
        public ConfigValue<Color> CorTextoPausaBreve { get; private set; }
        public ConfigValue<Color> CorTextoPausaLonga { get; private set; }
        public ConfigValue<bool> Notificacao { get; private set; }
        public ConfigValue<bool> AlertaVisual { get; private set; }
        public ConfigValue<bool> AlertaSonoro { get; private set; }
        public ConfigValue<TipoAlertaVisual> TipoAlertaVisual { get; private set; }
        public ConfigValue<TipoAlertaSonoro> TipoAlertaSonoro { get; private set; }
        public ConfigValue<string> AlertaSonoroCustom { get; private set; } 

        public void Resetar()
        {
            AvancarEtapasAutomaticamente.Value = false;
            RecomecarCicloAutomaticamente.Value = false;
            TempoFoco.Value = TimeSpan.FromMinutes(25);
            TempoIntervaloCurto.Value = TimeSpan.FromMinutes(5);
            TempoIntervaloLongo.Value = TimeSpan.FromMinutes(15);
            PomodorosPorSessao.Value = 8;
            CorReferenciaFundo.Value = Color.Black;
            CorTextoFoco.Value = Color.White;
            CorTextoPausaBreve.Value = Color.Gold;
            CorTextoPausaLonga.Value = Color.Gold;
            Notificacao.Value = true;
            AlertaVisual.Value = false;
            AlertaSonoro.Value = true;
            TipoAlertaVisual.Value = Service.TipoAlertaVisual.Toast;
            TipoAlertaSonoro.Value = Service.TipoAlertaSonoro.Bip;
            AlertaSonoroCustom.Value = null;
        }
    }
}
