namespace EcoMoment
{
    partial class FormExcluirAtualizarUsuarioWeb
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
            this.comboBoxExcluirWeb = new System.Windows.Forms.ComboBox();
            this.txtNomeExcluirWeb = new System.Windows.Forms.TextBox();
            this.btnExcluirWeb = new System.Windows.Forms.Button();
            this.txtSenhaExcluirWeb = new System.Windows.Forms.TextBox();
            this.txtEmailExcluirWeb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxExcluirWeb
            // 
            this.comboBoxExcluirWeb.FormattingEnabled = true;
            this.comboBoxExcluirWeb.Location = new System.Drawing.Point(11, 137);
            this.comboBoxExcluirWeb.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxExcluirWeb.Name = "comboBoxExcluirWeb";
            this.comboBoxExcluirWeb.Size = new System.Drawing.Size(196, 21);
            this.comboBoxExcluirWeb.TabIndex = 18;
            this.comboBoxExcluirWeb.SelectedIndexChanged += new System.EventHandler(this.comboBoxExcluirWeb_SelectedIndexChanged);
            // 
            // txtNomeExcluirWeb
            // 
            this.txtNomeExcluirWeb.Location = new System.Drawing.Point(11, 194);
            this.txtNomeExcluirWeb.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeExcluirWeb.Name = "txtNomeExcluirWeb";
            this.txtNomeExcluirWeb.Size = new System.Drawing.Size(196, 20);
            this.txtNomeExcluirWeb.TabIndex = 17;
            // 
            // btnExcluirWeb
            // 
            this.btnExcluirWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnExcluirWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirWeb.Location = new System.Drawing.Point(23, 404);
            this.btnExcluirWeb.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirWeb.Name = "btnExcluirWeb";
            this.btnExcluirWeb.Size = new System.Drawing.Size(182, 37);
            this.btnExcluirWeb.TabIndex = 16;
            this.btnExcluirWeb.Text = "Excluir/ Atualizar";
            this.btnExcluirWeb.UseVisualStyleBackColor = false;
            this.btnExcluirWeb.Click += new System.EventHandler(this.btnExcluirWeb_Click);
            // 
            // txtSenhaExcluirWeb
            // 
            this.txtSenhaExcluirWeb.Location = new System.Drawing.Point(11, 305);
            this.txtSenhaExcluirWeb.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaExcluirWeb.Name = "txtSenhaExcluirWeb";
            this.txtSenhaExcluirWeb.Size = new System.Drawing.Size(196, 20);
            this.txtSenhaExcluirWeb.TabIndex = 15;
            // 
            // txtEmailExcluirWeb
            // 
            this.txtEmailExcluirWeb.Location = new System.Drawing.Point(9, 248);
            this.txtEmailExcluirWeb.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailExcluirWeb.Name = "txtEmailExcluirWeb";
            this.txtEmailExcluirWeb.Size = new System.Drawing.Size(198, 20);
            this.txtEmailExcluirWeb.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Senha";
            // 
            // FormExcluirAtualizarUsuarioWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxExcluirWeb);
            this.Controls.Add(this.txtNomeExcluirWeb);
            this.Controls.Add(this.btnExcluirWeb);
            this.Controls.Add(this.txtSenhaExcluirWeb);
            this.Controls.Add(this.txtEmailExcluirWeb);
            this.Name = "FormExcluirAtualizarUsuarioWeb";
            this.Text = "FormExcluirAtualizarUsuarioWeb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExcluirWeb;
        private System.Windows.Forms.TextBox txtNomeExcluirWeb;
        private System.Windows.Forms.Button btnExcluirWeb;
        private System.Windows.Forms.TextBox txtSenhaExcluirWeb;
        private System.Windows.Forms.TextBox txtEmailExcluirWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}