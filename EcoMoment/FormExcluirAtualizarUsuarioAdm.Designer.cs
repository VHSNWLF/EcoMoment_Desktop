namespace EcoMoment
{
    partial class FormExcluirAtualizarUsuarioAdm
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
            this.comboBoxExcluirAdm = new System.Windows.Forms.ComboBox();
            this.txtNomeExcluirAdm = new System.Windows.Forms.TextBox();
            this.btnExcluirAdm = new System.Windows.Forms.Button();
            this.txtSenhaExcluirAdm = new System.Windows.Forms.TextBox();
            this.txtEmailExcluirAdm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxExcluirAdm
            // 
            this.comboBoxExcluirAdm.FormattingEnabled = true;
            this.comboBoxExcluirAdm.Location = new System.Drawing.Point(11, 131);
            this.comboBoxExcluirAdm.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxExcluirAdm.Name = "comboBoxExcluirAdm";
            this.comboBoxExcluirAdm.Size = new System.Drawing.Size(183, 21);
            this.comboBoxExcluirAdm.TabIndex = 19;
            this.comboBoxExcluirAdm.SelectedIndexChanged += new System.EventHandler(this.comboBoxExcluirAdm_SelectedIndexChanged);
            // 
            // txtNomeExcluirAdm
            // 
            this.txtNomeExcluirAdm.Location = new System.Drawing.Point(11, 187);
            this.txtNomeExcluirAdm.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeExcluirAdm.Name = "txtNomeExcluirAdm";
            this.txtNomeExcluirAdm.Size = new System.Drawing.Size(183, 20);
            this.txtNomeExcluirAdm.TabIndex = 18;
            // 
            // btnExcluirAdm
            // 
            this.btnExcluirAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnExcluirAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAdm.Location = new System.Drawing.Point(8, 402);
            this.btnExcluirAdm.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirAdm.Name = "btnExcluirAdm";
            this.btnExcluirAdm.Size = new System.Drawing.Size(182, 37);
            this.btnExcluirAdm.TabIndex = 17;
            this.btnExcluirAdm.Text = "Excluir/ Atualizar";
            this.btnExcluirAdm.UseVisualStyleBackColor = false;
            this.btnExcluirAdm.Click += new System.EventHandler(this.btnExcluirAdm_Click);
            // 
            // txtSenhaExcluirAdm
            // 
            this.txtSenhaExcluirAdm.Location = new System.Drawing.Point(11, 298);
            this.txtSenhaExcluirAdm.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaExcluirAdm.Name = "txtSenhaExcluirAdm";
            this.txtSenhaExcluirAdm.Size = new System.Drawing.Size(183, 20);
            this.txtSenhaExcluirAdm.TabIndex = 16;
            // 
            // txtEmailExcluirAdm
            // 
            this.txtEmailExcluirAdm.Location = new System.Drawing.Point(8, 244);
            this.txtEmailExcluirAdm.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailExcluirAdm.Name = "txtEmailExcluirAdm";
            this.txtEmailExcluirAdm.Size = new System.Drawing.Size(186, 20);
            this.txtEmailExcluirAdm.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Senha";
            // 
            // FormExcluirAtualizarUsuarioAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxExcluirAdm);
            this.Controls.Add(this.txtNomeExcluirAdm);
            this.Controls.Add(this.btnExcluirAdm);
            this.Controls.Add(this.txtSenhaExcluirAdm);
            this.Controls.Add(this.txtEmailExcluirAdm);
            this.Name = "FormExcluirAtualizarUsuarioAdm";
            this.Text = "FormExcluirAtualizarUsuarioAdm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExcluirAdm;
        private System.Windows.Forms.TextBox txtNomeExcluirAdm;
        private System.Windows.Forms.Button btnExcluirAdm;
        private System.Windows.Forms.TextBox txtSenhaExcluirAdm;
        private System.Windows.Forms.TextBox txtEmailExcluirAdm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}