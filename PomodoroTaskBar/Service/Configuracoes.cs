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
            TempoPomodoro = new ConfigValue<int>(nameof(TempoPomodoro));
            TempoIntervaloCurto = new ConfigValue<int>(nameof(TempoIntervaloCurto));
            TempoIntervaloLongo = new ConfigValue<int>(nameof(TempoIntervaloLongo));
            PomodorosPorSessao = new ConfigValue<int>(nameof(PomodorosPorSessao));

            if (!_inicializado)
            {
                Resetar();
                _inicializado.Value = true;
            }
        }

        private ConfigValue<bool> _inicializado;

        public ConfigValue<bool> AvancarEtapasAutomaticamente { get; private set; }
        public ConfigValue<int> TempoPomodoro { get; private set; }
        public ConfigValue<int> TempoIntervaloCurto { get; private set; }
        public ConfigValue<int> TempoIntervaloLongo { get; private set; }
        public ConfigValue<int> PomodorosPorSessao { get; private set; }
        public ConfigValue<bool> TocarSons { get; private set; }

        public void Resetar()
        {
            AvancarEtapasAutomaticamente.Value =false ;
            TempoPomodoro.Value = 25;
            TempoIntervaloCurto.Value = 5;
            TempoIntervaloLongo.Value = 15;
        }
    }
}
