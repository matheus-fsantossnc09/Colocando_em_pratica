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
    public partial class frmExercicios : Form
    {
        public frmExercicios()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            txt_num1.Clear();
            txt_Num2.Clear();
            txt_num1.Focus();

        }
        private void btn_Somar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            try
            {

                num1 = Convert.ToDouble(txt_num1.Text);
                num2 = Convert.ToDouble(txt_Num2.Text);

                resultado = num1 + num2;

                txt_Resultado.Text = resultado.ToString();
                limparCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira somente números",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }

        }

        private void btn_Azul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btn_Amarelo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btn_Verde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        public void atualizarContador()
        {
            double clique = 0;
           
            clique++;
            lbl_Contador.Text = Convert.ToString(clique);

        }
            

        private void bttn_Clica_Click(object sender, EventArgs e)
        {
            atualizarContador();
        }
    }
}
