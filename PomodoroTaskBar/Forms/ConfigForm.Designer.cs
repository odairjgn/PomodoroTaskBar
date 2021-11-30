namespace PomodoroTaskBar.Forms
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nQtdPmodoros = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nPausaLonga = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nPausaBreve = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nTempoFoco = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckReiniciarAuto = new System.Windows.Forms.CheckBox();
            this.ckProxEtapaAuto = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cPausaLonga = new PomodoroTaskBar.CustomControls.ColorPickerButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cPausaBreve = new PomodoroTaskBar.CustomControls.ColorPickerButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cPeriodoFoco = new PomodoroTaskBar.CustomControls.ColorPickerButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cCorRefFundo = new PomodoroTaskBar.CustomControls.ColorPickerButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelFile = new System.Windows.Forms.Button();
            this.txtAlertaSonoroCustom = new System.Windows.Forms.TextBox();
            this.cbTipoAlertaSonoro = new System.Windows.Forms.ComboBox();
            this.cbTipoAlertaVisual = new System.Windows.Forms.ComboBox();
            this.ckAlertaSonoro = new System.Windows.Forms.CheckBox();
            this.ckAlertaVisual = new System.Windows.Forms.CheckBox();
            this.ckNotificacao = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnRedefinir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQtdPmodoros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPausaLonga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPausaBreve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTempoFoco)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nQtdPmodoros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nPausaLonga);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nPausaBreve);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nTempoFoco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempos";
            // 
            // nQtdPmodoros
            // 
            this.nQtdPmodoros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nQtdPmodoros.Location = new System.Drawing.Point(192, 96);
            this.nQtdPmodoros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nQtdPmodoros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQtdPmodoros.Name = "nQtdPmodoros";
            this.nQtdPmodoros.Size = new System.Drawing.Size(58, 20);
            this.nQtdPmodoros.TabIndex = 7;
            this.nQtdPmodoros.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade de pomodoros";
            // 
            // nPausaLonga
            // 
            this.nPausaLonga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nPausaLonga.Location = new System.Drawing.Point(192, 70);
            this.nPausaLonga.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nPausaLonga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPausaLonga.Name = "nPausaLonga";
            this.nPausaLonga.Size = new System.Drawing.Size(58, 20);
            this.nPausaLonga.TabIndex = 5;
            this.nPausaLonga.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pausa longa";
            // 
            // nPausaBreve
            // 
            this.nPausaBreve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nPausaBreve.Location = new System.Drawing.Point(192, 44);
            this.nPausaBreve.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nPausaBreve.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPausaBreve.Name = "nPausaBreve";
            this.nPausaBreve.Size = new System.Drawing.Size(58, 20);
            this.nPausaBreve.TabIndex = 3;
            this.nPausaBreve.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pausa breve";
            // 
            // nTempoFoco
            // 
            this.nTempoFoco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nTempoFoco.Location = new System.Drawing.Point(192, 18);
            this.nTempoFoco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nTempoFoco.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTempoFoco.Name = "nTempoFoco";
            this.nTempoFoco.Size = new System.Drawing.Size(58, 20);
            this.nTempoFoco.TabIndex = 1;
            this.nTempoFoco.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo de foco";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckReiniciarAuto);
            this.groupBox2.Controls.Add(this.ckProxEtapaAuto);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(275, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tempos";
            // 
            // ckReiniciarAuto
            // 
            this.ckReiniciarAuto.AutoSize = true;
            this.ckReiniciarAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckReiniciarAuto.Location = new System.Drawing.Point(10, 43);
            this.ckReiniciarAuto.Name = "ckReiniciarAuto";
            this.ckReiniciarAuto.Size = new System.Drawing.Size(190, 17);
            this.ckReiniciarAuto.TabIndex = 1;
            this.ckReiniciarAuto.Text = "Recomeçar ciclo automaticamente";
            this.ckReiniciarAuto.UseVisualStyleBackColor = true;
            // 
            // ckProxEtapaAuto
            // 
            this.ckProxEtapaAuto.AutoSize = true;
            this.ckProxEtapaAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckProxEtapaAuto.Location = new System.Drawing.Point(10, 20);
            this.ckProxEtapaAuto.Name = "ckProxEtapaAuto";
            this.ckProxEtapaAuto.Size = new System.Drawing.Size(243, 17);
            this.ckProxEtapaAuto.TabIndex = 0;
            this.ckProxEtapaAuto.Text = "Avançar para próxima etapa automaticamente";
            this.ckProxEtapaAuto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cPausaLonga);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cPausaBreve);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cPeriodoFoco);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cCorRefFundo);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(13, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cor texto período pausa longa";
            // 
            // cPausaLonga
            // 
            this.cPausaLonga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cPausaLonga.Cor = System.Drawing.Color.Gold;
            this.cPausaLonga.Location = new System.Drawing.Point(184, 104);
            this.cPausaLonga.Name = "cPausaLonga";
            this.cPausaLonga.Size = new System.Drawing.Size(66, 22);
            this.cPausaLonga.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cor texto período pausa breve";
            // 
            // cPausaBreve
            // 
            this.cPausaBreve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cPausaBreve.Cor = System.Drawing.Color.Gold;
            this.cPausaBreve.Location = new System.Drawing.Point(184, 76);
            this.cPausaBreve.Name = "cPausaBreve";
            this.cPausaBreve.Size = new System.Drawing.Size(66, 22);
            this.cPausaBreve.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cor texto período foco";
            // 
            // cPeriodoFoco
            // 
            this.cPeriodoFoco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cPeriodoFoco.Cor = System.Drawing.Color.White;
            this.cPeriodoFoco.Location = new System.Drawing.Point(184, 48);
            this.cPeriodoFoco.Name = "cPeriodoFoco";
            this.cPeriodoFoco.Size = new System.Drawing.Size(66, 22);
            this.cPeriodoFoco.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cor referência fundo";
            // 
            // cCorRefFundo
            // 
            this.cCorRefFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cCorRefFundo.Cor = System.Drawing.Color.Black;
            this.cCorRefFundo.Location = new System.Drawing.Point(184, 20);
            this.cCorRefFundo.Name = "cCorRefFundo";
            this.cCorRefFundo.Size = new System.Drawing.Size(66, 22);
            this.cCorRefFundo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSelFile);
            this.groupBox4.Controls.Add(this.txtAlertaSonoroCustom);
            this.groupBox4.Controls.Add(this.cbTipoAlertaSonoro);
            this.groupBox4.Controls.Add(this.cbTipoAlertaVisual);
            this.groupBox4.Controls.Add(this.ckAlertaSonoro);
            this.groupBox4.Controls.Add(this.ckAlertaVisual);
            this.groupBox4.Controls.Add(this.ckNotificacao);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(275, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 190);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alertas";
            // 
            // btnSelFile
            // 
            this.btnSelFile.Location = new System.Drawing.Point(227, 146);
            this.btnSelFile.Name = "btnSelFile";
            this.btnSelFile.Size = new System.Drawing.Size(26, 23);
            this.btnSelFile.TabIndex = 6;
            this.btnSelFile.Text = "...";
            this.btnSelFile.UseVisualStyleBackColor = true;
            this.btnSelFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAlertaSonoroCustom
            // 
            this.txtAlertaSonoroCustom.Location = new System.Drawing.Point(12, 146);
            this.txtAlertaSonoroCustom.Name = "txtAlertaSonoroCustom";
            this.txtAlertaSonoroCustom.ReadOnly = true;
            this.txtAlertaSonoroCustom.Size = new System.Drawing.Size(209, 20);
            this.txtAlertaSonoroCustom.TabIndex = 5;
            // 
            // cbTipoAlertaSonoro
            // 
            this.cbTipoAlertaSonoro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAlertaSonoro.FormattingEnabled = true;
            this.cbTipoAlertaSonoro.Location = new System.Drawing.Point(12, 118);
            this.cbTipoAlertaSonoro.Name = "cbTipoAlertaSonoro";
            this.cbTipoAlertaSonoro.Size = new System.Drawing.Size(238, 21);
            this.cbTipoAlertaSonoro.TabIndex = 4;
            this.cbTipoAlertaSonoro.SelectedIndexChanged += new System.EventHandler(this.cbTipoAlertaSonoro_SelectedIndexChanged);
            // 
            // cbTipoAlertaVisual
            // 
            this.cbTipoAlertaVisual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAlertaVisual.FormattingEnabled = true;
            this.cbTipoAlertaVisual.Location = new System.Drawing.Point(12, 65);
            this.cbTipoAlertaVisual.Name = "cbTipoAlertaVisual";
            this.cbTipoAlertaVisual.Size = new System.Drawing.Size(238, 21);
            this.cbTipoAlertaVisual.TabIndex = 3;
            // 
            // ckAlertaSonoro
            // 
            this.ckAlertaSonoro.AutoSize = true;
            this.ckAlertaSonoro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckAlertaSonoro.Location = new System.Drawing.Point(10, 95);
            this.ckAlertaSonoro.Name = "ckAlertaSonoro";
            this.ckAlertaSonoro.Size = new System.Drawing.Size(88, 17);
            this.ckAlertaSonoro.TabIndex = 2;
            this.ckAlertaSonoro.Text = "Alerta sonoro";
            this.ckAlertaSonoro.UseVisualStyleBackColor = true;
            this.ckAlertaSonoro.CheckedChanged += new System.EventHandler(this.ckAlertaSonoro_CheckedChanged);
            // 
            // ckAlertaVisual
            // 
            this.ckAlertaVisual.AutoSize = true;
            this.ckAlertaVisual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckAlertaVisual.Location = new System.Drawing.Point(10, 43);
            this.ckAlertaVisual.Name = "ckAlertaVisual";
            this.ckAlertaVisual.Size = new System.Drawing.Size(83, 17);
            this.ckAlertaVisual.TabIndex = 1;
            this.ckAlertaVisual.Text = "Alerta visual";
            this.ckAlertaVisual.UseVisualStyleBackColor = true;
            this.ckAlertaVisual.CheckedChanged += new System.EventHandler(this.ckAlertaVisual_CheckedChanged);
            // 
            // ckNotificacao
            // 
            this.ckNotificacao.AutoSize = true;
            this.ckNotificacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckNotificacao.Location = new System.Drawing.Point(10, 20);
            this.ckNotificacao.Name = "ckNotificacao";
            this.ckNotificacao.Size = new System.Drawing.Size(106, 17);
            this.ckNotificacao.TabIndex = 0;
            this.ckNotificacao.Text = "Exibir notificação";
            this.ckNotificacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(453, 299);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRedefinir
            // 
            this.btnRedefinir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedefinir.Location = new System.Drawing.Point(13, 299);
            this.btnRedefinir.Name = "btnRedefinir";
            this.btnRedefinir.Size = new System.Drawing.Size(75, 23);
            this.btnRedefinir.TabIndex = 5;
            this.btnRedefinir.Text = "Redefinir";
            this.btnRedefinir.UseVisualStyleBackColor = true;
            this.btnRedefinir.Click += new System.EventHandler(this.btnRedefinir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofdCustomAlertaSonoro";
            this.openFileDialog1.Filter = "Arquivos WAV|*.wav";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 334);
            this.Controls.Add(this.btnRedefinir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQtdPmodoros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPausaLonga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPausaBreve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTempoFoco)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nPausaLonga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nPausaBreve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nTempoFoco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nQtdPmodoros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckReiniciarAuto;
        private System.Windows.Forms.CheckBox ckProxEtapaAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private CustomControls.ColorPickerButton cPausaLonga;
        private System.Windows.Forms.Label label7;
        private CustomControls.ColorPickerButton cPausaBreve;
        private System.Windows.Forms.Label label6;
        private CustomControls.ColorPickerButton cPeriodoFoco;
        private System.Windows.Forms.Label label5;
        private CustomControls.ColorPickerButton cCorRefFundo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelFile;
        private System.Windows.Forms.TextBox txtAlertaSonoroCustom;
        private System.Windows.Forms.ComboBox cbTipoAlertaSonoro;
        private System.Windows.Forms.ComboBox cbTipoAlertaVisual;
        private System.Windows.Forms.CheckBox ckAlertaSonoro;
        private System.Windows.Forms.CheckBox ckAlertaVisual;
        private System.Windows.Forms.CheckBox ckNotificacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnRedefinir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}