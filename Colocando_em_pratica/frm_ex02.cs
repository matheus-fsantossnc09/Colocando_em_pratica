using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colocando_em_pratica
{
    public partial class frm_ex02: Form
    {
        public frm_ex02()
        {
            InitializeComponent();
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            frm_Revisao frm_Revisao = new frm_Revisao();
            frm_Revisao.Show();
            this.Hide();
        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_Valor1.Text);
            double num2 = Convert.ToDouble(txt_Valor2.Text);
            double resultadoSoma = num1 + num2;

            lbl_Resultado.Text = resultadoSoma.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_Valor1.Text);
            double num2 = Convert.ToDouble(txt_Valor2.Text);
            double resultadoDivisao = num1 / num2;

            lbl_Resultado.Text = resultadoDivisao.ToString();

        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_Valor1.Text);
            double num2 = Convert.ToDouble(txt_Valor2.Text);
            double resultadoSubtracacao = num1 - num2;

            lbl_Resultado.Text = resultadoSubtracacao.ToString();
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_Valor1.Text);
            double num2 = Convert.ToDouble(txt_Valor2.Text);
            double resultadoMultiplicacao = num1 * num2;

            lbl_Resultado.Text = resultadoMultiplicacao.ToString();
        }
    }

}
