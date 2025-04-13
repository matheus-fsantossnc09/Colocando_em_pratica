namespace Colocando_em_pratica
{
    partial class frmExercicios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Operdaor = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.lbl_MudarFundo = new System.Windows.Forms.Label();
            this.btn_Azul = new System.Windows.Forms.Button();
            this.btn_Amarelo = new System.Windows.Forms.Button();
            this.btn_Verde = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.txt_Clique = new System.Windows.Forms.TextBox();
            this.bttn_Clica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soma";
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num1.Location = new System.Drawing.Point(12, 83);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(188, 22);
            this.txt_num1.TabIndex = 1;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num2.Location = new System.Drawing.Point(226, 83);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(188, 22);
            this.txt_Num2.TabIndex = 2;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.Location = new System.Drawing.Point(440, 83);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(188, 22);
            this.txt_Resultado.TabIndex = 3;
            // 
            // lbl_Operdaor
            // 
            this.lbl_Operdaor.AutoSize = true;
            this.lbl_Operdaor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operdaor.Location = new System.Drawing.Point(206, 86);
            this.lbl_Operdaor.Name = "lbl_Operdaor";
            this.lbl_Operdaor.Size = new System.Drawing.Size(14, 16);
            this.lbl_Operdaor.TabIndex = 4;
            this.lbl_Operdaor.Text = "+";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(420, 86);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(14, 16);
            this.lbl_Resultado.TabIndex = 5;
            this.lbl_Resultado.Text = "=";
            // 
            // btn_Somar
            // 
            this.btn_Somar.Location = new System.Drawing.Point(663, 60);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(124, 45);
            this.btn_Somar.TabIndex = 6;
            this.btn_Somar.Text = "Somar";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // lbl_MudarFundo
            // 
            this.lbl_MudarFundo.AutoSize = true;
            this.lbl_MudarFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MudarFundo.Location = new System.Drawing.Point(12, 166);
            this.lbl_MudarFundo.Name = "lbl_MudarFundo";
            this.lbl_MudarFundo.Size = new System.Drawing.Size(122, 16);
            this.lbl_MudarFundo.TabIndex = 7;
            this.lbl_MudarFundo.Text = "Mudar cor de fundo";
            // 
            // btn_Azul
            // 
            this.btn_Azul.Location = new System.Drawing.Point(15, 212);
            this.btn_Azul.Name = "btn_Azul";
            this.btn_Azul.Size = new System.Drawing.Size(132, 56);
            this.btn_Azul.TabIndex = 8;
            this.btn_Azul.Text = "Azul";
            this.btn_Azul.UseVisualStyleBackColor = true;
            this.btn_Azul.Click += new System.EventHandler(this.btn_Azul_Click);
            // 
            // btn_Amarelo
            // 
            this.btn_Amarelo.Location = new System.Drawing.Point(174, 212);
            this.btn_Amarelo.Name = "btn_Amarelo";
            this.btn_Amarelo.Size = new System.Drawing.Size(132, 56);
            this.btn_Amarelo.TabIndex = 9;
            this.btn_Amarelo.Text = "Amarelo";
            this.btn_Amarelo.UseVisualStyleBackColor = true;
            this.btn_Amarelo.Click += new System.EventHandler(this.btn_Amarelo_Click);
            // 
            // btn_Verde
            // 
            this.btn_Verde.Location = new System.Drawing.Point(333, 212);
            this.btn_Verde.Name = "btn_Verde";
            this.btn_Verde.Size = new System.Drawing.Size(132, 56);
            this.btn_Verde.TabIndex = 10;
            this.btn_Verde.Text = "Verde";
            this.btn_Verde.UseVisualStyleBackColor = true;
            this.btn_Verde.Click += new System.EventHandler(this.btn_Verde_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(663, 212);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(132, 56);
            this.btn_Voltar.TabIndex = 11;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.Location = new System.Drawing.Point(12, 315);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(90, 13);
            this.lbl_Contador.TabIndex = 12;
            this.lbl_Contador.Text = "Contador de click";
            // 
            // txt_Clique
            // 
            this.txt_Clique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clique.Location = new System.Drawing.Point(12, 346);
            this.txt_Clique.Name = "txt_Clique";
            this.txt_Clique.Size = new System.Drawing.Size(188, 22);
            this.txt_Clique.TabIndex = 13;
            // 
            // bttn_Clica
            // 
            this.bttn_Clica.Location = new System.Drawing.Point(240, 346);
            this.bttn_Clica.Name = "bttn_Clica";
            this.bttn_Clica.Size = new System.Drawing.Size(132, 56);
            this.bttn_Clica.TabIndex = 14;
            this.bttn_Clica.Text = "Clica";
            this.bttn_Clica.UseVisualStyleBackColor = true;
            this.bttn_Clica.Click += new System.EventHandler(this.bttn_Clica_Click);
            // 
            // frmExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.bttn_Clica);
            this.Controls.Add(this.txt_Clique);
            this.Controls.Add(this.lbl_Contador);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Verde);
            this.Controls.Add(this.btn_Amarelo);
            this.Controls.Add(this.btn_Azul);
            this.Controls.Add(this.lbl_MudarFundo);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_Operdaor);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmExercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExercicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_Operdaor;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Label lbl_MudarFundo;
        private System.Windows.Forms.Button btn_Azul;
        private System.Windows.Forms.Button btn_Amarelo;
        private System.Windows.Forms.Button btn_Verde;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.TextBox txt_Clique;
        private System.Windows.Forms.Button bttn_Clica;
    }
}