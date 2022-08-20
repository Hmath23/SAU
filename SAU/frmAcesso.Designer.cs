
namespace SAU
{
    partial class frmAcesso
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
            this.lblTeste = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeste.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTeste.Location = new System.Drawing.Point(50, 165);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(693, 42);
            this.lblTeste.TabIndex = 0;
            this.lblTeste.Text = "Teste de Conexão com Banco de Dados";
            this.lblTeste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTeste
            // 
            this.btnTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.Location = new System.Drawing.Point(189, 294);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(80, 30);
            this.btnTeste.TabIndex = 1;
            this.btnTeste.Text = "Testar";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(473, 294);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 30);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(346, 228);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 42);
            this.lblResult.TabIndex = 3;
            // 
            // frmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblTeste);
            this.Name = "frmAcesso";
            this.Text = "Verificar Conexão";
            this.Load += new System.EventHandler(this.frmAcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResult;
    }
}