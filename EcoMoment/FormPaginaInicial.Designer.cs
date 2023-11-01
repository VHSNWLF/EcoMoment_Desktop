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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(298, 277);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 27);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosADMToolStripMenuItem,
            this.usuáriosWebToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // usuáriosADMToolStripMenuItem
            // 
            this.usuáriosADMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirUsuárioADMToolStripMenuItem,
            this.atualizarDadosADMToolStripMenuItem,
            this.consultarDadosDeUsuáriosADMToolStripMenuItem});
            this.usuáriosADMToolStripMenuItem.Name = "usuáriosADMToolStripMenuItem";
            this.usuáriosADMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosADMToolStripMenuItem.Text = "Usuários [Adm]";
            // 
            // excluirUsuárioADMToolStripMenuItem
            // 
            this.excluirUsuárioADMToolStripMenuItem.Name = "excluirUsuárioADMToolStripMenuItem";
            this.excluirUsuárioADMToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.excluirUsuárioADMToolStripMenuItem.Text = "Excluir usuário ADM";
            this.excluirUsuárioADMToolStripMenuItem.Click += new System.EventHandler(this.excluirUsuárioADMToolStripMenuItem_Click);
            // 
            // atualizarDadosADMToolStripMenuItem
            // 
            this.atualizarDadosADMToolStripMenuItem.Name = "atualizarDadosADMToolStripMenuItem";
            this.atualizarDadosADMToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.atualizarDadosADMToolStripMenuItem.Text = "Atualizar dados ADM";
            this.atualizarDadosADMToolStripMenuItem.Click += new System.EventHandler(this.atualizarDadosADMToolStripMenuItem_Click);
            // 
            // consultarDadosDeUsuáriosADMToolStripMenuItem
            // 
            this.consultarDadosDeUsuáriosADMToolStripMenuItem.Name = "consultarDadosDeUsuáriosADMToolStripMenuItem";
            this.consultarDadosDeUsuáriosADMToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
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
            this.usuáriosWebToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosWebToolStripMenuItem.Text = "Usuários [Web]";
            // 
            // excluirUsuárioWebToolStripMenuItem
            // 
            this.excluirUsuárioWebToolStripMenuItem.Name = "excluirUsuárioWebToolStripMenuItem";
            this.excluirUsuárioWebToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.excluirUsuárioWebToolStripMenuItem.Text = "Excluir usuário Web";
            this.excluirUsuárioWebToolStripMenuItem.Click += new System.EventHandler(this.excluirUsuárioWebToolStripMenuItem_Click);
            // 
            // atualizarUsuárioWebToolStripMenuItem
            // 
            this.atualizarUsuárioWebToolStripMenuItem.Name = "atualizarUsuárioWebToolStripMenuItem";
            this.atualizarUsuárioWebToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.atualizarUsuárioWebToolStripMenuItem.Text = "Atualizar usuário Web";
            this.atualizarUsuárioWebToolStripMenuItem.Click += new System.EventHandler(this.atualizarUsuárioWebToolStripMenuItem_Click);
            // 
            // consultarDadosDeUisuáriosWebToolStripMenuItem
            // 
            this.consultarDadosDeUisuáriosWebToolStripMenuItem.Name = "consultarDadosDeUisuáriosWebToolStripMenuItem";
            this.consultarDadosDeUisuáriosWebToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.consultarDadosDeUisuáriosWebToolStripMenuItem.Text = "Consultar dados de usuários Web";
            this.consultarDadosDeUisuáriosWebToolStripMenuItem.Click += new System.EventHandler(this.consultarDadosDeUisuáriosWebToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // FormPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormPaginaInicial";
            this.Text = "FormPaginaInicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}