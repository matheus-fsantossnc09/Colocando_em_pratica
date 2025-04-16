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
            habilitarCamposPesquisa();
            pesquisaNome(txtNome.Text);
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

        public void habilitarCamposPesquisa()
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
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
        }

        public void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            ; dtpDataNascimento.Text = "";
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
            catch (Exception)
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
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
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

        public void pesquisaNome(string nome)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "select * from tbFuncionariosCorretos where nome = @nome;";
            conn.CommandType = CommandType.Text;

            conn.Parameters.Clear();
            conn.Parameters.Add("nome", MySqlDbType.VarChar, 100).Value = nome;
            conn.Connection = Conectado.obterConexao();

            MySqlDataReader DR;
            DR = conn.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mskCPF.Text = DR.GetString(3);
            dtpDataNascimento.Value = DR.GetDateTime(4);
            mskCelular.Text = DR.GetString(5);
            string sexo = DR.GetString(6);
            if (sexo == "F")
            {
                rdbFeminino.Checked = true;
            }
            if (sexo == "M")
            {
                rdbMasculino.Checked = true;
            }
            if (sexo == "N")
            {
                rdbNaoInforma.Checked = true;
            }
            txtLogradouro.Text = DR.GetString(7);
            mskCep.Text = DR.GetString(8);
            txtNumero.Text = DR.GetString(9);
            txtComplemento.Text = DR.GetString(10);
            txtBairro.Text = DR.GetString(11);
            txtCidade.Text = DR.GetString(12);
            cbbUf.Text = DR.GetString(13);

            Conectado.fechaConexao();
        }

        public int alterarFuncionarios(int codFunc)
        {
            MySqlCommand conn = new MySqlCommand();
            conn.CommandText = "update tbFuncionariosCorretos set nome = @nome,email = @email,cpf = @cpf,dataNasci = @dataNasci,telCelu = @telCelu,sexo = @sexo,logradouro = @logradouro,cep = @cep,numero = @numero,complemento = @complemento,bairro = @bairro,cidade = @cidade,uf = @uf WHERE codFunC = codFunC;";
            conn.CommandType = CommandType.Text;

            conn.Parameters.Clear();
            conn.Parameters.Add("@codFunC", MySqlDbType.Int32).Value = codFunc;
            conn.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            conn.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            conn.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            conn.Parameters.Add("@dataNasci", MySqlDbType.Date).Value = dtpDataNascimento.Value;
            conn.Parameters.Add("@telCelu", MySqlDbType.VarChar,10).Value = mskCelular.Text;

            if (rdbFeminino.Checked)
            {
                conn.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";
            }
            if (rdbMasculino.Checked)
            {
                conn.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";
            }
            if (rdbNaoInforma.Checked)
            {
                conn.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";
            }
            conn.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = txtLogradouro.Text;
            conn.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCep.Text;
            conn.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            conn.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = txtComplemento.Text;
            conn.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro;
            conn.Parameters.Add("@cidade", MySqlDbType.VarChar,100).Value = txtCidade.Text;
            conn.Parameters.Add("@uf", MySqlDbType.VarChar,2).Value = cbbUf.Text;
           
            conn.Connection = Conectado.obterConexao();

            int resp = conn.ExecuteNonQuery();

            Conectado.fechaConexao();

            return resp;
        }

        public int excluirFuncionarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbFuncionariosCorretos where codFunC = @codFunC;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conectado.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;

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
                if (cadastrarFuncionarios() == 1)
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

        private void btnAlterar_Click(object sender, EventArgs e)
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
                int resp = alterarFuncionarios(Convert.ToInt32(txtCodigo.Text));

                if (resp == 1)
                {
                    MessageBox.Show("Alterado com sucesso");
                    limparCampos();
                    desabilitarCampos();
                    btnNovo.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro no alterar");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?",
                "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                excluirFuncionarios(Convert.ToInt32(txtCodigo.Text));
                limparCampos();
            }
            else
            {

            }
        }
    }
}
