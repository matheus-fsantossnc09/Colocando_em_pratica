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
    public partial class frmfuncionariosCorreto : Form
    {
        public frmfuncionariosCorreto()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCPF.Enabled = false;
            dtpDataNascimento.Enabled = false;
            mskCelular.Enabled = false;

            rdbMasculino.Enabled = false;
            rdbFeminino.Enabled = false;
            rdbNaoInforma.Enabled = false;

            txtLogradouro.Enabled = false;
            mskCep.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cbbUf.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }
        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            dtpDataNascimento.Enabled = true;
            mskCelular.Enabled = true;

            rdbMasculino.Enabled = true;
            rdbFeminino.Enabled = true;
            rdbNaoInforma.Enabled = true;

            txtLogradouro.Enabled = true;
            mskCep.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbbUf.Enabled = true;

            btnNovo.Enabled = false;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            txtNome.Focus();
        }

        public void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
;            dtpDataNascimento.Text = "";
            mskCelular.Clear();

            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
            rdbNaoInforma.Checked = false;

            txtLogradouro.Clear();
            mskCep.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbbUf.Text = "";

        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frm_LoginValidar abrir = new frm_LoginValidar();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Equals("") || txtEmail.Equals("") || mskCPF.Equals("") || mskCelular.Equals("") || rdbMasculino.Checked || false && rdbFeminino.Checked || false || rdbNaoInforma.Checked == false || txtLogradouro.Equals("") || mskCep.Equals("") || txtNumero.Equals("") || txtComplemento.Equals("") || txtBairro.Equals("") || txtCidade.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
                desabilitarCampos();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa abrir = new frmPesquisa();
            abrir.ShowDialog();
            this.Hide();
        }
    }
}
