using System;
using System.Diagnostics;

namespace PomodoroTaskBar.ObjetosDeValor
{
    public class Etapa
    {
        public Etapa(TipoEtapa tipo, TimeSpan duracao)
        {
            Tipo = tipo;
            Duracao = duracao;
            _timer = new Stopwatch();
        }

        public TipoEtapa Tipo { get; private set; }
        public TimeSpan Duracao { get; private set; }
        public TimeSpan Restante => Duracao - _timer.Elapsed;
        public bool Rodando => _timer.IsRunning;
        public bool Terminado => Restante <= TimeSpan.Zero;

        private readonly Stopwatch _timer;

        public void Iniciar()
        {
            _timer.Start();
        }

        public void Parar()
        {
            _timer.Stop();
        }

        public void Reset()
        {
            _timer.Reset();
        }

        public void Reiniciar()
        {
            _timer.Restart();
        }
    }
}
