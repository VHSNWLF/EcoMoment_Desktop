namespace EcoMoment
{
    partial class FormCadastro
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
            this.txtEmailCadastrar = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastrar = new System.Windows.Forms.TextBox();
            this.txtSenha2Cadastrar = new System.Windows.Forms.TextBox();
            this.txtNomeCadastrar = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmailCadastrar
            // 
            this.txtEmailCadastrar.Location = new System.Drawing.Point(46, 187);
            this.txtEmailCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailCadastrar.Name = "txtEmailCadastrar";
            this.txtEmailCadastrar.Size = new System.Drawing.Size(308, 22);
            this.txtEmailCadastrar.TabIndex = 1;
            // 
            // txtSenhaCadastrar
            // 
            this.txtSenhaCadastrar.Location = new System.Drawing.Point(46, 253);
            this.txtSenhaCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaCadastrar.Name = "txtSenhaCadastrar";
            this.txtSenhaCadastrar.Size = new System.Drawing.Size(308, 22);
            this.txtSenhaCadastrar.TabIndex = 2;
            // 
            // txtSenha2Cadastrar
            // 
            this.txtSenha2Cadastrar.Location = new System.Drawing.Point(46, 323);
            this.txtSenha2Cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha2Cadastrar.Name = "txtSenha2Cadastrar";
            this.txtSenha2Cadastrar.Size = new System.Drawing.Size(308, 22);
            this.txtSenha2Cadastrar.TabIndex = 3;
            // 
            // txtNomeCadastrar
            // 
            this.txtNomeCadastrar.Location = new System.Drawing.Point(46, 124);
            this.txtNomeCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCadastrar.Name = "txtNomeCadastrar";
            this.txtNomeCadastrar.Size = new System.Drawing.Size(308, 22);
            this.txtNomeCadastrar.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(77, 597);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(278, 44);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoMoment.Properties.Resources.Tela_cadastro;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 683);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Clique aqui para voltar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailCadastrar);
            this.Controls.Add(this.txtSenhaCadastrar);
            this.Controls.Add(this.txtSenha2Cadastrar);
            this.Controls.Add(this.txtNomeCadastrar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailCadastrar;
        private System.Windows.Forms.TextBox txtSenhaCadastrar;
        private System.Windows.Forms.TextBox txtSenha2Cadastrar;
        private System.Windows.Forms.TextBox txtNomeCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}