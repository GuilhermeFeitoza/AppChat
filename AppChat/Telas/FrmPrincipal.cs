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
    public partial class FrmPrincipal : Form
    {
        public String Ip;
        public String Porta;
        public String usuarioLogado;
        public FrmPrincipal(string ip,string porta, string usuario)
        {
            Ip = ip; 
            Porta = porta;
            usuarioLogado = usuario;
         
            // se não esta conectando aguarda a conexão
          
            InitializeComponent();
     
        }
       
        private void pbEnviar_Click(object sender, EventArgs e)
        {

        }
    
      
        private void txtMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                txtMensagemDigitada.Clear();
                MessageBox.Show("enviou"); 
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
