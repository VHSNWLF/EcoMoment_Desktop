namespace EcoMoment
{
    partial class FormPaginaInicial
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUsuárioADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarDadosADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDadosDeUsuáriosADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUsuárioWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarUsuárioWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDadosDeUisuáriosWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(288, 316);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(228, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // usuáriosADMToolStripMenuItem
            // 
            this.usuáriosADMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirUsuárioADMToolStripMenuItem,
            this.atualizarDadosADMToolStripMenuItem,
            this.consultarDadosDeUsuáriosADMToolStripMenuItem});
            this.usuáriosADMToolStripMenuItem.Name = "usuáriosADMToolStripMenuItem";
            this.usuáriosADMToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuáriosADMToolStripMenuItem.Text = "Usuários [Adm]";
            // 
            // excluirUsuárioADMToolStripMenuItem
            // 
            this.excluirUsuárioADMToolStripMenuItem.Name = "excluirUsuárioADMToolStripMenuItem";
            this.excluirUsuárioADMToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.excluirUsuárioADMToolStripMenuItem.Text = "Excluir usuário ADM";
            this.excluirUsuárioADMToolStripMenuItem.Click += new System.EventHandler(this.excluirUsuárioADMToolStripMenuItem_Click);
            // 
            // atualizarDadosADMToolStripMenuItem
            // 
            this.atualizarDadosADMToolStripMenuItem.Name = "atualizarDadosADMToolStripMenuItem";
            this.atualizarDadosADMToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.atualizarDadosADMToolStripMenuItem.Text = "Atualizar dados ADM";
            this.atualizarDadosADMToolStripMenuItem.Click += new System.EventHandler(this.atualizarDadosADMToolStripMenuItem_Click);
            // 
            // consultarDadosDeUsuáriosADMToolStripMenuItem
            // 
            this.consultarDadosDeUsuáriosADMToolStripMenuItem.Name = "consultarDadosDeUsuáriosADMToolStripMenuItem";
            this.consultarDadosDeUsuáriosADMToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.consultarDadosDeUsuáriosADMToolStripMenuItem.Text = "Consultar dados de usuários ADM";
            this.consultarDadosDeUsuáriosADMToolStripMenuItem.Click += new System.EventHandler(this.consultarDadosDeUsuáriosADMToolStripMenuItem_Click);
            // 
            // usuáriosWebToolStripMenuItem
            // 
            this.usuáriosWebToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirUsuárioWebToolStripMenuItem,
            this.atualizarUsuárioWebToolStripMenuItem,
            this.consultarDadosDeUisuáriosWebToolStripMenuItem});
            this.usuáriosWebToolStripMenuItem.Name = "usuáriosWebToolStripMenuItem";
            this.usuáriosWebToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuáriosWebToolStripMenuItem.Text = "Usuários [Web]";
            // 
            // excluirUsuárioWebToolStripMenuItem
            // 
            this.excluirUsuárioWebToolStripMenuItem.Name = "excluirUsuárioWebToolStripMenuItem";
            this.excluirUsuárioWebToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.excluirUsuárioWebToolStripMenuItem.Text = "Excluir usuário Web";
            this.excluirUsuárioWebToolStripMenuItem.Click += new System.EventHandler(this.excluirUsuárioWebToolStripMenuItem_Click);
            // 
            // atualizarUsuárioWebToolStripMenuItem
            // 
            this.atualizarUsuárioWebToolStripMenuItem.Name = "atualizarUsuárioWebToolStripMenuItem";
            this.atualizarUsuárioWebToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.atualizarUsuárioWebToolStripMenuItem.Text = "Atualizar usuário Web";
            this.atualizarUsuárioWebToolStripMenuItem.Click += new System.EventHandler(this.atualizarUsuárioWebToolStripMenuItem_Click);
            // 
            // consultarDadosDeUisuáriosWebToolStripMenuItem
            // 
            this.consultarDadosDeUisuáriosWebToolStripMenuItem.Name = "consultarDadosDeUisuáriosWebToolStripMenuItem";
            this.consultarDadosDeUisuáriosWebToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.consultarDadosDeUisuáriosWebToolStripMenuItem.Text = "Consultar dados de usuários Web";
            this.consultarDadosDeUisuáriosWebToolStripMenuItem.Click += new System.EventHandler(this.consultarDadosDeUisuáriosWebToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoMoment.Properties.Resources.Página_inicial;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPaginaInicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirUsuárioADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarDadosADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDadosDeUsuáriosADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirUsuárioWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarUsuárioWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDadosDeUisuáriosWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}