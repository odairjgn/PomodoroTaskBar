using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTaskBar.ObjetosDeValor
{
    public struct RefreshDataArgs
    {
        public Etapa Etapa { get; internal set; }
        public int Index { get; internal set; }
        public int Count { get; internal set; }
    }
}
