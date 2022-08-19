
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnChamados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(34, 32);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(154, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Área exclusiva de ";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pctPrincipal
            // 
            this.pctPrincipal.Image = global::SAU.Properties.Resources.HMTZ;
            this.pctPrincipal.Location = new System.Drawing.Point(244, 32);
            this.pctPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctPrincipal.Name = "pctPrincipal";
            this.pctPrincipal.Size = new System.Drawing.Size(497, 474);
            this.pctPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctPrincipal.TabIndex = 1;
            this.pctPrincipal.TabStop = false;
            this.pctPrincipal.Click += new System.EventHandler(this.pctPrincipal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnContatos);
            this.panel1.Controls.Add(this.btnChamados);
            this.panel1.Location = new System.Drawing.Point(11, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(34, 152);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.Location = new System.Drawing.Point(34, 88);
            this.btnContatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(116, 35);
            this.btnContatos.TabIndex = 2;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnChamados
            // 
            this.btnChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamados.Location = new System.Drawing.Point(34, 17);
            this.btnChamados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(116, 35);
            this.btnChamados.TabIndex = 1;
            this.btnChamados.Text = "Chamados";
            this.btnChamados.UseVisualStyleBackColor = true;
            this.btnChamados.Click += new System.EventHandler(this.btnChamados_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(768, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctPrincipal);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Atendimento ao Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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