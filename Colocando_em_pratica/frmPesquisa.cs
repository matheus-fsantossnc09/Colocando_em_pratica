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
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }
        public void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisa.Enabled = true;
            btnVoltar.Enabled = true;
            ltbPesquisar.Enabled = true;
            txtDescricao.Focus();
        }
        public void limparCampos()
        {
            txtDescricao.Clear();
            ltbPesquisar.Items.Clear();
            txtDescricao.Focus();
        }
        public void limparCamposPesquisa()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Enabled = false;
            btnPesquisa.Enabled = false;
            btnLimpar.Enabled = false;
            btnVoltar.Enabled = false;
            txtDescricao.Clear();
            txtDescricao.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmfuncionariosCorreto abrir = new frmfuncionariosCorreto();
            abrir.Show();
            this.Hide();
;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;

            ltbPesquisar.Items.Add(descricao);
            limparCamposPesquisa();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = ltbPesquisar.Text;
            frmfuncionariosCorreto abr = new frmfuncionariosCorreto(descricao);
            abr.Show();
            this.Hide();
        }
    }
}
