﻿namespace EcoMoment
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
            this.btnReativar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxExcluirWeb
            // 
            this.comboBoxExcluirWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxExcluirWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxExcluirWeb.FormattingEnabled = true;
            this.comboBoxExcluirWeb.Location = new System.Drawing.Point(77, 146);
            this.comboBoxExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxExcluirWeb.Name = "comboBoxExcluirWeb";
            this.comboBoxExcluirWeb.Size = new System.Drawing.Size(260, 24);
            this.comboBoxExcluirWeb.TabIndex = 0;
            this.comboBoxExcluirWeb.SelectedIndexChanged += new System.EventHandler(this.comboBoxExcluirWeb_SelectedIndexChanged);
            // 
            // txtNomeExcluirWeb
            // 
            this.txtNomeExcluirWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeExcluirWeb.Location = new System.Drawing.Point(77, 217);
            this.txtNomeExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeExcluirWeb.Name = "txtNomeExcluirWeb";
            this.txtNomeExcluirWeb.Size = new System.Drawing.Size(260, 22);
            this.txtNomeExcluirWeb.TabIndex = 1;
            // 
            // btnExcluirWeb
            // 
            this.btnExcluirWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExcluirWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnExcluirWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirWeb.Location = new System.Drawing.Point(84, 474);
            this.btnExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluirWeb.Name = "btnExcluirWeb";
            this.btnExcluirWeb.Size = new System.Drawing.Size(243, 46);
            this.btnExcluirWeb.TabIndex = 4;
            this.btnExcluirWeb.Text = "Excluir/ Atualizar";
            this.btnExcluirWeb.UseVisualStyleBackColor = false;
            this.btnExcluirWeb.Click += new System.EventHandler(this.btnExcluirWeb_Click);
            // 
            // txtSenhaExcluirWeb
            // 
            this.txtSenhaExcluirWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenhaExcluirWeb.Location = new System.Drawing.Point(77, 353);
            this.txtSenhaExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaExcluirWeb.Name = "txtSenhaExcluirWeb";
            this.txtSenhaExcluirWeb.Size = new System.Drawing.Size(260, 22);
            this.txtSenhaExcluirWeb.TabIndex = 3;
            // 
            // txtEmailExcluirWeb
            // 
            this.txtEmailExcluirWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmailExcluirWeb.Location = new System.Drawing.Point(75, 283);
            this.txtEmailExcluirWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailExcluirWeb.Name = "txtEmailExcluirWeb";
            this.txtEmailExcluirWeb.Size = new System.Drawing.Size(263, 22);
            this.txtEmailExcluirWeb.TabIndex = 2;
            // 
            // btnReativar
            // 
            this.btnReativar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnReativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReativar.Enabled = false;
            this.btnReativar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReativar.Location = new System.Drawing.Point(84, 526);
            this.btnReativar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReativar.Name = "btnReativar";
            this.btnReativar.Size = new System.Drawing.Size(243, 28);
            this.btnReativar.TabIndex = 20;
            this.btnReativar.Text = "Reativar";
            this.btnReativar.UseVisualStyleBackColor = false;
            this.btnReativar.Click += new System.EventHandler(this.btnReativar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::EcoMoment.Properties.Resources.Excluir_Web;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormExcluirAtualizarUsuarioWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 554);
            this.Controls.Add(this.btnReativar);
            this.Controls.Add(this.comboBoxExcluirWeb);
            this.Controls.Add(this.txtNomeExcluirWeb);
            this.Controls.Add(this.btnExcluirWeb);
            this.Controls.Add(this.txtSenhaExcluirWeb);
            this.Controls.Add(this.txtEmailExcluirWeb);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormExcluirAtualizarUsuarioWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExcluirAtualizarUsuarioWeb";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExcluirWeb;
        private System.Windows.Forms.TextBox txtNomeExcluirWeb;
        private System.Windows.Forms.Button btnExcluirWeb;
        private System.Windows.Forms.TextBox txtSenhaExcluirWeb;
        private System.Windows.Forms.TextBox txtEmailExcluirWeb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReativar;
    }
}