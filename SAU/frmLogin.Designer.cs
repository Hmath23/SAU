
namespace SAU
{
    partial class frmLogin
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
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.lblmsgEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.mskRepetirSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskSenhaAtual = new System.Windows.Forms.MaskedTextBox();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.pnlMudarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsuario.Location = new System.Drawing.Point(45, 23);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(57, 24);
            this.lblEmailUsuario.TabIndex = 0;
            this.lblEmailUsuario.Text = "Email";
            this.lblEmailUsuario.Click += new System.EventHandler(this.lblEmailUsuario_Click);
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsuario.Location = new System.Drawing.Point(49, 50);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(248, 29);
            this.txtEmailUsuario.TabIndex = 1;
            // 
            // lblmsgEmail
            // 
            this.lblmsgEmail.AutoSize = true;
            this.lblmsgEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsgEmail.Location = new System.Drawing.Point(46, 82);
            this.lblmsgEmail.Name = "lblmsgEmail";
            this.lblmsgEmail.Size = new System.Drawing.Size(193, 16);
            this.lblmsgEmail.TabIndex = 2;
            this.lblmsgEmail.Text = "O email será o usuário de login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(45, 111);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(65, 24);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // mskSenha
            // 
            this.mskSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenha.Location = new System.Drawing.Point(49, 138);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '*';
            this.mskSenha.Size = new System.Drawing.Size(248, 29);
            this.mskSenha.TabIndex = 4;
            this.mskSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSenha_MaskInputRejected);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(63, 177);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 30);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(174, 177);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 30);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMudarSenha.Controls.Add(this.btnAlterar);
            this.pnlMudarSenha.Controls.Add(this.mskRepetirSenha);
            this.pnlMudarSenha.Controls.Add(this.mskNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.mskSenhaAtual);
            this.pnlMudarSenha.Controls.Add(this.lblRepetirSenha);
            this.pnlMudarSenha.Controls.Add(this.lblNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.lblSenhaAtual);
            this.pnlMudarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMudarSenha.Location = new System.Drawing.Point(422, 12);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(285, 237);
            this.pnlMudarSenha.TabIndex = 7;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(97, 169);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 30);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // mskRepetirSenha
            // 
            this.mskRepetirSenha.Location = new System.Drawing.Point(22, 137);
            this.mskRepetirSenha.Name = "mskRepetirSenha";
            this.mskRepetirSenha.PasswordChar = '*';
            this.mskRepetirSenha.Size = new System.Drawing.Size(245, 26);
            this.mskRepetirSenha.TabIndex = 5;
            this.mskRepetirSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskRepetirSenha_MaskInputRejected);
            // 
            // mskNovaSenha
            // 
            this.mskNovaSenha.Location = new System.Drawing.Point(22, 85);
            this.mskNovaSenha.Name = "mskNovaSenha";
            this.mskNovaSenha.PasswordChar = '*';
            this.mskNovaSenha.Size = new System.Drawing.Size(245, 26);
            this.mskNovaSenha.TabIndex = 4;
            this.mskNovaSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskNovaSenha_MaskInputRejected);
            // 
            // mskSenhaAtual
            // 
            this.mskSenhaAtual.Location = new System.Drawing.Point(22, 33);
            this.mskSenhaAtual.Name = "mskSenhaAtual";
            this.mskSenhaAtual.PasswordChar = '*';
            this.mskSenhaAtual.Size = new System.Drawing.Size(245, 26);
            this.mskSenhaAtual.TabIndex = 3;
            this.mskSenhaAtual.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSenhaAtual_MaskInputRejected);
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Location = new System.Drawing.Point(80, 114);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(112, 20);
            this.lblRepetirSenha.TabIndex = 2;
            this.lblRepetirSenha.Text = "Repetir Senha";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Location = new System.Drawing.Point(80, 62);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(96, 20);
            this.lblNovaSenha.TabIndex = 1;
            this.lblNovaSenha.Text = "Nova Senha";
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Location = new System.Drawing.Point(80, 10);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(97, 20);
            this.lblSenhaAtual.TabIndex = 0;
            this.lblSenhaAtual.Text = "Senha Atual";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 261);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mskSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblmsgEmail);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.lblEmailUsuario);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.Label lblmsgEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox mskRepetirSenha;
        private System.Windows.Forms.MaskedTextBox mskNovaSenha;
        private System.Windows.Forms.MaskedTextBox mskSenhaAtual;
        private System.Windows.Forms.Label lblRepetirSenha;
    }
}