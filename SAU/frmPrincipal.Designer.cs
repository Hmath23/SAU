
namespace SAU
{
    partial class frmPrincipal
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pctPrincipal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChamados = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(29, 67);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(154, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Área exclusiva de ";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pctPrincipal
            // 
            this.pctPrincipal.Image = global::SAU.Properties.Resources.HMTZ;
            this.pctPrincipal.Location = new System.Drawing.Point(336, 58);
            this.pctPrincipal.Name = "pctPrincipal";
            this.pctPrincipal.Size = new System.Drawing.Size(317, 323);
            this.pctPrincipal.TabIndex = 1;
            this.pctPrincipal.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnContatos);
            this.panel1.Controls.Add(this.btnChamados);
            this.panel1.Location = new System.Drawing.Point(28, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 219);
            this.panel1.TabIndex = 0;
            // 
            // btnChamados
            // 
            this.btnChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamados.Location = new System.Drawing.Point(29, 15);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(100, 30);
            this.btnChamados.TabIndex = 1;
            this.btnChamados.Text = "Chamados";
            this.btnChamados.UseVisualStyleBackColor = true;
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.Location = new System.Drawing.Point(29, 76);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(100, 30);
            this.btnContatos.TabIndex = 2;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(29, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctPrincipal);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Atendimento ao Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pctPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnChamados;
    }
}