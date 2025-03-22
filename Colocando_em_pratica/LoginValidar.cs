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
    public partial class frm_LoginValidar : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        public frm_LoginValidar()
        {
            InitializeComponent();
            inicializarLogin();
        }
        public void inicializarLogin()
        {
            usuarios.Add(new Usuario()
            { Email = "matheus.f", Senha = "SemSenha" });
            usuarios.Add(new Usuario()
            { Email = "matheusf", Senha = "090424" });
            usuarios.Add(new Usuario()
            { Email = "Testando", Senha = "Treinamento" });

        }
        public bool ValidarLogin(string usuario, string senha)
        {
            
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessagemErro("A usuário é necessário", txt_UsuarioLogin);
                return false;
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                MessagemErro("A senha é necessário", txt_SenhaLogin);
                return false;
            }
            return usuarios.Any(u => u.Email == usuario && u.Senha == senha);
        }

       
        public bool ValidarCadastrado(string usuario, string senha)
        {

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessagemErro("A usuário é necessário", txt_NovoUsuario);
                return false;
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                MessagemErro("A senha é necessário", txt_SenhaNova);
                return false;
            }
            if (usuarios.Any(u => u.Email == usuario))
            {
                lbl_Cadastrado.Text = "Usuário já existe cadastrado";
                lbl_Cadastrado.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        public void MessagemErro(string messagem, Control foco)
        {
            lbl_Autenticado.Text = messagem;
            lbl_Autenticado.ForeColor = Color.Red;
            foco.Focus();
        }

        public void LimparLogin()
        {
            txt_UsuarioLogin.Clear();
            txt_SenhaLogin.Clear();
        }
        public void LimparNovoUsuario()
        {
            txt_NovoUsuario.Clear();
            txt_SenhaNova.Clear();
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            
            string usuarioBuscado = txt_UsuarioLogin.Text;
            string senha = txt_SenhaLogin.Text;


            if (ValidarLogin(usuarioBuscado,senha))
            {
               
                lbl_Autenticado.Text = "Autenticado com sucesso";
                lbl_Autenticado.ForeColor = Color.Green;
                LimparLogin();

                frmCalculadora abrir = new frmCalculadora();
                abrir.Show();
                this.Hide();

            }
            else
            {
                lbl_Autenticado.Text = "A usuário ou senha incorreta";
                lbl_Autenticado.ForeColor = Color.Red;
                lbl_SenhaLogin.Focus();
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string novoUsuario = txt_NovoUsuario.Text;
            string novaSenha = txt_SenhaNova.Text;

            if (ValidarCadastrado(novoUsuario, novaSenha))
            {
                usuarios.Add(new Usuario() { Email = novoUsuario, Senha = novaSenha });
                lbl_Cadastrado.Text = "Autenticado com sucesso";
                lbl_Cadastrado.ForeColor = Color.Green;
                LimparNovoUsuario();
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_UsuarioLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_SenhaLogin.Focus();
            }
        }

        private void txt_SenhaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Entrar.Focus();
            }
        }

        private void btn_Entrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmCalculadora abrir = new frmCalculadora();
                abrir.Show();
                this.Hide();
            }
        }

        private void txt_NovoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SenhaNova.Focus();
            }
        }

        private void txt_SenhaNova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Cadastrar.Focus();
            }
        }

        private void btn_Cadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_UsuarioLogin.Focus();
            }
        }
    }
}
