using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace Servidor
{
    public partial class FrmServidor : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);
        public FrmServidor()
        {
            InitializeComponent();
        }

        // Este delegate é necessário para especificar os parametros que estamos pasando com o nosso evento
        public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
                // Analisa o endereço IP do servidor informado no textbox
                IPAddress enderecoIP = IPAddress.Parse(txtIpServidor.Text);

                // Cria uma nova instância do objeto ChatServidor
                ChatServidor mainServidor = new ChatServidor(enderecoIP);

                // Vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
                ChatServidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                // Inicia o atendimento das conexões
                mainServidor.IniciaAtendimento();

                // Mostra que nos iniciamos o atendimento para conexões
                txtLog.AppendText("Monitorando as conexões...\r\n");
        

        }
        private void AtualizaStatus(string strMensagem)
        {
            // Atualiza o logo com mensagens
            txtLog.AppendText(strMensagem + "\r\n");
        }
        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Chama o método que atualiza o formulário
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }
    }
}
