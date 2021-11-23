namespace Teste
{
    partial class Form1
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
            this.pomodoroTimer1 = new PomodoroTaskBar.PomodoroTimer();
            this.SuspendLayout();
            // 
            // pomodoroTimer1
            // 
            this.pomodoroTimer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pomodoroTimer1.Location = new System.Drawing.Point(0, 0);
            this.pomodoroTimer1.Name = "pomodoroTimer1";
            this.pomodoroTimer1.Size = new System.Drawing.Size(120, 30);
            this.pomodoroTimer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(120, 30);
            this.Controls.Add(this.pomodoroTimer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PomodoroTaskBar.PomodoroTimer pomodoroTimer1;
    }
}

