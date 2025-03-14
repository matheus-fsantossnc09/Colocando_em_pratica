namespace Colocando_em_pratica
{
    partial class frm_ex02
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
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.btn_Soma = new System.Windows.Forms.Button();
            this.btn_Divisao = new System.Windows.Forms.Button();
            this.btn_Subtracao = new System.Windows.Forms.Button();
            this.btn_Multiplicacao = new System.Windows.Forms.Button();
            this.lbl_Calculadora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anterior.Location = new System.Drawing.Point(60, 615);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(148, 47);
            this.btn_Anterior.TabIndex = 0;
            this.btn_Anterior.Text = "Anterior";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            this.btn_Anterior.Click += new System.EventHandler(this.btn_Anterior_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(806, 92);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(39, 36);
            this.lbl_Resultado.TabIndex = 1;
            this.lbl_Resultado.Text = "...";
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Location = new System.Drawing.Point(60, 92);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(334, 41);
            this.txt_Valor1.TabIndex = 2;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Location = new System.Drawing.Point(411, 92);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(334, 41);
            this.txt_Valor2.TabIndex = 3;
            // 
            // btn_Soma
            // 
            this.btn_Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Soma.Location = new System.Drawing.Point(60, 199);
            this.btn_Soma.Name = "btn_Soma";
            this.btn_Soma.Size = new System.Drawing.Size(185, 71);
            this.btn_Soma.TabIndex = 4;
            this.btn_Soma.Text = "Soma";
            this.btn_Soma.UseVisualStyleBackColor = true;
            this.btn_Soma.Click += new System.EventHandler(this.btn_Soma_Click);
            // 
            // btn_Divisao
            // 
            this.btn_Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Divisao.Location = new System.Drawing.Point(285, 303);
            this.btn_Divisao.Name = "btn_Divisao";
            this.btn_Divisao.Size = new System.Drawing.Size(185, 71);
            this.btn_Divisao.TabIndex = 5;
            this.btn_Divisao.Text = "Divisão";
            this.btn_Divisao.UseVisualStyleBackColor = true;
            this.btn_Divisao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Subtracao
            // 
            this.btn_Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtracao.Location = new System.Drawing.Point(60, 303);
            this.btn_Subtracao.Name = "btn_Subtracao";
            this.btn_Subtracao.Size = new System.Drawing.Size(185, 71);
            this.btn_Subtracao.TabIndex = 6;
            this.btn_Subtracao.Text = "Subtração";
            this.btn_Subtracao.UseVisualStyleBackColor = true;
            this.btn_Subtracao.Click += new System.EventHandler(this.btn_Subtracao_Click);
            // 
            // btn_Multiplicacao
            // 
            this.btn_Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiplicacao.Location = new System.Drawing.Point(285, 199);
            this.btn_Multiplicacao.Name = "btn_Multiplicacao";
            this.btn_Multiplicacao.Size = new System.Drawing.Size(185, 71);
            this.btn_Multiplicacao.TabIndex = 7;
            this.btn_Multiplicacao.Text = "Multiplicação";
            this.btn_Multiplicacao.UseVisualStyleBackColor = true;
            this.btn_Multiplicacao.Click += new System.EventHandler(this.btn_Multiplicacao_Click);
            // 
            // lbl_Calculadora
            // 
            this.lbl_Calculadora.AutoSize = true;
            this.lbl_Calculadora.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calculadora.Location = new System.Drawing.Point(54, 45);
            this.lbl_Calculadora.Name = "lbl_Calculadora";
            this.lbl_Calculadora.Size = new System.Drawing.Size(187, 35);
            this.lbl_Calculadora.TabIndex = 8;
            this.lbl_Calculadora.Text = "Calculadora";
            // 
            // frm_ex02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 692);
            this.Controls.Add(this.lbl_Calculadora);
            this.Controls.Add(this.btn_Multiplicacao);
            this.Controls.Add(this.btn_Subtracao);
            this.Controls.Add(this.btn_Divisao);
            this.Controls.Add(this.btn_Soma);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Anterior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "frm_ex02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Anterior;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.Button btn_Soma;
        private System.Windows.Forms.Button btn_Divisao;
        private System.Windows.Forms.Button btn_Subtracao;
        private System.Windows.Forms.Button btn_Multiplicacao;
        private System.Windows.Forms.Label lbl_Calculadora;
    }
}