using PomodoroTaskBar.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTaskBar.Forms
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            Carregar();
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            Configuracoes.Instancia.Resetar();
            Carregar();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Carregar()
        {
            throw new NotImplementedException();
        }

        private void Salvar()
        {

        }

    }
}
