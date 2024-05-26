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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxExcluirAdm
            // 
            this.comboBoxExcluirAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxExcluirAdm.FormattingEnabled = true;
            this.comboBoxExcluirAdm.Location = new System.Drawing.Point(61, 115);
            this.comboBoxExcluirAdm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxExcluirAdm.Name = "comboBoxExcluirAdm";
            this.comboBoxExcluirAdm.Size = new System.Drawing.Size(183, 21);
            this.comboBoxExcluirAdm.TabIndex = 0;
            this.comboBoxExcluirAdm.SelectedIndexChanged += new System.EventHandler(this.comboBoxExcluirAdm_SelectedIndexChanged);
            // 
            // txtNomeExcluirAdm
            // 
            this.txtNomeExcluirAdm.Location = new System.Drawing.Point(61, 170);
            this.txtNomeExcluirAdm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeExcluirAdm.Name = "txtNomeExcluirAdm";
            this.txtNomeExcluirAdm.Size = new System.Drawing.Size(183, 20);
            this.txtNomeExcluirAdm.TabIndex = 1;
            this.txtNomeExcluirAdm.TextChanged += new System.EventHandler(this.txtNomeExcluirAdm_TextChanged);
            // 
            // btnExcluirAdm
            // 
            this.btnExcluirAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnExcluirAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAdm.Location = new System.Drawing.Point(61, 386);
            this.btnExcluirAdm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluirAdm.Name = "btnExcluirAdm";
            this.btnExcluirAdm.Size = new System.Drawing.Size(182, 37);
            this.btnExcluirAdm.TabIndex = 4;
            this.btnExcluirAdm.Text = "Excluir/ Atualizar";
            this.btnExcluirAdm.UseVisualStyleBackColor = false;
            this.btnExcluirAdm.Click += new System.EventHandler(this.btnExcluirAdm_Click);
            // 
            // txtSenhaExcluirAdm
            // 
            this.txtSenhaExcluirAdm.Location = new System.Drawing.Point(60, 283);
            this.txtSenhaExcluirAdm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenhaExcluirAdm.Name = "txtSenhaExcluirAdm";
            this.txtSenhaExcluirAdm.Size = new System.Drawing.Size(183, 20);
            this.txtSenhaExcluirAdm.TabIndex = 3;
            this.txtSenhaExcluirAdm.TextChanged += new System.EventHandler(this.txtSenhaExcluirAdm_TextChanged);
            // 
            // txtEmailExcluirAdm
            // 
            this.txtEmailExcluirAdm.Location = new System.Drawing.Point(61, 228);
            this.txtEmailExcluirAdm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailExcluirAdm.Name = "txtEmailExcluirAdm";
            this.txtEmailExcluirAdm.Size = new System.Drawing.Size(186, 20);
            this.txtEmailExcluirAdm.TabIndex = 2;
            this.txtEmailExcluirAdm.TextChanged += new System.EventHandler(this.txtEmailExcluirAdm_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoMoment.Properties.Resources.Excluir_Adm;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormExcluirAtualizarUsuarioAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.comboBoxExcluirAdm);
            this.Controls.Add(this.txtNomeExcluirAdm);
            this.Controls.Add(this.btnExcluirAdm);
            this.Controls.Add(this.txtSenhaExcluirAdm);
            this.Controls.Add(this.txtEmailExcluirAdm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormExcluirAtualizarUsuarioAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExcluirAtualizarUsuarioAdm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExcluirAdm;
        private System.Windows.Forms.TextBox txtNomeExcluirAdm;
        private System.Windows.Forms.Button btnExcluirAdm;
        private System.Windows.Forms.TextBox txtSenhaExcluirAdm;
        private System.Windows.Forms.TextBox txtEmailExcluirAdm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}