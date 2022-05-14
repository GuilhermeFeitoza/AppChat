using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChat.Telas
{
    public partial class FrmConectar : Form
    {
       public String UsuarioLogado = "";
        public FrmConectar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnConectar_Click(object sender, EventArgs e)
        {
            
            Telas.FrmPrincipal f = new FrmPrincipal(txtIp.Text,txtPorta.Text,UsuarioLogado);
            f.lblIp.Text = txtIp.Text;
            this.Visible = false;
            //f.lblLogado.Text = UsuarioLogado;
            f.ShowDialog();
        }
    
    }
}
