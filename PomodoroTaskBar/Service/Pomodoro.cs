using PomodoroTaskBar.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTaskBar.Service
{
    public class Pomodoro : Timer
    {
        public event EventHandler FimDoCiclo;
        public event EventHandler<Etapa> FimEtapa;
        public event EventHandler<RefreshDataArgs> RefreshData;

        public Pomodoro()
        {
            Reset();            
        }

        public List<Etapa> Etapas { get; private set; }
        public int CurrentIndex { get; private set; }
        public Etapa EtapaAtual => CurrentIndex < Etapas.Count ? Etapas[CurrentIndex] : null;

        public bool Rodando => EtapaAtual?.Rodando ?? false;

        public bool Finalizado => EtapaAtual == null;

        protected override void OnTick(EventArgs e)
        {
            base.OnTick(e);

            var etapa = EtapaAtual;

            var data = new RefreshDataArgs
            {
                Etapa = etapa,
                Index = CurrentIndex,
                Count = Etapas?.Count() ?? 0
            };

            RefreshData?.Invoke(this, data);

            if (etapa != null && etapa.Terminado && etapa.Rodando)
            {
                CurrentIndex++;
                etapa.Concluida = true;
                FimEtapa?.Invoke(this, etapa);

                if (EtapaAtual == null)
                    FimDoCiclo?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Reset()
        {
            CurrentIndex = 0;
            Etapas = new List<Etapa>();
            for(var i = 1; i <= Configuracoes.Instancia.PomodorosPorSessao; i++)
            {
                var pausalonga = i % 4 == 0;
                Etapas.Add(new Etapa(TipoEtapa.Foco, Configuracoes.Instancia.TempoFoco));
                Etapas.Add(pausalonga ? 
                    new Etapa(TipoEtapa.DescancoLongo, Configuracoes.Instancia.TempoIntervaloLongo) :
                    new Etapa(TipoEtapa.DescancoBreve, Configuracoes.Instancia.TempoIntervaloCurto)
                    );
            }
        }

        public void Iniciar()
        {
            EtapaAtual?.Iniciar();
        }

        public void Parar()
        {
            EtapaAtual?.Parar();
        }
    }
}
