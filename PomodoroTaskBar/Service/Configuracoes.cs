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
            TempoIntervaloCurto = new ConfigValue<TimeSpan>(nameof(TempoIntervaloCurto));
            TempoIntervaloLongo = new ConfigValue<TimeSpan>(nameof(TempoIntervaloLongo));
            TempoFoco = new ConfigValue<TimeSpan>(nameof(TempoFoco));
            PomodorosPorSessao = new ConfigValue<int>(nameof(PomodorosPorSessao));

            if (!_inicializado)
            {
                Resetar();
                _inicializado.Value = true;
            }
        }

        private ConfigValue<bool> _inicializado;

        public ConfigValue<bool> AvancarEtapasAutomaticamente { get; private set; }
        public ConfigValue<TimeSpan> TempoIntervaloCurto { get; private set; }
        public ConfigValue<TimeSpan> TempoIntervaloLongo { get; private set; }
        public ConfigValue<TimeSpan> TempoFoco { get; private set; }
        public ConfigValue<int> PomodorosPorSessao { get; private set; }

        public void Resetar()
        {
            AvancarEtapasAutomaticamente.Value = false ;
            TempoFoco.Value = TimeSpan.FromMinutes(25);
            TempoIntervaloCurto.Value = TimeSpan.FromMinutes(5);
            TempoIntervaloLongo.Value = TimeSpan.FromMinutes(15);
            PomodorosPorSessao.Value = 8;
        }
    }
}
