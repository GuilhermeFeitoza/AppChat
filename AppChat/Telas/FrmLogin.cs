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
            f.UsuarioLogado = txtUsuario.Text;
            this.Visible = false;
            DAO.Conexao c = new DAO.Conexao();
            DAO.Login l = new DAO.Login();
            bool existe = l.Logar(c.CriarConexao(), txtUsuario.Text.Trim(), txtSenha.Text.Trim());
            if (existe)
            {
                f.ShowDialog();
            }
            else {

                MessageBox.Show("Usuário/Senha invalido!!");
            }

        }
    }
}
