using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChat
{
    public partial class FrmLogin : Form
    { 
        public FrmLogin()
        {
         InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Telas.FrmConectar f= new Telas.FrmConectar();

            DAO.Conexao c = new DAO.Conexao();
            DAO.Login l = new DAO.Login();
            bool existe = l.Logar(c.CriarConexao(), txtUsuario.Text.Trim(), txtSenha.Text.Trim());
            if (existe)
            {
                f.UsuarioLogado = txtUsuario.Text;
                this.Visible = false;
                f.ShowDialog();
            }
            else {

                MessageBox.Show("Usuário/Senha invalido!!");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Telas.FrmUsuario  f = new Telas.FrmUsuario();
            f.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Telas.FrmConectar f = new Telas.FrmConectar();
            f.UsuarioLogado = "Convidado "+ DateTime.Now.Second.ToString();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
