﻿namespace EcoMoment
{
    partial class FormConsultaTodos
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenhaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeSeguidores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeSeguindo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeCurtidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdePostagens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reputacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(76, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(485, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.NomeUsuario,
            this.EmailUsuario,
            this.SenhaUsuario,
            this.qtdeSeguidores,
            this.qtdeSeguindo,
            this.qtdeCurtidas,
            this.qtdePostagens,
            this.Reputacao,
            this.Biografia});
            this.dataGridView1.Location = new System.Drawing.Point(36, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(573, 327);
            this.dataGridView1.TabIndex = 7;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.MinimumWidth = 6;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Width = 125;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.HeaderText = "Nome de usuário";
            this.NomeUsuario.MinimumWidth = 6;
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Width = 125;
            // 
            // EmailUsuario
            // 
            this.EmailUsuario.HeaderText = "Email";
            this.EmailUsuario.MinimumWidth = 6;
            this.EmailUsuario.Name = "EmailUsuario";
            this.EmailUsuario.Width = 125;
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.HeaderText = "Senha";
            this.SenhaUsuario.MinimumWidth = 6;
            this.SenhaUsuario.Name = "SenhaUsuario";
            this.SenhaUsuario.Width = 125;
            // 
            // qtdeSeguidores
            // 
            this.qtdeSeguidores.HeaderText = "Seguidores";
            this.qtdeSeguidores.MinimumWidth = 6;
            this.qtdeSeguidores.Name = "qtdeSeguidores";
            this.qtdeSeguidores.ReadOnly = true;
            this.qtdeSeguidores.Width = 125;
            // 
            // qtdeSeguindo
            // 
            this.qtdeSeguindo.HeaderText = "Seguindo";
            this.qtdeSeguindo.MinimumWidth = 6;
            this.qtdeSeguindo.Name = "qtdeSeguindo";
            this.qtdeSeguindo.ReadOnly = true;
            this.qtdeSeguindo.Width = 125;
            // 
            // qtdeCurtidas
            // 
            this.qtdeCurtidas.HeaderText = "Curtidas";
            this.qtdeCurtidas.MinimumWidth = 6;
            this.qtdeCurtidas.Name = "qtdeCurtidas";
            this.qtdeCurtidas.ReadOnly = true;
            this.qtdeCurtidas.Width = 125;
            // 
            // qtdePostagens
            // 
            this.qtdePostagens.HeaderText = "Postagens";
            this.qtdePostagens.MinimumWidth = 6;
            this.qtdePostagens.Name = "qtdePostagens";
            this.qtdePostagens.ReadOnly = true;
            this.qtdePostagens.Width = 125;
            // 
            // Reputacao
            // 
            this.Reputacao.HeaderText = "Reputação";
            this.Reputacao.MinimumWidth = 6;
            this.Reputacao.Name = "Reputacao";
            this.Reputacao.ReadOnly = true;
            this.Reputacao.Width = 125;
            // 
            // Biografia
            // 
            this.Biografia.HeaderText = "Biografia";
            this.Biografia.MinimumWidth = 6;
            this.Biografia.Name = "Biografia";
            this.Biografia.ReadOnly = true;
            this.Biografia.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::EcoMoment.Properties.Resources.Padrão_de_consultar_todos;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormConsultaTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConsultaTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaTodos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenhaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeSeguidores;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeSeguindo;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeCurtidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdePostagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reputacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biografia;
    }
}