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
    public partial class frm_Revisao: Form
    {
        public frm_Revisao()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Mudar_Click(object sender, EventArgs e)
        {
            lbl_Texto.Text = txt_Texto.Text;
            txt_Texto.Clear();
        }

        private void lbl_Texto_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            lbl_Texto.Text = "Texto";
            lbl_Texto.ForeColor = Color.Black;
        }

        private void txt_Texto_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            frm_ex02 Frm_Ex02 = new frm_ex02();
            Frm_Ex02.Show();
            this.Hide();
        }
    }
}
