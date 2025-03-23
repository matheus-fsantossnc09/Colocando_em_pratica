using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colocando_em_pratica
{
    public partial class frm_Calculadora : Form
    {
        public frm_Calculadora()
        {
            InitializeComponent();
            messagemEntrada();
        }
        public void limparCampos()
        {
            txt_Num1.Clear();
            txt_Num2.Clear();
        }
        public void LimparTodos()
        {
            txt_Num1.Clear();
            txt_Num2.Clear();
            txt_Resultado.Clear();

            rdb_Soma.Checked = false;
            rdb_Subtracao.Checked = false;
            rdb_Multiplicacao.Checked = false;
            rdb_Divisao.Checked = false;
            txt_Num1.Focus();
        }
        public void messagemEntrada()
        {
            MessageBox.Show("Bem - vindo a Calculadora",
                "Calculadora",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }
        private static double Somar(double num1, double num2)
        {
            return num1 + num2;
        }
        private static double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }
        private static double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }
        private static double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
        private bool validarEspaco()
        {
            if (string.IsNullOrWhiteSpace(txt_Num1.Text))
            {
                lbl_Erro.Text = "O primeiro número é necessário";
                lbl_Erro.ForeColor = Color.Red;
                txt_Num1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Num2.Text))
            {
                lbl_Erro.Text = "O segundo número é necessário";
                lbl_Erro.ForeColor = Color.Red;
                txt_Num2.Focus();
                return false;
            }
            try
            {
                double dobubleValor1 = Convert.ToDouble(txt_Num1.Text);
                double dobubleValor2 = Convert.ToDouble(txt_Num2.Text);
                return true;
            }
            catch
            {
                lbl_Erro.Text = "Só insira números";
                lbl_Erro.ForeColor = Color.Red;
                limparCampos();
                txt_Num1.Focus();
                return false;
            }

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            txt_Resultado.Clear();
            lbl_Erro.Text = "";

            if (!validarEspaco())
            {
                return;
            }
            double doubleValor1 = Convert.ToDouble(txt_Num1.Text);
            double doubleValor2 = Convert.ToDouble(txt_Num2.Text);
            double resultado;

            switch (lbl_Operador.Text)
            {
                case "+":
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
                case "-":
                    resultado = Subtrair(doubleValor1, doubleValor2);
                    break;
                case "*":
                    resultado = Multiplicar(doubleValor1, doubleValor2);
                    break;
                case "/":
                    resultado = Dividir(doubleValor1, doubleValor2);
                    break;
                default:
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
            }
            txt_Resultado.Text = Convert.ToString(resultado);
            limparCampos();

        }

        private void rdb_Soma_CheckedChanged(object sender, EventArgs e)
        {
            txt_Num1.Visible = true;
            lbl_Operador.Text = "+";
        }

        private void rdb_Subtracao_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Operador.Text = "-";
        }

        private void rdb_Multiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Operador.Text = "*";
        }

        private void rdb_Divisao_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Operador.Text = "/";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparTodos();
        }

        private void txt_Num1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Num2.Focus();
            }
        }

        private void txt_Num2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Calcular.Focus();
            }
        }
    }
}
