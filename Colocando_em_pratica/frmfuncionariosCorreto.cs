using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosaicoSolutions.ViaCep;
using MosaicoSolutions.ViaCep.Util;
using MySql.Data.MySqlClient;
    
namespace Colocando_em_pratica
{
    public partial class frmfuncionariosCorreto : Form
    {
        public frmfuncionariosCorreto()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public frmfuncionariosCorreto(string descricao)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = descricao;
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

        public void buscarCep(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            try
            {

                var endereco = viaCEPService.ObterEndereco(cep);

                txtLogradouro.Text = endereco.Logradouro;
                txtComplemento.Text = endereco.Complemento;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Localidade;
                cbbUf.Text = endereco.UF;
            }
            catch(Exception)
            {
                MessageBox.Show("Por favor insira Cep válido",
                    "Messagem do sistema");
                mskCep.Clear();
                mskCep.Focus();
            }

        }

        public int cadastrarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionariosCorretos(nome,email,cpf,dataNasci,telCelu,sexo,logradouro,cep,numero,complemento,bairro,cidade,uf)values(@nome,@email,@cpf,@dataNasci,@telCelu,@sexo,@logradouro,@cep,@numero,@complemento,@bairro,@cidade,@uf);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("@dataNasci", MySqlDbType.Date).Value = dtpDataNascimento.Value;
            comm.Parameters.Add("@telCelu", MySqlDbType.VarChar, 10).Value = mskCelular.Text;
            if (rdbFeminino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";

            }
            if (rdbMasculino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";

            }
            if (rdbNaoInforma.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";

            }
            comm.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = txtLogradouro.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCep.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = txtComplemento.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = cbbUf.Text;

            comm.Connection = Conectado.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conectado.fechaConexao();

            return resp;
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
            if (txtNome.Equals("") || txtEmail.Equals("") || mskCPF.Equals("") || mskCelular.Equals("") || txtLogradouro.Equals("") || mskCep.Equals("") || txtNumero.Equals("") || txtComplemento.Equals("") || txtBairro.Equals("") || txtCidade.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                if(cadastrarFuncionarios() == 1)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!",
                   "Sucesso");
                    limparCampos();
                    desabilitarCampos();
                    btnNovo.Enabled = true;
                }
               else
                {
                    MessageBox.Show("Erro ao cadastrar funcionário");
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa abrir = new frmPesquisa();
            abrir.ShowDialog();
            this.Hide();
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarCep(mskCep.Text);
                txtNumero.Focus();
            }
        }
    }
}
