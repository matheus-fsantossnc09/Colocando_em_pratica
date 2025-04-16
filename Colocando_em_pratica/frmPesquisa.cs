using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public void pesquisarPorCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionariosCorretos where codFunC = @codFunC;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunC", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conectado.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            try
            {
                ltbPesquisar.Items.Add(DR.GetString(0));
            }
            catch (Exception)
            {
                MessageBox.Show("Registro não encontrado");
                txtDescricao.Clear();
                txtDescricao.Focus();
            }
            Conectado.fechaConexao();
        }
        public void pesquisaPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionariosCorretos where nome like '%" + descricao + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = descricao;

            comm.Connection = Conectado.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                ltbPesquisar.Items.Add((DR.GetString(0)));
            }
            Conectado.fechaConexao();
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
            if (rdbCodigo.Checked)
            {
                pesquisarPorCodigo(Convert.ToInt32(txtDescricao.Text));
            }
            if (rdbNome.Checked)
            {
                pesquisaPorNome(txtDescricao.Text);
            }
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
