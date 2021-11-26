﻿using PomodoroTaskBar.Service;
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
            
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Carregar()
        {
            
        }

        private void Salvar()
        {
            Configuracoes.TriggarEventoConfiguracaoAlterada();
        }

        private void Resetar()
        {
            Configuracoes.Instancia.Resetar();
            Carregar();
        }

    }
}
