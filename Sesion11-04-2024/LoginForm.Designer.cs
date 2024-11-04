namespace Sesion11_04_2024
{
    partial class LoginForm
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(309, 119);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(291, 154);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(64, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(362, 111);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(362, 146);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(362, 215);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(98, 65);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gray;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 291);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 371);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Name = "LoginForm";
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnIniciar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

