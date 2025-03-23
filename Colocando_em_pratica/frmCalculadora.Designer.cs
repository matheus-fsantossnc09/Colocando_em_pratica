namespace Colocando_em_pratica
{
    partial class frm_Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Calculadora));
            this.lbl_Calculadora = new System.Windows.Forms.Label();
            this.lbl_Operador = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.rdb_Soma = new System.Windows.Forms.RadioButton();
            this.rdb_Subtracao = new System.Windows.Forms.RadioButton();
            this.rdb_Multiplicacao = new System.Windows.Forms.RadioButton();
            this.rdb_Divisao = new System.Windows.Forms.RadioButton();
            this.lbl_Erro = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.pct_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Calculadora
            // 
            this.lbl_Calculadora.AutoSize = true;
            this.lbl_Calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calculadora.Location = new System.Drawing.Point(36, 114);
            this.lbl_Calculadora.Name = "lbl_Calculadora";
            this.lbl_Calculadora.Size = new System.Drawing.Size(110, 24);
            this.lbl_Calculadora.TabIndex = 0;
            this.lbl_Calculadora.Text = "Calculadora";
            // 
            // lbl_Operador
            // 
            this.lbl_Operador.AutoSize = true;
            this.lbl_Operador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operador.Location = new System.Drawing.Point(281, 183);
            this.lbl_Operador.Name = "lbl_Operador";
            this.lbl_Operador.Size = new System.Drawing.Size(21, 24);
            this.lbl_Operador.TabIndex = 1;
            this.lbl_Operador.Text = "+";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num1.Location = new System.Drawing.Point(39, 181);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(236, 29);
            this.txt_Num1.TabIndex = 0;
            this.txt_Num1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Num1_KeyDown);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.Location = new System.Drawing.Point(577, 181);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(236, 29);
            this.txt_Resultado.TabIndex = 9;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num2.Location = new System.Drawing.Point(308, 181);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(236, 29);
            this.txt_Num2.TabIndex = 1;
            this.txt_Num2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Num2_KeyDown);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(550, 183);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(21, 24);
            this.lbl_Resultado.TabIndex = 5;
            this.lbl_Resultado.Text = "=";
            // 
            // rdb_Soma
            // 
            this.rdb_Soma.AutoSize = true;
            this.rdb_Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Soma.Location = new System.Drawing.Point(40, 256);
            this.rdb_Soma.Name = "rdb_Soma";
            this.rdb_Soma.Size = new System.Drawing.Size(77, 28);
            this.rdb_Soma.TabIndex = 2;
            this.rdb_Soma.TabStop = true;
            this.rdb_Soma.Text = "Soma";
            this.rdb_Soma.UseVisualStyleBackColor = true;
            this.rdb_Soma.CheckedChanged += new System.EventHandler(this.rdb_Soma_CheckedChanged);
            // 
            // rdb_Subtracao
            // 
            this.rdb_Subtracao.AutoSize = true;
            this.rdb_Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Subtracao.Location = new System.Drawing.Point(40, 306);
            this.rdb_Subtracao.Name = "rdb_Subtracao";
            this.rdb_Subtracao.Size = new System.Drawing.Size(113, 28);
            this.rdb_Subtracao.TabIndex = 3;
            this.rdb_Subtracao.TabStop = true;
            this.rdb_Subtracao.Text = "Subtração";
            this.rdb_Subtracao.UseVisualStyleBackColor = true;
            this.rdb_Subtracao.CheckedChanged += new System.EventHandler(this.rdb_Subtracao_CheckedChanged);
            // 
            // rdb_Multiplicacao
            // 
            this.rdb_Multiplicacao.AutoSize = true;
            this.rdb_Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Multiplicacao.Location = new System.Drawing.Point(40, 363);
            this.rdb_Multiplicacao.Name = "rdb_Multiplicacao";
            this.rdb_Multiplicacao.Size = new System.Drawing.Size(137, 28);
            this.rdb_Multiplicacao.TabIndex = 4;
            this.rdb_Multiplicacao.TabStop = true;
            this.rdb_Multiplicacao.Text = "Multiplicação";
            this.rdb_Multiplicacao.UseVisualStyleBackColor = true;
            this.rdb_Multiplicacao.CheckedChanged += new System.EventHandler(this.rdb_Multiplicacao_CheckedChanged);
            // 
            // rdb_Divisao
            // 
            this.rdb_Divisao.AutoSize = true;
            this.rdb_Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Divisao.Location = new System.Drawing.Point(40, 426);
            this.rdb_Divisao.Name = "rdb_Divisao";
            this.rdb_Divisao.Size = new System.Drawing.Size(88, 28);
            this.rdb_Divisao.TabIndex = 5;
            this.rdb_Divisao.TabStop = true;
            this.rdb_Divisao.Text = "Divisão";
            this.rdb_Divisao.UseVisualStyleBackColor = true;
            this.rdb_Divisao.CheckedChanged += new System.EventHandler(this.rdb_Divisao_CheckedChanged);
            // 
            // lbl_Erro
            // 
            this.lbl_Erro.AutoSize = true;
            this.lbl_Erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erro.Location = new System.Drawing.Point(305, 288);
            this.lbl_Erro.Name = "lbl_Erro";
            this.lbl_Erro.Size = new System.Drawing.Size(0, 24);
            this.lbl_Erro.TabIndex = 10;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(682, 280);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(131, 54);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "&Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(682, 426);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(131, 54);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(682, 350);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(131, 54);
            this.btn_Limpar.TabIndex = 7;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // pct_Imagem
            // 
            this.pct_Imagem.Image = ((System.Drawing.Image)(resources.GetObject("pct_Imagem.Image")));
            this.pct_Imagem.Location = new System.Drawing.Point(699, 12);
            this.pct_Imagem.Name = "pct_Imagem";
            this.pct_Imagem.Size = new System.Drawing.Size(273, 147);
            this.pct_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_Imagem.TabIndex = 15;
            this.pct_Imagem.TabStop = false;
            // 
            // frm_Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pct_Imagem);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_Erro);
            this.Controls.Add(this.rdb_Divisao);
            this.Controls.Add(this.rdb_Multiplicacao);
            this.Controls.Add(this.rdb_Subtracao);
            this.Controls.Add(this.rdb_Soma);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lbl_Operador);
            this.Controls.Add(this.lbl_Calculadora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Calculadora;
        private System.Windows.Forms.Label lbl_Operador;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.RadioButton rdb_Soma;
        private System.Windows.Forms.RadioButton rdb_Subtracao;
        private System.Windows.Forms.RadioButton rdb_Multiplicacao;
        private System.Windows.Forms.RadioButton rdb_Divisao;
        private System.Windows.Forms.Label lbl_Erro;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.PictureBox pct_Imagem;
    }
}