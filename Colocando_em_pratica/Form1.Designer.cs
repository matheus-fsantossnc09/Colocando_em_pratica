namespace Colocando_em_pratica
{
    partial class frm_Revisao
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
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.btn_Mudar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Proximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(106, 83);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(102, 39);
            this.lbl_Texto.TabIndex = 0;
            this.lbl_Texto.Text = "Texto";
            this.lbl_Texto.Click += new System.EventHandler(this.lbl_Texto_Click);
            // 
            // txt_Texto
            // 
            this.txt_Texto.Location = new System.Drawing.Point(113, 148);
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(493, 22);
            this.txt_Texto.TabIndex = 1;
            this.txt_Texto.TextChanged += new System.EventHandler(this.txt_Texto_TextChanged);
            // 
            // btn_Mudar
            // 
            this.btn_Mudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mudar.Location = new System.Drawing.Point(113, 210);
            this.btn_Mudar.Name = "btn_Mudar";
            this.btn_Mudar.Size = new System.Drawing.Size(124, 55);
            this.btn_Mudar.TabIndex = 2;
            this.btn_Mudar.Text = "Mudar";
            this.btn_Mudar.UseVisualStyleBackColor = true;
            this.btn_Mudar.Click += new System.EventHandler(this.btn_Mudar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(482, 210);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(124, 55);
            this.btn_Voltar.TabIndex = 3;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(113, 487);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(146, 47);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Proximo
            // 
            this.btn_Proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proximo.Location = new System.Drawing.Point(471, 487);
            this.btn_Proximo.Name = "btn_Proximo";
            this.btn_Proximo.Size = new System.Drawing.Size(135, 47);
            this.btn_Proximo.TabIndex = 5;
            this.btn_Proximo.Text = "Próximo";
            this.btn_Proximo.UseVisualStyleBackColor = true;
            this.btn_Proximo.Click += new System.EventHandler(this.btn_Proximo_Click);
            // 
            // frm_Revisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 693);
            this.Controls.Add(this.btn_Proximo);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Mudar);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.lbl_Texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_Revisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisão";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Button btn_Mudar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Proximo;
    }
}

